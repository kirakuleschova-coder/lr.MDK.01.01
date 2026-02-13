using ModelViewBibloteka.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public class UserTableView : DataGridView, IUserView
    {
     public void ShowUsers(List<User> allUsers)
        {
            DataSource = allUsers;
        }
        void IUserView.ShowUser(List<User>)
    }
}
