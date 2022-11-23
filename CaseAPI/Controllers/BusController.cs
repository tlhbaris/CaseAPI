using CaseAPI.Business.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CaseAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusController : ControllerBase
{
    private readonly IBusService _busService;

    public BusController(IBusService busService)
    {
        _busService = busService;
    }

    [HttpGet]
    [Route("[action]/{color}")]
    public async Task<IActionResult> GetBusesByColor(string color)
    {
        try
        {
            var buses = await _busService.GetBusesByColor(color);
            return Ok(buses);
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }

    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> ToggleHeadlightsById(ToggleHeadlightParams parameters)
    {
        try
        {
            await _busService.ToggleHeadlightsById(parameters.Id, parameters.Command);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    public async Task<IActionResult> DeleteBus(int id)
    {
        try
        {
            await _busService.DeleteBusById(id);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }

    }
}