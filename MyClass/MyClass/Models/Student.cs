using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class Student : IdentityUser
    {
        [Key]
        public long IdentityID { get; set; }

        public long ClassID { get; set; }

        public long SchoolID { get; set; }
    }
}
