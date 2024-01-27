﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Commands.SocialMediaCommands;

public class CreateSocialMediaCommand : IRequest
{
    public string Name { get; set; }
    public string Url { get; set; }
    public int Icon { get; set; }
}
