using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.CommentCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public CreateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                Description = request.Description,
                BlogID = request.BlogId,
                CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Name = request.Name,
                UserImageUrl = "asd",
                Email = request.Email
            });
        }
    }
}