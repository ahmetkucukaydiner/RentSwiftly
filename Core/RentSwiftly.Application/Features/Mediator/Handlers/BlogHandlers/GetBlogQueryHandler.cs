using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.BlogQueries;
using RentSwiftly.Application.Features.Mediator.Results.BlogResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetBlogQueryResult
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,                
                CategoryID = x.CategoryID,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate                
            }).ToList();
        }
    }
}
