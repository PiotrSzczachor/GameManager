using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    internal class UsersPanelLogic
    {
        public void fillUsersListBox(ListBox UsersListBox)
        {
            using (var db = new GameManagerContext())
            {
                var getUsers = from u in db.Users select u;
                foreach (var user in getUsers)
                {
                    string usernameAndRole = "Username: " + user.Username; //+ "  Role: " + user.Role.Name;
                    UsersListBox.Items.Add(usernameAndRole);
                }
            }
        }

        public void deleteUserFromDb(ListBox UsersListBox)
        {
            string username = UsersListBox.SelectedItem.ToString().Split(':')[1].Replace(" ", "");
            using (var db = new GameManagerContext())
            {
                var dbUser = db.Users.SingleOrDefault(u => u.Username == username);
                db.Users.Remove(dbUser);
                db.SaveChanges();
                UsersListBox.Items.Clear();
                fillUsersListBox(UsersListBox);
            }
        }
    }
}
