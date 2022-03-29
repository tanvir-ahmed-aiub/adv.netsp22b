using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepo
    {
        public static Student Get(int id) {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            return db.Students.FirstOrDefault(x => x.Id == id);
        }
        public static List<Student> Get() {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            return db.Students.ToList();
        }
        public static bool Add(Student s) {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            db.Students.Add(s);
            if (db.SaveChanges()!= 0) { return true; }
            return false;

        }
    }
}
