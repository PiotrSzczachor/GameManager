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
    public partial class AddNewUserForm : Form
    {
        Users currentlyLoggedUser;
        public AddNewUserForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            signUpLogic.createNewUser(UsernameBox, PasswordBox, EmailBox, RedirectTimer, new SignUpForm() , Time, CancelButton, ResetButton, AddUserButton, false);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            signUpLogic.resetSignUpForm(UsernameBox, PasswordBox, EmailBox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
