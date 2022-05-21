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
    public partial class UsersPanelForm : Form
    {
        Users currentlyLoggedUser;
        string selectedUsername;
        public UsersPanelForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            UsersPanelLogic usersPanelLogic = new UsersPanelLogic();
            usersPanelLogic.fillUsersListBox(UsersListBox);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UsersPanelLogic usersPanelLogic = new UsersPanelLogic();
            usersPanelLogic.deleteUserFromDb(UsersListBox);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditUserForm(currentlyLoggedUser, selectedUsername).ShowDialog();
            this.Close();
        }

        private void UsersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = true;
            EditButton.Enabled = true;
            if(UsersListBox.SelectedItem != null)
            {
                selectedUsername = UsersListBox.SelectedItem.ToString().Split(':')[1].Replace(" ", "");
            }
            
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNewUserForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
