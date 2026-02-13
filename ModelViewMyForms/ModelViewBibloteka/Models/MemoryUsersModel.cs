using ModelViewBibloteka.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBibloteka.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        public MemoryUsersModel() 
        {
            allUser_.Add(new User("9977", "2543", "Adam Chika"));
            allUser_.Add(new User("8599", "9932", "Maha Fank"));
            allUser_.Add(new User("0623", "0012", "Pyla Prays"));
            allUser_.Add(new User("7489", "1829", "Grip Fors"));
        }
        private List<User> allUser_ = new List<User>();
        public List<User> Load()
        {
            return allUser_;
        }
        public bool Register(User user)
        {
            int count = allUser_.Count;
            allUser_.Add(user);
            if (allUser_.Count > count)
            {
                return true;
            }
            return false;
        }
    }
}
