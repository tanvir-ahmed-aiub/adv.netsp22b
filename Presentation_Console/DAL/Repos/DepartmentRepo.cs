using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepo
    {
        public Department Get(int id) {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }
        public List<Department> Get() {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            return db.Departments.ToList();
        }
    }
}
