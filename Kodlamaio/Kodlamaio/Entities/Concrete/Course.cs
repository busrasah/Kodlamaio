using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Entities
{
    public class Course:BaseEntity
    {
  
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
