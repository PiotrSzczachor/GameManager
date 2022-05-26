using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.GUI;

namespace GameManager
{
    public partial class Menu : Form
    {
        Users currentlyLoggedUser;
        public Menu(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            PermissionTimer.Enabled = true;
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

        private void ElementsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ElementsManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void PermissionTimer_Tick(object sender, EventArgs e)
        {
            var perm = currentlyLoggedUser.Role;
            if(!perm.DeleteUsers && !perm.AddUsers && !perm.EdidUsers)
            {
                UsersButton.Enabled = false;
            }
            if(!perm.AddElements && !perm.EditElements && !perm.DeleteElements)
            {
                ElementsButton.Enabled = false;
            }
            if(!perm.AddForests && !perm.AddTemples && !perm.AddCastles && !perm.AddCaves && !perm.AddDeserts && !perm.EditCategories && !perm.DeleteCategories)
            {
                CategoriesButton.Enabled = false;
            }
            if(!perm.AddRoles && !perm.EditRoles && !perm.DeleteRoles)
            {
                RolesButton.Enabled = false;
            }
        }

        private void RolesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RolesManagerForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
