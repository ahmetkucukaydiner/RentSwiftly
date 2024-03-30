using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Application.Interfaces.BlogInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly RentSwiftlyContext _context;

        public BlogRepository(RentSwiftlyContext context)
        {
            _context = context;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).Include(x=>x.Category).OrderByDescending(x => x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
