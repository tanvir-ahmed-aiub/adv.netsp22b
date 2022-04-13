using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static dynamic Authenticate(string uname, string pass) {
            var token=  DataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
            return token;
        }
        public static bool ValidateToken(string key)
        {
            var token = DataAccessFactory.TokenDataAccess().Get(key);
            if (token !=null && token.ExpiredAt == null) return true;
            return false;

        }
    }
}
