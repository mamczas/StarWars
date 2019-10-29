using System.Collections.Generic;

namespace StarWars.Context.Models
{
    public class Page<TEntity> where TEntity: IDataEntity
    {
        public List<TEntity> PageCollecion { get; set; }
        public int MaxPage { get; set; }
    }
}
