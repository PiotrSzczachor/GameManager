using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Logic
{
    public class EditCategoryLogic
    {
        string instance;
        public EditCategoryLogic(string instance_)
        {
            instance = instance_;
        }
        public void fillForestOrDesertTextBoxes(TextBox NameBox, TextBox AreaBox)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            AreaBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Area: ", "");
        }


        public void fillTempleOrCastleTextBoxes(TextBox NameBox, TextBox NumberBox, TextBox BuildYearBox, bool temple)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            if (temple)
            {
                NumberBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Chambers number: ", "");
            } else
            {
                NumberBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Towers number: ", "");
            }
            BuildYearBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[2].Replace("Build year: ", "");
        }


        public void fillCaveTextBoxes(TextBox NameBox, TextBox AreaBox, TextBox DescriptionBox)
        {
            NameBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[0].Replace("Name: ", "");
            AreaBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[1].Replace("Area: ", "");
            DescriptionBox.Text = instance.Split(new string[] { "  |  " }, StringSplitOptions.None)[2].Replace("Description: ", "");
        }

        public void editForest(string initName, string initArea_, string name, string area_)
        {
            using (var db = new GameManagerContext())
            {
                if (name != "" && area_ != "")
                {
                    int initArea = Int32.Parse(initArea_);
                    int area = Int32.Parse(area_);
                    var check = db.Forests.FirstOrDefault(f => f.Name == name && f.Area == area);
                    if (check == null)
                    {
                        var forest = db.Forests.FirstOrDefault(f => f.Name == initName && f.Area == initArea);
                        forest.Name = name;
                        forest.Area = area;
                        db.SaveChanges();
                        MessageBox.Show("Forest changed successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This forest already exists.",
                        "Forest exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBoxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
               
            }
        }

        public void editDesert(string initName, string initArea_, string name, string area_)
        {
            using (var db = new GameManagerContext())
            {
                if (name != "" && area_ != "")
                {
                    int initArea = Int32.Parse(initArea_);
                    int area = Int32.Parse(area_);
                    var check = db.Deserts.FirstOrDefault(f => f.name == name && f.area == area);
                    if (check == null)
                    {
                        var desert = db.Deserts.FirstOrDefault(f => f.name == initName && f.area == initArea);
                        desert.name = name;
                        desert.area = area;
                        db.SaveChanges();
                        MessageBox.Show("Desert changed successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This desert already exists.",
                        "Desert exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBoxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        public void editCastle(string initName, string initNumber_, string initYear_, string name, string number_, string year_)
        {
            using (var db = new GameManagerContext())
            {
                if (name != "" && number_ != "" && year_ != "")
                {
                    int initNumber = Int32.Parse(initNumber_);
                    int number = Int32.Parse(number_);
                    int initYear = Int32.Parse(initYear_);
                    int year = Int32.Parse(year_);
                    var check = db.Castles.FirstOrDefault(f => f.name == name && f.towersNumber == number && f.buildYear == year);
                    if (check == null)
                    {
                        var castle = db.Castles.FirstOrDefault(f => f.name == initName && f.towersNumber == initNumber && f.buildYear == initYear);
                        castle.name = name;
                        castle.towersNumber = number;
                        castle.buildYear = year;
                        db.SaveChanges();
                        MessageBox.Show("Castle changed successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This castle already exists.",
                        "Castle exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBoxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        public void editTemple(string initName, string initNumber_, string initYear_, string name, string number_, string year_)
        {
            using (var db = new GameManagerContext())
            {
                if (name != "" && number_ != "" && year_ != "")
                {
                    int initNumber = Int32.Parse(initNumber_);
                    int number = Int32.Parse(number_);
                    int initYear = Int32.Parse(initYear_);
                    int year = Int32.Parse(year_);
                    var check = db.Temples.FirstOrDefault(f => f.name == name && f.ChambersNumber == number && f.buildYear == year);
                    if (check == null)
                    {
                        var temple = db.Temples.FirstOrDefault(f => f.name == initName && f.ChambersNumber == initNumber && f.buildYear == initYear);
                        temple.name = name;
                        temple.ChambersNumber = number;
                        temple.buildYear = year;
                        db.SaveChanges();
                        MessageBox.Show("Temple changed successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This temple already exists.",
                        "Temple exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBoxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        public void editCave(string initName, string initArea_, string initDescription, string name, string area_, string description)
        {
            using (var db = new GameManagerContext())
            {
                if (name != "" && area_ != "" && description != "")
                {
                    int initArea = Int32.Parse(initArea_);
                    int area = Int32.Parse(area_);
                    var check = db.Caves.FirstOrDefault(f => f.caveName == name && f.caveArea == area && f.caveDescription == description);
                    if (check == null)
                    {
                        var cave = db.Caves.FirstOrDefault(f => f.caveName == initName && f.caveArea == initArea && f.caveDescription == initDescription);
                        cave.caveName = name;
                        cave.caveArea = area;
                        cave.caveDescription = description;
                        db.SaveChanges();
                        MessageBox.Show("Cave changed successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This cave already exists.",
                        "Cave exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all TextBoxes",
                                    "Fill all TextBoxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

    }
}
