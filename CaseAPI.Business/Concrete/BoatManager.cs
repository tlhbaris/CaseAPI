using CaseAPI.Business.Abstract;
using CaseAPI.DataAccess;
using CaseAPI.DataAccess.Abstract;
using CaseAPI.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.Business.Concrete;

public class BoatManager : IBoatService
{
    private readonly IBoatRepository _boatRepository;

    public BoatManager(IBoatRepository boatRepository)
    {
        _boatRepository = boatRepository;
    }

    public async Task<List<BoatDto>> GetBoatsByColor(string color)
    {
        return await _boatRepository.GetBoatsByColor(color);
    }

    public async Task DeleteBoatById(int id)
    {
        await _boatRepository.DeleteBoatById(id);
    }
}