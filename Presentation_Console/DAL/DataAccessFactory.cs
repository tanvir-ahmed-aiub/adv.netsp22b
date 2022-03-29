using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Database;

namespace DAL
{
    public class DataAccessFactory
    {
        static UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
        public static IRepository<Student,int> StudentDataAccess()
        {
            return new StudentRepoV2();
        }
        public static IRepository<Department, int> DepartmentDataAccess() 
        {
            return new DepartmentRepo(db);
        }
        public static IAuth AuthDataAccess() {
            return new StudentRepoV2();
        }
    }
}
