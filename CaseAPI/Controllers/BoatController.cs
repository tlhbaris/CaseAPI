using CaseAPI.Business.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet]
        [Route("[action]/{color}")]
        public async Task<IActionResult> GetBoatsByColor(string color)
        {
            try
            {
                var boats = await _boatService.GetBoatsByColor(color);
                return Ok(boats);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
            
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteBoat(int id)
        {
            try
            {
                await _boatService.DeleteBoatById(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
            
        }

    }
}
