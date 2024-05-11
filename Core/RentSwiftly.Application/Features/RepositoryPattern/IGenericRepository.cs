namespace RentSwiftly.Application.Features.RepositoryPattern
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetCommentsByBlogId(int id);
        int GetCountCommentByBlog(int id);
    }
}
