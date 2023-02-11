using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginForm.DataAccess;
using UserLoginForm.DataAccess.EntityFramework;
using UserLoginForm.Entities;

namespace UserLoginForm.Business
{
    public class UserManager
    {
        private EfUserDal _efUserDal;

        public UserManager(EfUserDal efUserDal)
        {
            _efUserDal = efUserDal;
        }

        public void Add(User user)
        {
            _efUserDal.Add(user);
        }

        public void Update(User user)
        {
            _efUserDal.Update(user);
        }

        public void Delete(User user)
        {
            _efUserDal.Delete(user);
        }

        public User Get(string name)
        {
            return _efUserDal.Get(u => u.UserName == name);
        }

        public User GetPassword(string name,string password)
        {
            return _efUserDal.Get(u => u.UserName == name && u.Password == password);
        }
    }
}
