using StarWars.Context;
using StarWars.Context.Models;

namespace StarWars.Repositories
{
    public class PeopleRepository : BaseRepository<People, int>, IPeopleRepository
    {
        public PeopleRepository(StarWarsDbContext dbContext): base(dbContext)
        {} 
    }
}
