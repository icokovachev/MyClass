using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class Teacher
    {
        [Key]
        public long IdentityID { get; set; }

        public string Subject { get; set; }

        public long SchoolID { get; set; }
    }
}
