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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            SignUpButton.Enabled = true;
            CancelButton.Enabled = true;
            ResetButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            signUpLogic.resetSignUpForm(UsernameBox, PasswordBox, EmailBox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            signUpLogic.createNewUser(UsernameBox, PasswordBox, EmailBox, RedirectTimer, this, Time, CancelButton, ResetButton, SignUpButton, true);
        }
    }
}
