using ModelViewBibloteka.Model_View;
using ModelViewBibloteka.Models;
using ModelViewBibloteka.Presenter;
using ModelViewBibloteka.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public partial class Form1 : Form
    {
        private UserPresenter presenter_;
        public Form1()
        {
            InitializeComponent();
            presenter_ = new UserPresenter(new MemoryUsersModel(), IUserView);
        }

        

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = .GetSelectedUsers();
            presenter_.RemoveUsers(selectedUsers);
        }
    }
}
