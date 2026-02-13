using ModelViewBibloteka.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBibloteka.Models
{
    interface IUsersModel
    {
        List<User> Load();
        bool Register(User user);
    }
}
