using StarWars.Context;
using StarWars.Context.Models;

namespace StarWars.Repositories
{
    public class StarsShipRepository : BaseRepository<StarsShip, int>, IStarsShipRepository
    {
        public StarsShipRepository(StarWarsDbContext dbContext): base(dbContext)
        {} 
    }
}
