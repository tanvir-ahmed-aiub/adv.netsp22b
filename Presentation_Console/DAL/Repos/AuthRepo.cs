using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        UMS_Sp22_BEntities db;
        public AuthRepo(UMS_Sp22_BEntities db)
        {
            this.db = db;
        }
        public bool Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public Token Authenticate(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (user != null) {
                var token = new Token();
                token.TKey = Guid.NewGuid().ToString();
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                token.UserId = user.Id;
                if (Add(token)) {
                    return token;
                }


            }
            return null;

        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(x => x.TKey.Equals(id));
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }
    }
}
