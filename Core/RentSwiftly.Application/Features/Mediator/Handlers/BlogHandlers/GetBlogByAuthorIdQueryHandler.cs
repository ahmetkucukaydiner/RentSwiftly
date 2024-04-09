using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.BlogQueries;
using RentSwiftly.Application.Features.Mediator.Results.BlogResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Application.Interfaces.BlogInterfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                AuthorDescription = x.Author.Description,
                AuthorName = x.Author.Name,
                AuthorImageUrl = x.Author.ImageUrl,
                BlogID = x.BlogID,
                AuthorID = x.AuthorID
            }).ToList();
        }
    }
}
