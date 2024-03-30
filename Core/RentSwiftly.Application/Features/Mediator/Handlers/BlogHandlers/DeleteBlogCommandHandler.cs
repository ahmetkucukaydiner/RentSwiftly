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
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public DeleteBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);   
        }
    }
}
