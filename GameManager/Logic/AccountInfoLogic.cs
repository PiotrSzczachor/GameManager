using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    internal class AccountInfoLogic
    {
        public void fillTextBoxes(TextBox UsernameBox, TextBox EmailBox, TextBox RoleBox, Users user)
        {
            UsernameBox.Text = user.Username;
            EmailBox.Text = user.Email;
            RoleBox.Text = user.Role.Name;
        }
    }
}
