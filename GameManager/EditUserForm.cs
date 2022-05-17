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
        public EditUserForm(Users user, string username)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            selectedUsername = username;
            EditUserLogic editUserLogic = new EditUserLogic();
            editUserLogic.fillBoxes(selectedUsername, UsernameBox, PasswordBox, EmailBox, RolesComboBox);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
