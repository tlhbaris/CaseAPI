using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.Business.Abstract;

public interface ICarService
{
    Task<List<CarDto>> GetCarsByColor(string color);
    Task ToggleHeadlightsById(int id,bool command);
    Task DeleteCarById(int id);
}