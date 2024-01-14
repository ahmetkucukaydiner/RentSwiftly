using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly RentSwiftlyContext _context;

    public Repository(RentSwiftlyContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
