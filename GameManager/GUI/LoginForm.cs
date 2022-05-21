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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginLogic loginLogic = new LoginLogic();
            loginLogic.init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LoginLogic loginLogic = new LoginLogic();
            loginLogic.verifyLoginAndPassword(UsernameBox, PasswordBox, this);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().ShowDialog();
            this.Close();
        }
    }
}
