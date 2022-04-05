using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFrist.Database
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<CourseStudent> CourseStudents { get; set; }

        public Course() {
            CourseStudents = new List<CourseStudent>();
        }
    }
}
