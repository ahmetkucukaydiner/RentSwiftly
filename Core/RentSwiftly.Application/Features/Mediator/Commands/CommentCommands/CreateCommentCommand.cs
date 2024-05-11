using MediatR;

namespace RentSwiftly.Application.Features.Mediator.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
    }
}