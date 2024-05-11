using RentSwiftly.Application.Features.RepositoryPattern;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : IGenericRepository<Comment>
    {
        private readonly RentSwiftlyContext _context;

        public CommentRepository(RentSwiftlyContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Comment entity)
        {
            var value = _context.Comments.Find(entity.CommentID);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                CommentID = x.CommentID,
                BlogID = x.BlogID,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name,
                UserImageUrl = x.UserImageUrl
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlogID == id).ToList();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogID == id).Count();
        }
    }
}
