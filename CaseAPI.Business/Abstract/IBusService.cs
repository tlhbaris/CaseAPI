using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.Business.Abstract;

public interface IBusService
{
    Task<List<BusDto>> GetBusesByColor(string color);
    Task ToggleHeadlightsById(int id, bool command);
    Task DeleteBusById(int id);
}