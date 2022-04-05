using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFrist.Database
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeparmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual List<CourseStudent> CourseStudents { get; set; }

        public Student() {
            CourseStudents = new List<CourseStudent>();
        }
    }
}
