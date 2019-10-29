using AutoMapper;
using StarWars.Context.Models;
using StarWars.Repositories;
using StarWars.Services.Dto;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository peopleRepository;
        private readonly IMapper mapper;
        public PeopleService(IPeopleRepository peopleRepository,
            IMapper mapper)
        {
            this.peopleRepository = peopleRepository;
            this.mapper = mapper;
        }

        public async Task<PeopleDto> Create(PeopleDto peopleDto)
        {
            var entity = mapper.Map<People>(peopleDto);

            await peopleRepository.CreateAsync(entity);
            await peopleRepository.SaveAsync();

            peopleDto.Id = entity.Id;

            return peopleDto;
        }

        public async Task DeleteAsync(int id)
        {
            await peopleRepository.DeleteAsync(id);
            await peopleRepository.SaveAsync();
        }

        public async Task<PeopleDto> Get(int id)
        {
            var entity = await peopleRepository.GetByIdAsync(id);
            var result = mapper.Map<PeopleDto>(entity);
            return result;
        }

        public async Task<PageDto<PeopleDto>> GetPageAsync(int pageIndex, int itemPerPage)
        {
            var dbResult = await peopleRepository.PagedIndex(pageIndex, itemPerPage);
            var result = mapper.Map<PageDto<PeopleDto>>(dbResult);

            return result;
        }

        public async Task<PeopleDto> Random()
        {
            var ids = peopleRepository.Select().Select(x=> x.Id).ToList();
            var id = RandomNumber.GetFromRange(1,ids.Count);
            return await Get(ids[id]);
        }

        public async Task<PeopleDto> Update(PeopleDto peopleDto)
        {
            var entity = mapper.Map<People>(peopleDto);
            await peopleRepository.UpdateAsync(entity, peopleDto.Id);
            await peopleRepository.SaveAsync();
            var result = mapper.Map<PeopleDto>(entity);
            return result;
        }
    }
}
