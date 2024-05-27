using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.AppUserInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using System.Linq.Expressions;

namespace RentSwiftly.Persistence.Repositories.AppUserRepositories
{
	public class AppUserRepository : IAppUserRepository
	{
		private readonly RentSwiftlyContext _context;

		public AppUserRepository(RentSwiftlyContext context)
		{
			_context = context;
		}

		public async Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
		{
			var values = await _context.AppUsers.Where(filter).FirstOrDefaultAsync();
			return values;
		}
	}
}
