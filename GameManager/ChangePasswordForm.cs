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
    public partial class ChangePasswordForm : Form
    {
        Users currentlyLoggedUser;
        public ChangePasswordForm(Users user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangePasswordLogic changePasswordLogic = new ChangePasswordLogic();
            changePasswordLogic.changePassword(currentlyLoggedUser, OldPasswordBox, NewPasswordBox, RedirectTimer, Time, this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInfoForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
