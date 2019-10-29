using AutoMapper;
using StarWars.Context.Models;
using StarWars.Repositories;
using StarWars.Services.Dto;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class StarsShipService : IStarsShipService
    {
        private readonly IStarsShipRepository starsShipRepository;
        private readonly IMapper mapper;
        public StarsShipService(IStarsShipRepository starsShipRepository,
            IMapper mapper)
        {
            this.starsShipRepository = starsShipRepository;
            this.mapper = mapper;
        }

        public async Task<StarsShipDto> Create(StarsShipDto starsShipDto)
        {
            var entity = mapper.Map<StarsShip>(starsShipDto);

            await starsShipRepository.CreateAsync(entity);
            await starsShipRepository.SaveAsync();

            starsShipDto.Id = entity.Id;

            return starsShipDto;
        }

        public async Task DeleteAsync(int id)
        {
            await starsShipRepository.DeleteAsync(id);
            await starsShipRepository.SaveAsync();
        }

        public async Task<StarsShipDto> Get(int id)
        {
            var entity = await starsShipRepository.GetByIdAsync(id);
            var result = mapper.Map<StarsShipDto>(entity);
            return result;
        }

        public async Task<PageDto<StarsShipDto>> GetPageAsync(int pageIndex, int itemPerPage)
        {
            var dbResult = await starsShipRepository.PagedIndex(pageIndex, itemPerPage);
            var result = mapper.Map<PageDto<StarsShipDto>>(dbResult);

            return result;
        }

        public async Task<StarsShipDto> Random()
        {
            var ids = starsShipRepository.Select().Select(x => x.Id).ToList();
            var id = RandomNumber.GetFromRange(1, ids.Count);
            return await Get(ids[id]);
        }

        public async Task<StarsShipDto> Update(StarsShipDto peopleDto)
        {
            var entity = mapper.Map<StarsShip>(peopleDto);
            await starsShipRepository.UpdateAsync(entity, peopleDto.Id);
            await starsShipRepository.SaveAsync();
            var result = mapper.Map<StarsShipDto>(entity);
            return result;
        }
    }
}
