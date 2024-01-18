﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Commands.CarCommands;

public class CreateCarCommand
{
    public int BrandID { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Kilometer { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Baggage { get; set; }
    public string Fuel { get; set; }
    public string BigImageUrl { get; set; }
}