using ModelViewBibloteka.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBibloteka.View
{
    public interface IUserView
    {
        void ShowUser(List<User> users);
        List<User> GetSelectedUsers();
    }
}
