using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using GameManager.Logic;

namespace GameManager
{
    public class SignUpLogic
    {
        public void createNewUser(TextBox UsernameBox, TextBox PasswordBox, TextBox EmailBox, Timer RedirectTimer, SignUpForm form,
            Label time, Button CancelButton, Button ResetButton, Button SignUpButton, bool redirect)
        {
            EncryptPassword encryptPassword = new EncryptPassword();
            string username = UsernameBox.Text;
            string pass = PasswordBox.Text;
            string password = encryptPassword.encode(pass);
            string email = EmailBox.Text;
            if(username != "" && password != "" && email != "")
            {
                using (var db = new GameManagerContext())
                {
                    bool isAvaliable = checkIfUserExistInDb(username, db);
                    bool isEmailValid = checkIfEmailIsValid(email);
                    if (isAvaliable)
                    {
                        if (isEmailValid)
                        {
                            addUserToDb(username, password, email, db, CancelButton, ResetButton, SignUpButton, RedirectTimer, time, form, redirect);
                        } else
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
            }
            else
            {
                MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBox",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

    public bool checkIfUserExistInDb(string username, GameManagerContext db)
    {
        bool isAvaliable = true;
        var usernames = from x in db.Users orderby x.Username select x.Username;
        foreach (var user in usernames)
        {
             if (username == user.ToString())
             {
                 isAvaliable = false;
             }
        }
        return isAvaliable;
    }

        
    public bool checkIfEmailIsValid(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

    public void addUserToDb(string username, string password, string email, GameManagerContext db, Button CancelButton, 
                            Button ResetButton, Button SignUpButton, Timer RedirectTimer, Label time, SignUpForm form, bool redirect)
        {
            var roleQuery = from x in db.Roles where x.Name == "User" select x;
            Roles role = roleQuery.FirstOrDefault();
            Users user = new Users { Username = username, Password = password, Email = email, Role = role };
            db.Users.Add(user);
            db.SaveChanges();
            CancelButton.Enabled = false;
            ResetButton.Enabled = false;
            SignUpButton.Enabled = false;
            RedirectTimer.Enabled = true;
            RedirectTimer.Start();
            time.Text = "";
            time.Visible = true;
            int seconds = 6;
            RedirectTimer.Tick += (s, e) =>
            {
                seconds--;
                if (redirect)
                {
                    time.Text = "Signed Up Succesfully! You will be redirect to login form in " + seconds.ToString() + " seconds";
                    if (seconds == 0)
                    {
                        form.Hide();
                        new LoginForm().ShowDialog();
                        form.Close();
                    }
                } else
                {
                    time.Text = "New user added succesfully! You can add next user in " + seconds.ToString() + " seconds";
                    if (seconds == 0)
                    {
                        time.Visible = false;
                        CancelButton.Enabled = true;
                        ResetButton.Enabled = true;
                        SignUpButton.Enabled = true;
                    }
                }
                
            };
        }

    public void resetSignUpForm(TextBox UsernameBox, TextBox PasswordBox, TextBox EmailBox)
        {
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            EmailBox.Text = "";
        }
    }
}
