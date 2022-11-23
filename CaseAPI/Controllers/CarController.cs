using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CaseAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly ICarRepository _carRepository;


    public CarController(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    [HttpGet]
    [Route("[action]/{color}")]
    public async Task<IActionResult> GetCarsByColor(string color)
    {
        try
        {
            var cars = await _carRepository.GetCarsByColor(color);
            return Ok(cars);
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
            await _carRepository.ToggleHeadlightsById(parameters.Id, parameters.Command);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    public async Task<IActionResult> DeleteCarById(int id)
    {
        try
        {
            await _carRepository.DeleteCarById(id);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500);
        }

    }
}