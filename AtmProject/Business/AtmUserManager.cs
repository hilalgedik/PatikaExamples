using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AtmProject.Entity;

namespace AtmProject.Business
{
    public class AtmUserManager
    {
        static List<User> users = new List<User>();

        public void AddUser()
        {
            var user = new User
            {
                Id=1,
                Name = "Hilal",
                Email = "hilal@mail",
                Password = "123"
            };
            users.Add(user);

            var user1 = new User
            {
                Id = 2,
                Name = "Ayşe",
                Email = "ayse@mail",
                Password = "123"
            };
            users.Add(user1);
        }

        public bool UserRegisterControl(string name, string password)
        {
            foreach (var row in users)
            {
                if ((row.Name == name) && (row.Password == password))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
