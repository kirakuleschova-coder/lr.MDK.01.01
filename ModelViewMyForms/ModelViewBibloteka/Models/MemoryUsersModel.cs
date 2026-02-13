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
