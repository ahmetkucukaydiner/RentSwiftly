using RentSwiftly.Domain.Entities;
using System.Linq.Expressions;

namespace RentSwiftly.Application.Interfaces.AppUserInterfaces
{
	public interface IAppUserRepository
	{
		Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
	}
}
