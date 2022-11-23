using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.DataAccess.Abstract;

public interface ICarRepository
{
    Task<List<CarDto>> GetCarsByColor(string color);
    Task ToggleHeadlightsById(int id,bool command);
    Task DeleteCarById(int id);
}