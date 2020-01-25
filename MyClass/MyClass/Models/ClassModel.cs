using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class ClassModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public long SchoolID { get; set; }

        public ICollection<HomeworkModel> Homeworks { get; set; }

        public ICollection<ExamModel> Exams { get; set; }

        public ICollection<WeeklyScheduleModel> WeeklySchedule { get; set; }
    }
}
