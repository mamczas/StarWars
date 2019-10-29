using StarWars.Services.Dto;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public interface IPeopleService
    {
        Task<PageDto<PeopleDto>> GetPageAsync(int pageIndex, int itemPerPage);
        Task<PeopleDto> Get(int id);
        Task<PeopleDto> Create(PeopleDto peopleDto);
        Task<PeopleDto> Update(PeopleDto peopleDto);
        Task DeleteAsync(int id);
        Task<PeopleDto> Random();
    }
}