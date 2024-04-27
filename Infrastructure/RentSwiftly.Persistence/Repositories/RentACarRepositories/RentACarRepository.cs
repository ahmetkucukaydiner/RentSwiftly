using RentSwiftly.Application.Interfaces.RentACarInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly RentSwiftlyContext _context;

        public RentACarRepository(RentSwiftlyContext context)
        {
            _context = context;
        }

        public List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = _context.RentACars.Where(filter);
            return values.ToList();
        }
    }
}
