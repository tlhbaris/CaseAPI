using CaseAPI.Business.Abstract;
using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarRepository _carRepository;

    public CarManager(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public async Task<List<CarDto>> GetCarsByColor(string color)
    { 
        return await _carRepository.GetCarsByColor(color);
    }

    public async Task ToggleHeadlightsById(int id, bool command)
    {
        await _carRepository.ToggleHeadlightsById(id, command);
    }

    public async Task DeleteCarById(int id)
    {
        await _carRepository.DeleteCarById(id);
    }
}