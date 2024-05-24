using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Interfaces.BlogInterfaces
{
	public interface IBlogRepository
	{
		List<Blog> GetLast3BlogsWithAuthors();
		List<Blog> GetAllBlogsWithAuthors();
		List<Blog> GetBlogByAuthorId(int id);
	}
}
