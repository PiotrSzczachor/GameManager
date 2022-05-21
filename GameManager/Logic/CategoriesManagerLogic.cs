using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    public class CategoriesManagerLogic
    {
        public void fillListBox(ListBox CategoriesListBox)
        {
            using (var db = new GameManagerContext())
            {
                var forests = db.Forests;
                var temples = db.Temples;
                var castles = db.Castles;
                var caves = db.Caves;
                var deserts = db.Deserts;
                foreach (var forest in forests)
                {
                    string info = "Name: " + forest.Name + "  |  Area: " + forest.Area + "  |  Type: " + forest.Category.Name;
                    CategoriesListBox.Items.Add(info);
                }
                foreach (var temple in temples)
                {
                    string info = "Name: " + temple.name + "  |  Chambers number: " + temple.ChambersNumber + "  |  Build year: " + temple.buildYear + "  |  Type: " + temple.Castegory.Name;
                    CategoriesListBox.Items.Add(info);
                }
                foreach (var castle in castles)
                {
                    string info = "Name: " + castle.name + "  |  Towers number: " + castle.towersNumber + "  |  Build year: " + castle.buildYear + "  |  Type: " + castle.Castegory.Name;
                    CategoriesListBox.Items.Add(info);
                }
                foreach (var cave in caves)
                {
                    string info = "Name: " + cave.caveName + "  |  Cave area: " + cave.caveArea + "  |  Cave description: " + cave.caveDescription + "  |  Type: " + cave.Castegory.Name;
                    CategoriesListBox.Items.Add(info);
                }
                foreach (var desert in deserts)
                {
                    string info = "Name: " + desert.name + "  |  Area: " + desert.area + "  |  Type: " + desert.Castegory.Name;
                    CategoriesListBox.Items.Add(info);
                }

            }
        }
    }
}
