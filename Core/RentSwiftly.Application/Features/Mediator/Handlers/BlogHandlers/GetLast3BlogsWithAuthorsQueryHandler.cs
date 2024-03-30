﻿using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.BlogQueries;
using RentSwiftly.Application.Features.Mediator.Results.BlogResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                AuthorID = x.AuthorID,
                CoverImageUrl = x.CoverImageUrl,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorName = x.Author.Name,
                CategoryName = x.Category.Name
            }).ToList();
        }
    }
}