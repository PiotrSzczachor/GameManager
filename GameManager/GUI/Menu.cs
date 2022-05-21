using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    public partial class Menu : Form
    {
        Users currentlyLoggedUser;
        public Menu(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            LoggedUserLabel.Text = "You are currently logged as " + user.Username;
        }

        private void AccountInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInfoForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            currentlyLoggedUser = null;
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoriesManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
