﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Results.LocationResults;

public class GetLocationByIdQueryResult
{
    public int LocationID { get; set; }
    public string Name { get; set; }
}
