using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWars.Services;
using StarWars.Services.Dto;

namespace StarWars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarsShipController : ControllerBase
    {
        private readonly IStarsShipService starsShipService;
        public StarsShipController(IStarsShipService starsShipService)
        {
            this.starsShipService = starsShipService;
        }

        [HttpGet]
        [Route("Page")]
        public async Task<PageDto<StarsShipDto>> Page(int pageIndex, int itemPerPage)
        {
            var result = await starsShipService.GetPageAsync(pageIndex, itemPerPage);
            return result;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<StarsShipDto> GetById(int id)
        {
            StarsShipDto result = await starsShipService.Get(id);
            return result;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<StarsShipDto> Create(StarsShipDto starsShipDto)
        {
            StarsShipDto result = await starsShipService.Create(starsShipDto);
            return result;
        }

        [HttpGet]
        [Route("Random")]
        public async Task<StarsShipDto> Random(int id)
        {
            StarsShipDto result = await starsShipService.Random();
            return result;
        }

        [HttpPost]
        [Route("Update")]
        public async Task<StarsShipDto> Update(StarsShipDto starsShipDto)
        {
            StarsShipDto result = await starsShipService.Update(starsShipDto);
            return result;
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await starsShipService.DeleteAsync(id);
        }
    }
}
