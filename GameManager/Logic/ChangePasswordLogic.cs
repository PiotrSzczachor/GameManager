using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    internal class ChangePasswordLogic
    {
        public void changePassword(Users user, TextBox OldPasswordBox, TextBox NewPasswordBox, Timer RedirectTimer, Label time, ChangePasswordForm form)
        {
            using (var db = new GameManagerContext())
            {
                if (OldPasswordBox.Text != "" && NewPasswordBox.Text != "")
                {
                    if (OldPasswordBox.Text == user.Password)
                    {
                        var dbUser = db.Users.SingleOrDefault(u => u.Username == user.Username);
                        dbUser.Password = NewPasswordBox.Text;
                        db.SaveChanges();
                        RedirectTimer.Enabled = true;
                        RedirectTimer.Start();
                        time.Text = "";
                        time.Visible = true;
                        int seconds = 6;
                        RedirectTimer.Tick += (s, e) =>
                        {
                            seconds--;
                            time.Text = "Password changed succesfully! You will be redirect to menu form in " + seconds.ToString() + " seconds";
                            if (seconds == 0)
                            {
                                form.Hide();
                                new Menu(user).ShowDialog();
                                form.Close();
                            }
                        };
                    } else
                    {
                        MessageBox.Show("Your old password is incorrect. Try again.",
                                                "Old Password Incorrect",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                        "Fill all TextBox",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            }            
        }
    }
}
