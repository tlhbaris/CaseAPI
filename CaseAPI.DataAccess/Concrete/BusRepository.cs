using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess.Concrete;

public class BusRepository : IBusRepository
{
    public async Task<List<BusDto>> GetBusesByColor(string color)
    {
        using (var context = new CaseDbContext())
        {
            var responseObj = new List<BusDto>();
            var res = await context.Buses.Where(x => x.Color == color).ToListAsync();
            foreach (var item in res)
            {
                var busDto = new BusDto()
                {
                    Id = item.Id,
                    Color = item.Color,
                    Headlights = item.Headlights,
                    Wheels = item.Wheels,
                    Capacity = item.Capacity
                };
                responseObj.Add(busDto);
            }

            return responseObj;
        }
    }

    public async Task ToggleHeadlightsById(int id, bool command)
    {
        using (var context = new CaseDbContext())
        {
            var bus = await context.Buses.FindAsync(id);
            bus.Headlights = command;
            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteBusById(int id)
    {
        using (var context = new CaseDbContext())
        {
            var bus = await context.Buses.FindAsync(id);
            context.Buses.Remove(bus);
            await context.SaveChangesAsync();
        }
    }
}