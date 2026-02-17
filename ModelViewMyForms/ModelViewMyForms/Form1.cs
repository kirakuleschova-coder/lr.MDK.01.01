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
            UserTableView presenter = new UserTableView();
            Controls.Add(presenter);
            presenter.Dock = DockStyle.Top;
            presenter_ = new UserPresenter(
                new MemoryUsersModel(), presenter);
        }

        

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = UserView.GetSelectedUsers();
            presenter_.RemoveUsers(selectedUsers);
        }
    }
}
