using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.DataAccess.Abstract;

public interface IBoatRepository
{
    Task<List<BoatDto>> GetBoatsByColor(string color);
    Task DeleteBoatById(int id);
}