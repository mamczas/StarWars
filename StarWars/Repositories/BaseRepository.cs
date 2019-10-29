﻿using Microsoft.EntityFrameworkCore;
using StarWars.Context;
using StarWars.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Repositories
{
    public abstract class BaseRepository<TEntity, Key> : IRepository<TEntity, Key>
        where TEntity : class, IDataEntity
    {
        protected readonly StarWarsDbContext dbContext;
        public BaseRepository(StarWarsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public virtual async Task CreateAsync(TEntity entity)
        {
            entity.Created = DateTime.UtcNow;
            await dbContext.Set<TEntity>().AddAsync(entity);
        }

        public virtual async Task DeleteAsync(Key id)
        {
            var dbSet = dbContext.Set<TEntity>();
            var entity = await dbSet.FindAsync(id);
            if(entity == null)
            {
                throw new ArgumentException($"Invalid key provided: {id} . Couldn't find a {typeof(TEntity)} with this ID.");
            }
            
            dbSet.Attach(entity);
            dbSet.Remove(entity);
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Key id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> Select()
        {
            return dbContext.Set<TEntity>().AsQueryable();
        }

        public virtual async Task UpdateAsync(TEntity entity, Key key)
        {
            var item = await GetByIdAsync(key);
            if (item == null)
            {
                throw new ArgumentException($"Invalid key provided: {key} . Couldn't find a {typeof(TEntity)} with this ID.");
            }

            entity.Created = item.Created;
            entity.Edited = DateTime.UtcNow;

            dbContext.Entry(item).CurrentValues.SetValues(entity);
        }

        public async Task<Page<TEntity>> PagedIndex(int pageIndex, int itemsPerPage)
        {
            var count = await Select().CountAsync();
            var pagination = new Pagination(count, itemsPerPage);
            if (pageIndex < pagination.MinPage || pageIndex > pagination.MaxPage)
            {
                throw new ArgumentOutOfRangeException(null,
                $"*** Page index must >= {pagination.MinPage} and =< { pagination.MaxPage }! * **");
            }

            var query = await Select()
                .Skip(pagination.GetSkip(pageIndex))
                .Take(pagination.PageSize).ToListAsync();

            var result = new Page<TEntity>
            {
                MaxPage = pagination.MaxPage,
                PageCollecion = query
            };

            return result;
        }
    }
}

