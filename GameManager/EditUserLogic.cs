using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    internal class EditUserLogic
    {
        public void fillBoxes(string username, TextBox UsernameBox, TextBox PasswordBox, TextBox EmailBox, ComboBox RoleBox)
        {
            using (var db = new GameManagerContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Username == username);
                var roles = from r in db.Roles orderby r.Name select r;
                foreach (var role in roles)
                {
                    RoleBox.Items.Add(role.Name);
                }
                UsernameBox.Text = user.Username;
                PasswordBox.Text = user.Password;
                EmailBox.Text = user.Email;
                RoleBox.Text = user.Role.Name;
            };
        }

        public void editUserData()
        {

        }
    }
}

