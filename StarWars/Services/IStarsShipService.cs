using StarWars.Services.Dto;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public interface IStarsShipService
    {
        Task<PageDto<StarsShipDto>> GetPageAsync(int pageIndex, int itemPerPage);
        Task<StarsShipDto> Get(int id);
        Task<StarsShipDto> Create(StarsShipDto peopleDto);
        Task<StarsShipDto> Update(StarsShipDto peopleDto);
        Task DeleteAsync(int id);
        Task<StarsShipDto> Random();
    }
}