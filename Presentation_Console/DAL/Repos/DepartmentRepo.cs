using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepo : IRepository<Department, int>
    {
        UMS_Sp22_BEntities db;
        public DepartmentRepo(UMS_Sp22_BEntities db)
        {
            this.db = db;
        }
        public bool Add(Department obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Department obj)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }
    }
}
