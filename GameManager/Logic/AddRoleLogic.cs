using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.GUI;
using GameManager.Logic;

namespace GameManager.Logic
{
    public class AddRoleLogic
    {
        List<String> permissions = new List<String> { "Add Forests", "Add Temples", "Add Castles",
                                                  "Add Caves", "Add Deserts", "Delete Categories",
                                                  "Edit Categories", "Add Elements", "Edit Elements",
                                                  "Delete Elements", "Add Roles", "Edit Roles",
                                                  "Delete Roles", "Add User", "Delete Users", "Edit Users"};

        public void fillCheckedList(CheckedListBox list)
        {
            foreach (String permission in permissions)
            {
                list.Items.Add(permission);
            }
        }

        public void addRole(List<string> chosen, string name, bool isEdit, string initName)
        {
            List<string> init = new List<string>();
            for(int i=0; i<16; i++)
            {
                init.Add("false");
            }
            List<string> columns = new List<string>();
            foreach (string element in chosen)
            {
                columns.Add(element.Replace(" ", ""));
            }
            string initQuery = "";
            if (!isEdit)
            {
                initQuery = "INSERT INTO Roles";
                string queryValues = " VALUES (" + "'" + name + "',";
                foreach (string value in init)
                {
                    queryValues += "'" + value + "'" + " ,";
                }
                queryValues += ")";
                queryValues = queryValues.Replace(",)", ")");
                initQuery += queryValues;
            } else
            {
                initQuery = "UPDATE Roles SET ";
                for(int i=0; i<columns.Count(); i++)
                {
                    initQuery += columns[i] + "='false' ,";
                }
                initQuery += "WHERE Name='" + initName + "'";
                initQuery = initQuery.Replace(",WHERE", "WHERE");
            }

            Console.WriteLine(initQuery);

            List<string> values = new List<string>();
            foreach(string column in columns)
            {
                values.Add("true");
            }

            string updateQuery = "UPDATE Roles SET Name='" + name + "', ";
            for(int i=0; i<values.Count(); i++)
            {
                updateQuery += columns[i] + "='" + values[i] + "' ,";
            }
            updateQuery += "WHERE Name='" + initName + "'";
            updateQuery = updateQuery.Replace(",WHERE", "WHERE");


            using (var db = new GameManagerContext())
            {
                if (!isEdit)
                {
                    var check = db.Roles.Where(x => x.Name == name).FirstOrDefault();
                    if (check == null)
                    {
                        db.Database.ExecuteSqlCommand(initQuery);
                        db.Database.ExecuteSqlCommand(updateQuery);
                        MessageBox.Show("New role was created",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    } 
                    else
                    {
                        MessageBox.Show("There is already role with the same name ",
                                        "Change role name",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                } else
                {
                    if (initName != name)
                    {
                        var check = db.Roles.Where(x => x.Name == name).FirstOrDefault();
                        if (check == null)
                        {
                            db.Database.ExecuteSqlCommand(initQuery);
                            db.Database.ExecuteSqlCommand(updateQuery);
                            MessageBox.Show("Role was edited successfully",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There is already role with the same name ",
                                            "Change role name",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    } else
                    {
                        MessageBox.Show("Role was edited successfully",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }

            }

        }

    }
}
