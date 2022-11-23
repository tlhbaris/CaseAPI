using CaseAPI.DataAccess.DTOs;

namespace CaseAPI.Business.Abstract;

public interface IBoatService
{
    Task<List<BoatDto>> GetBoatsByColor(string color);
    Task DeleteBoatById(int id);
}