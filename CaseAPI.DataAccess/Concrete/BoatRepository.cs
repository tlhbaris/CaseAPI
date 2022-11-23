using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess.Concrete;

public class BoatRepository : IBoatRepository
{
    public async Task<List<BoatDto>> GetBoatsByColor(string color)
    {
        using (var context = new CaseDbContext())
        {
            var responseObj = new List<BoatDto>();
            var res = await context.Boats.Where(x => x.Color == color).ToListAsync();
            foreach (var item in res)
            {
                var boatDto = new BoatDto()
                {
                    Id = item.Id,
                    Color = item.Color,
                    Length = item.Length,
                    WithSail = item.WithSail
                };
                responseObj.Add(boatDto);
            }

            return responseObj;
        }
    }

    public async Task DeleteBoatById(int id)
    {
        using (var context = new CaseDbContext())
        {
            var boat = await context.Boats.FindAsync(id);
            context.Boats.Remove(boat);
            await context.SaveChangesAsync();
        }
    }
}