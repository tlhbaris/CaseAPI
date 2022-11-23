using CaseAPI.Business.Abstract;
using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.Business.Concrete;

public class BusManager : IBusService
{
    private readonly IBusRepository _busRepository;

    public BusManager(IBusRepository busRepository)
    {
        _busRepository = busRepository;
    }

    public async Task<List<BusDto>> GetBusesByColor(string color)
    {
        return await _busRepository.GetBusesByColor(color);
    }

    public async Task ToggleHeadlightsById(int id, bool command)
    {
         await _busRepository.ToggleHeadlightsById(id, command);
    }

    public async Task DeleteBusById(int id)
    {
         await _busRepository.DeleteBusById(id);
    }
}