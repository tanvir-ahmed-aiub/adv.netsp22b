using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepoV2 : IRepository<Student, int>,IAuth
    {
        public bool Add(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string username, string password)
        {
            //do the authentication
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            return new Student();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }
    }
}
