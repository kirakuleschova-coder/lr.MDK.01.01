using ModelViewBibloteka.Model_View;
using ModelViewBibloteka.Models;
using ModelViewBibloteka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBibloteka.Presenter
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUserView views_;
        public UserPresenter (IUsersModel model, IUserView views)
        {
            model_ = model;
            views_ = views;

            views_.ShowUser(model_.Load());
        }

        public void RemoveUsers(List<User> users)
        {
            model_.RemoveUsers(users);
            views_.ShowUser(model_.Load());
        }
    }
}
