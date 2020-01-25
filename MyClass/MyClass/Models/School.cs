using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class School
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}