using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.TagCloudCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public CreateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TagCloud
            {
                Title = request.Title,
                BlogID = request.BlogID
            });
        }
    }
}
