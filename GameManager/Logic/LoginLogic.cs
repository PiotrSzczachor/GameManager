using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.DBModels;
using GameManager.Logic;

namespace GameManager
{
    public class LoginLogic
    {
        public void verifyLoginAndPassword(TextBox UsernameBox, TextBox PasswordBox, LoginForm form)
        {
            EncryptPassword encryptPassword = new EncryptPassword();
            string username = UsernameBox.Text;
            string pass = PasswordBox.Text;
            string password = encryptPassword.encode(pass);
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
                    Roles adminRole = new Roles { Name = "Admin",
                                                AddForests = false,
                                                AddTemples = false,
                                                AddCastles = false,
                                                AddCaves = false,
                                                AddDeserts = false,
                                                DeleteCategories = false,
                                                EditCategories = false,
                                                AddElements = false,
                                                DeleteElements = false,
                                                EditElements = false,
                                                AddRoles = true,
                                                EditRoles = true,
                                                DeleteRoles = true,
                                                AddUsers = true,
                                                DeleteUsers = true
                                            };
                    Roles userRole = new Roles { Name = "User",
                                                AddForests = true,
                                                AddTemples = true,
                                                AddCastles = true,
                                                AddCaves = true,
                                                AddDeserts = true,
                                                DeleteCategories = true,
                                                EditCategories = true,
                                                AddElements = true,
                                                DeleteElements = true,
                                                EditElements = true,
                                                AddRoles = false,
                                                EditRoles = false,
                                                DeleteRoles = false,
                                                AddUsers = false,
                                                DeleteUsers = false
                                            };
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
                if (db.ElementTypes.Count() == 0)
                {
                    List<ElementType> list = new List<ElementType>();
                    list.Add(new ElementType { Name = "Alchemist", Atributes = "Healing,Inteligence,Support,Magica,Stamina" });
                    list.Add(new ElementType { Name = "Archer", Atributes = "Accuracy,Inteligence,Speed,Armor,Focusing" });
                    list.Add(new ElementType { Name = "Bat", Atributes = "Speed,Agility,Hearing,Magica,Stamina" });
                    list.Add(new ElementType { Name = "Cobra", Atributes = "Virulence,Speed,Shell,Seeing,Agility" });
                    list.Add(new ElementType { Name = "Dragon", Atributes = "Strength,Speed,Accuracy,Power,Magica" });
                    list.Add(new ElementType { Name = "Ent", Atributes = "Strength,Brave,Musculature,Magica,Armor" });
                    list.Add(new ElementType { Name = "Golem", Atributes = "Strength,Brave,Musculature,Magica,Armor" });
                    list.Add(new ElementType { Name = "Knight", Atributes = "Strength,Stamina,Musculature,Brave,Armor" });
                    list.Add(new ElementType { Name = "Mummy", Atributes = "Strength,Magica,Speed,Armor,Stamina" });
                    list.Add(new ElementType { Name = "Scorpion", Atributes = "Virulence,Speed,Shell,Seeing,Agility" });
                    list.Add(new ElementType { Name = "Spider", Atributes = "Virulence,Speed,Seeing,Magica,Armor" });
                    list.Add(new ElementType { Name = "Warewolf", Atributes = "Strength,Brave,Musculature,Magica,Armor" });
                    list.Add(new ElementType { Name = "Warrior", Atributes = "Strength,Stamina,Musculature,Brave,Armor" });
                    list.Add(new ElementType { Name = "Witch", Atributes = "Power,Inteligence,Energy,Strength,Stamina" });
                    list.Add(new ElementType { Name = "Wizzard", Atributes = "Power,Inteligence,Energy,Strength,Stamina" });
                    foreach (ElementType type in list)
                    {
                        db.ElementTypes.Add(type);
                    }
                    db.SaveChanges();
                }
            }
        }

    }
}
