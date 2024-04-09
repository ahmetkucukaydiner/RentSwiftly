using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class CreateTagCloudCommand : IRequest
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
    }
}
