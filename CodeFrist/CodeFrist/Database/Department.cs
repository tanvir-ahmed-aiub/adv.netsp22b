using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFrist.Database
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public Department() {
            Students = new List<Student>();
        }
    }
}
