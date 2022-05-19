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
    public partial class EditUserForm : Form
    {
        Users currentlyLoggedUser;
        string selectedUsername;
        string initUsername;
        string initPassword;
        string initEmail;
        string initRole;
        public EditUserForm(Users user, string username)
        {
            InitializeComponent();
            SaveButton.Enabled = false;
            currentlyLoggedUser = user;
            selectedUsername = username;
            EditUserLogic editUserLogic = new EditUserLogic();
            editUserLogic.fillBoxes(selectedUsername, UsernameBox, PasswordBox, EmailBox, RolesComboBox);
            initUsername = UsernameBox.Text;
            initPassword = PasswordBox.Text;
            initEmail = EmailBox.Text;
            initRole = RolesComboBox.Text;
            CheckingChangesTimer.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void CheckingChangesTimer_Tick(object sender, EventArgs e)
        {
            EditUserLogic editUserLogic = new EditUserLogic();
            editUserLogic.checkIfUserDataChanged(initUsername, initPassword, initEmail, initRole, UsernameBox, PasswordBox, EmailBox, RolesComboBox, SaveButton);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EditUserLogic editUserLogic = new EditUserLogic();
            editUserLogic.editUserData(initUsername, UsernameBox.Text, PasswordBox.Text, EmailBox.Text, RolesComboBox.Text);
        }
        //Write something which will inform user about succesfully changed data
    }
}
