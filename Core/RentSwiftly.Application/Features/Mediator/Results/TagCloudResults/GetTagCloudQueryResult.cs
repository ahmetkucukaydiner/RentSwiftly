using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Results.TagCloudResults
{
    public class GetTagCloudQueryResult
    {
        public int TagCloudID { get; set; }
        public int BlogID { get; set; }
        public string Title { get; set; }
    }
}
