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
    }
}
