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
    public class AddElementLogic
    {
        public void fillCategoriesComboBox(string selectedType, ComboBox CategoriesComboBox)
        {
            string table = selectedType + "s";
            if (selectedType == "Warewolf")
            {
                table = "Warewolves";
            }
            if (selectedType == "Witch")
            {
                table = "Witches";
            }
            if (selectedType == "Mummies")
            {
                table = "Mummy";
            }
            using (var db = new GameManagerContext())
            {
                List<string> forestElements = new List<string> { "Ent", "Warewolf", "Spider"};
                List<string> templeElements = new List<string> { "Witch", "Wizzard", "Alchemist" };
                List<string> castleElements = new List<string> { "Knight", "Warrior", "Archer" };
                List<string> caveElements = new List<string> { "Dragon", "Bat", "Golem" };
                List<string> desertElements = new List<string> { "Mummy", "Cobra", "Scorpion" };

                if (forestElements.Contains(selectedType))
                {
                    var forests = db.Forests;
                    foreach (var forest in forests)
                    {
                        string info = "Name: " + forest.Name + "  |  Area: " + forest.Area + "  |  Type: " + forest.Category.Name + "  |  Forest ID: " + forest.Id;
                        CategoriesComboBox.Items.Add(info);
                    }
                }
                if (templeElements.Contains(selectedType))
                {
                    var temples = db.Temples;
                    foreach (var temple in temples)
                    {
                        string info = "Name: " + temple.name + "  |  Chambers number: " + temple.ChambersNumber + "  |  Build year: " + temple.buildYear + "  |  Type: " + temple.Castegory.Name + "  |  Temple ID: " + temple.Id; ;
                        CategoriesComboBox.Items.Add(info);
                    }
                }
                if (castleElements.Contains(selectedType))
                {
                    var castles = db.Castles;
                    foreach (var castle in castles)
                    {
                        string info = "Name: " + castle.name + "  |  Towers number: " + castle.towersNumber + "  |  Build year: " + castle.buildYear + "  |  Type: " + castle.Castegory.Name + "  |  Castle ID: " + castle.Id;
                        CategoriesComboBox.Items.Add(info);
                    }
                }
                if (caveElements.Contains(selectedType))
                {
                    var caves = db.Caves;
                    foreach (var cave in caves)
                    {
                        string info = "Name: " + cave.caveName + "  |  Area: " + cave.caveArea + "  |  Description: " + cave.caveDescription + "  |  Type: " + cave.Castegory.Name + "  |  Cave ID: " + cave.Id;
                        CategoriesComboBox.Items.Add(info);
                    }
                }
                if (desertElements.Contains(selectedType))
                {
                    var deserts = db.Deserts;
                    foreach (var desert in deserts)
                    {
                        string info = "Name: " + desert.name + "  |  Area: " + desert.area + "  |  Type: " + desert.Castegory.Name + "  |  Desert ID: " + desert.Id;
                        CategoriesComboBox.Items.Add(info);
                    }
                }
            }
        }

        public void fillLabels(Label FirstAtributeLabel, Label SecondAtributeLabel, Label ThirdAtributeLabel, Label FourthLabelAtribute, Label FifthLabelAtribute, string type)
        {
            using (var db = new GameManagerContext())
            {
                string atributesString = db.Database.SqlQuery<string>("SELECT Atributes FROM ElementTypes WHERE Name='"+type+"'").FirstOrDefault();
                string[] atributes = atributesString.Split(',');
                List<Label> labels = new List<Label> { FirstAtributeLabel, SecondAtributeLabel, ThirdAtributeLabel, FourthLabelAtribute, FifthLabelAtribute};
                int i = 0;
                foreach (var label in labels)
                {
                    label.Text = atributes[i];
                    label.Visible = true;
                    i++;
                }

            }
        }

        public void addItemToDb(string type, string name, string categoryInfo, int atribute1, int atribute2, int atribute3, int atribute4, int atribute5)
        {
            using (var db = new GameManagerContext())
            {
                string table = type + "s";
                if (type == "Warewolf")
                {
                    table = "Warewolves";
                }
                if (type == "Witch")
                {
                    table = "Witches";
                }
                if (type == "Mummy")
                {
                    table = "Mummies";
                }
                string atributesString = db.Database.SqlQuery<string>("SELECT Atributes FROM ElementTypes WHERE Name='" + type + "'").FirstOrDefault();
                string[] atributes = atributesString.Split(',');
                string catType = categoryInfo.Split(new string[] { "  |  " }, StringSplitOptions.None).Last();
                string catTable = catType.Split(' ').First() + "s";
                var typeId = db.Database.SqlQuery<int?>("SELECT Id FROM ElementTypes WHERE Name='" + type + "'").FirstOrDefault();
                int catID = Int32.Parse(catType.Split(' ').Last());
                var check = db.Database.SqlQuery<int?>("SELECT Id FROM "+ table + " WHERE Name='" + name + "' AND " + atributes[0] + "=" + atribute1 +
                                                        " AND " + atributes[1] + "=" + atribute2 + " AND " + atributes[2] + "=" + atribute3 +
                                                        " AND " + atributes[3] + "=" + atribute4 + " AND " + atributes[4] + "=" + atribute5).FirstOrDefault();
                if (check == null)
                { 
                    var atr1max = db.Database.SqlQuery<int?>("SELECT " + atributes[0] + " FROM " + table).ToList().Max();
                    var atr2max = db.Database.SqlQuery<int?>("SELECT " + atributes[1] + " FROM " + table).ToList().Max();
                    var atr3max = db.Database.SqlQuery<int?>("SELECT " + atributes[2] + " FROM " + table).ToList().Max();
                    var atr4max = db.Database.SqlQuery<int?>("SELECT " + atributes[3] + " FROM " + table).ToList().Max();
                    var atr5max = db.Database.SqlQuery<int?>("SELECT " + atributes[4] + " FROM " + table).ToList().Max();
                    if(atr1max != null && atr2max != null && atr3max != null && atr4max != null && atr5max != null)
                    {
                        if ((int)atr1max < atribute1)
                        {
                            atribute1 = (int)atr1max;
                        }
                        if ((int)atr2max < atribute2)
                        {
                            atribute2 = (int)atr2max;
                        }
                        if ((int)atr3max < atribute3)
                        {
                            atribute3 = (int)atr3max;
                        }
                        if ((int)atr4max < atribute4)
                        {
                            atribute4 = (int)atr4max;
                        }
                        if ((int)atr4max < atribute4)
                        {
                            atribute1 = (int)atr1max;
                        }
                        if ((int)atr5max < atribute5)
                        {
                            atribute5 = (int)atr5max;
                        }
                    }
                    db.Database.ExecuteSqlCommand("INSERT INTO " + table + " (Name," + atributes[0] + "," + atributes[1] + "," + atributes[2] +
                                                  "," + atributes[3] + "," + atributes[4] + ", Category_Id, Type_Id) VALUES ('" + name + "'," + atribute1 + "," +
                                                  atribute2 + "," + atribute3 + "," + atribute4 + "," + atribute5 + "," + catID + "," + typeId + ")");
                    MessageBox.Show("New element added successfully",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("This element already exists",
                                    "Element exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
