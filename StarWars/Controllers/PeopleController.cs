using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWars.Services;
using StarWars.Services.Dto;

namespace StarWars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService peopleService;
        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        [HttpGet]
        [Route("Page")]
        public async Task<PageDto<PeopleDto>> Page(int pageIndex, int itemPerPage)
        {
            var result = await peopleService.GetPageAsync(pageIndex, itemPerPage);
            return result;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<PeopleDto> GetById(int id)
        {
            PeopleDto result = await peopleService.Get(id);
            return result;
        }

        [HttpGet]
        [Route("Random")]
        public async Task<PeopleDto> Random(int id)
        {
            PeopleDto result = await peopleService.Random();
            return result;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<PeopleDto> Create(PeopleDto peopleDto)
        {
            PeopleDto result = await peopleService.Create(peopleDto);
            return result;
        }

        [HttpPost]
        [Route("Update")]
        public async Task<PeopleDto> Update(PeopleDto peopleDto)
        {
            PeopleDto result = await peopleService.Update(peopleDto);
            return result;
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await peopleService.DeleteAsync(id);
        }
    }
}
