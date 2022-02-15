using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assoc.Models.Entity
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OfferedBy { get; set; }
        public DepartmentModel Department { get; set; }
    }
}