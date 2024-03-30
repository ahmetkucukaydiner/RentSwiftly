using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.BlogCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogID);
            value.AuthorID = request.AuthorID;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Title = request.Title;
            value.CategoryID = request.CategoryID;
            await _repository.UpdateAsync(value);
        }
    }
}
