using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZwalkAPI.Data;
using NZwalkAPI.Models.Doman;
using NZwalkAPI.Models.Dto;

namespace NZwalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalkDbContext contex;

        public RegionsController(NZWalkDbContext contex)
        {
            this.contex = contex;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var regionsdomain = contex.Regions.ToList();
            //return Ok(regions);

            //Map With RegionDto
            var regiondto = new List<RegionDTO>();
            foreach (var region in regionsdomain) {
                regiondto.Add(new RegionDTO()
                {
                    Id = region.Id,
                    code = region.code,
                    name = region.name,
                    RegionImageUrl = region.RegionImageUrl

                });
                }
            return Ok(regiondto);
        }
        



        [HttpGet("{id}")]
        public IActionResult GetRegionById([FromBody]Guid id)
        {
            var region = contex.Regions.Find(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);

        }
        [HttpPost]
        public IActionResult Update()
        {
            return Created();
        }
    }
}
            

