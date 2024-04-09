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
    public class DeleteTagCloudCommandHandler : IRequestHandler<DeleteTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public DeleteTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTagCloudCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
