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

        public void editUserData(string initUsername, string username, string password, string email, string roleName, Timer checkingChangesTimer,
                                Timer RedirectTimer, Label time, EditUserForm form, Users user, Button SaveButton, Button backButton)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            using (var db = new GameManagerContext())
            {
                if (username != "" && password != "" && email != "" && roleName != "")
                {
                    bool isAvaliable = signUpLogic.checkIfUserExistInDb(username, db);
                    bool isEmailValid = signUpLogic.checkIfEmailIsValid(email);
                    bool youCanMakeChanges = true;
                    if (!isAvaliable && username != initUsername)
                    {
                        youCanMakeChanges = false;
                    }
                    if (youCanMakeChanges)
                    {
                        if (isEmailValid)
                        {
                            var dbUser = db.Users.SingleOrDefault(u => u.Username == initUsername);
                            var dbUserRole = db.Roles.SingleOrDefault(u => u.Name == roleName);
                            dbUser.Password = password;
                            dbUser.Email = email;
                            dbUser.Role = dbUserRole;
                            dbUser.Username = username;
                            db.SaveChanges();
                            checkingChangesTimer.Stop();
                            SaveButton.Enabled = false;
                            backButton.Enabled = false;
                            RedirectTimer.Enabled = true;
                            RedirectTimer.Start();
                            time.Text = "";
                            time.Visible = true;
                            int seconds = 6;
                            RedirectTimer.Tick += (s, e) =>
                            {
                                seconds--;
                                time.Text = "User edited succesfully! You will be redirect to Users List in " + seconds.ToString() + " seconds";
                                if (seconds == 0)
                                {
                                    form.Hide();
                                    new UsersPanelForm(user).ShowDialog();
                                    form.Close();
                                }
                            };
                        } 
                        else
                        {
                            MessageBox.Show("Email format is incorrect",
                                    "Incorrect email format",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        }

                    } 
                    else
                    {
                        MessageBox.Show("Username is not avaliable",
                                    "Change Username",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                } 
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBox",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
        public void checkIfUserDataChanged(string username, string password, string email, string role, TextBox UsernameBox,
                                           TextBox PasswordBox, TextBox EmailBox, ComboBox RoleBox, Button saveButton)
        {
            if(username != UsernameBox.Text || password != PasswordBox.Text || email != EmailBox.Text || role != RoleBox.Text)
            {
                saveButton.Enabled = true;
            } else
            {
                saveButton.Enabled = false;
            }
        }
        
    }
}

