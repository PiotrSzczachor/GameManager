using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    public class LoginLogic
    {
        public void verifyLoginAndPassword(TextBox UsernameBox, TextBox PasswordBox, LoginForm form)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            using (var db = new GameManagerContext())
            {
                bool isUserInDb = false;
                var usernameQuery = from x in db.Users orderby x.Username select x.Username;
                foreach(var dbUsername in usernameQuery)
                {
                    if(dbUsername == username)
                    {
                        isUserInDb = true; break;
                    }
                }
                if (isUserInDb)
                {
                    var dbPass = from x in db.Users.Where(x => x.Username == username) select x.Password;
                    string dbPassword = dbPass.SingleOrDefault();
                    var getUserQuery = from x in db.Users.Where(x => x.Username == username) select x;
                    Users user = getUserQuery.SingleOrDefault();
                    if (password == dbPassword)
                    {
                        form.Hide();
                        new Menu(user).ShowDialog();
                        form.Close();
                    } 
                    else
                    {
                        MessageBox.Show("Incorrect password. Try again.",
                                        "Incorrect Password",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                } 
                else
                {
                    MessageBox.Show("User " + username + " don't exist.",
                                        "User don't exist",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                
            }
                
        }

        public void init()
        {
            using (var db = new GameManagerContext())
            {
                if (db.Roles.Count() == 0)
                {
                    Roles adminRole = new Roles { Name = "Admin" };
                    Roles userRole = new Roles { Name = "User" };
                    db.Roles.Add(adminRole);
                    db.Roles.Add(userRole);
                    db.SaveChanges();
                }
                if (db.Categories.Count() == 0)
                {
                    Categories forest = new Categories { Name = "Forest" };
                    Categories temple = new Categories { Name = "Temple" };
                    Categories castle = new Categories { Name = "Castle" };
                    Categories cave = new Categories { Name = "Cave" };
                    Categories desert = new Categories { Name = "Desert" };
                    db.Categories.Add(forest);
                    db.Categories.Add(temple);
                    db.Categories.Add(castle);
                    db.Categories.Add(cave);
                    db.Categories.Add(desert);
                    db.SaveChanges();
                }
            }
        }

    }
}
