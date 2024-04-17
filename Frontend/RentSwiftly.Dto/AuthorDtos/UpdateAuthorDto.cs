using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Dto.AuthorDtos
{
    public class UpdateAuthorDto
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
