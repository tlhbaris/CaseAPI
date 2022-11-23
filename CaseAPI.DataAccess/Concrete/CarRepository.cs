using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess.Concrete;

public class CarRepository : ICarRepository
{
    public async Task<List<CarDto>> GetCarsByColor(string color)
    {
        using (var context = new CaseDbContext())
        {
            var responseObj = new List<CarDto>();
            var res = await context.Cars.Where(x => x.Color == color).ToListAsync();
            foreach (var item in res)
            {
                var carDto = new CarDto()
                {
                    Id = item.Id,
                    Color = item.Color,
                    Headlights = item.Headlights,
                    Wheels = item.Wheels
                };
                responseObj.Add(carDto);
            }

            return responseObj;
        }
    }

    public async Task ToggleHeadlightsById(int id, bool command)
    {
        using (var context = new CaseDbContext())
        {
            var car = await context.Cars.FindAsync(id);
            car.Headlights = command;
            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteCarById(int id)
    {
        using (var context = new CaseDbContext())
        {
            var car = await context.Cars.FindAsync(id);
            context.Cars.Remove(car);
            await context.SaveChangesAsync();
        }
    }
}