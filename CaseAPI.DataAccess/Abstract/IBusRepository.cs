using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.DataAccess.Abstract;

public interface IBusRepository
{
    Task<List<BusDto>> GetBusesByColor(string color);
    Task ToggleHeadlightsById(int id, bool command);
    Task DeleteBusById(int id);
}