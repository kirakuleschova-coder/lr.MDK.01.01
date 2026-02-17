using ModelViewBibloteka.Model_View;
using ModelViewBibloteka.View;
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
        public List<User> GetSelectedUsers()
        {
            List<User> result = new List<User>();
            foreach (DataGridViewRow row in SelectedRows)
            {
                result.Add(row.DataBoundItem as User);
            }

            return result;
        }

        public void ShowUsers(List<User> users)
        {
            DataSource = null;
            DataSource = users;
        }

        List<User> IUserView.GetSelectedUsers()
        {
            throw new NotImplementedException();
        }

        void IUserView.ShowUser(List<User> users)
        {
            throw new NotImplementedException();
        }
    }
}
