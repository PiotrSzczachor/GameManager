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
    public partial class AccountInfoForm : Form
    {
        Users currentlyLoggedUser;
        public AccountInfoForm(Users user)
        {
            InitializeComponent();
            AccountInfoLogic accountInfoLogic = new AccountInfoLogic();
            currentlyLoggedUser = user;
            accountInfoLogic.fillTextBoxes(UsernameBox, EmailBox, RoleBox ,user);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
