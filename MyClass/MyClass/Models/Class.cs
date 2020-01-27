using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class Class
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public long SchoolID { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Homework> Homeworks { get; set; }

        public ICollection<Exam> Exams { get; set; }

        public ICollection<WeeklySchedule> WeeklySchedule { get; set; }
    }
}
