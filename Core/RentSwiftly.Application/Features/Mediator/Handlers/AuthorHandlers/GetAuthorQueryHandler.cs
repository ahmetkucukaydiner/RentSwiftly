using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.AuthorQueries;
using RentSwiftly.Application.Features.Mediator.Results.AuthorResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        async Task<List<GetAuthorQueryResult>> IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>.Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl                
            }).ToList();
        }
    }
}
