using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class SchoolsModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public ICollection<EventsModel> Events { get; set; }
    }
}