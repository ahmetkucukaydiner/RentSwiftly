using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.CarInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Persistence.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
    private readonly RentSwiftlyContext _context;

    public CarRepository(RentSwiftlyContext context)
    {
        _context = context;
    }

    public List<Car> GetCarsListWithBrands()
    {
        var values = _context.Cars.Include(x=>x.Brand).ToList();
        return values;
    }

    public List<Car> GetLast5CarsWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
        return values;
    }
}
