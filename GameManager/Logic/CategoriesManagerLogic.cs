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
                fillListBoxWithForests(CategoriesListBox, db);
                fillListBoxWithTemples(CategoriesListBox, db);
                fillListBoxWithCastles(CategoriesListBox, db);
                fillListBoxWithCaves(CategoriesListBox, db);
                fillListBoxWithDeserts(CategoriesListBox, db);
            }
        }

        public void fillListBoxWithForests(ListBox CategoriesListBox, GameManagerContext db)
        {
            var forests = db.Forests;
            foreach (var forest in forests)
            {
                string info = "Name: " + forest.Name + "  |  Area: " + forest.Area + "  |  Type: " + forest.Category.Name + "  |  Forest ID: " + forest.Id;
                CategoriesListBox.Items.Add(info);
            }
        }

        public void fillListBoxWithTemples(ListBox CategoriesListBox, GameManagerContext db)
        {
            var temples = db.Temples;
            foreach (var temple in temples)
            {
                string info = "Name: " + temple.name + "  |  Chambers number: " + temple.ChambersNumber + "  |  Build year: " + temple.buildYear + "  |  Type: " + temple.Castegory.Name + "  |  Temple ID: " + temple.Id; ;
                CategoriesListBox.Items.Add(info);
            }
        }

        public void fillListBoxWithCastles(ListBox CategoriesListBox, GameManagerContext db)
        {
            var castles = db.Castles;
            foreach (var castle in castles)
            {
                string info = "Name: " + castle.name + "  |  Towers number: " + castle.towersNumber + "  |  Build year: " + castle.buildYear + "  |  Type: " + castle.Castegory.Name + "  |  Castle ID: " + castle.Id;
                CategoriesListBox.Items.Add(info);
            }
        }

        public void fillListBoxWithCaves(ListBox CategoriesListBox, GameManagerContext db)
        {
            var caves = db.Caves;
            foreach (var cave in caves)
            {
                string info = "Name: " + cave.caveName + "  |  Area: " + cave.caveArea + "  |  Description: " + cave.caveDescription + "  |  Type: " + cave.Castegory.Name + "  |  Cave ID: " + cave.Id;
                CategoriesListBox.Items.Add(info);
            }
        }

        public void fillListBoxWithDeserts(ListBox CategoriesListBox, GameManagerContext db)
        {
            var deserts = db.Deserts;
            foreach (var desert in deserts)
            {
                string info = "Name: " + desert.name + "  |  Area: " + desert.area + "  |  Type: " + desert.Castegory.Name + "  |  Desert ID: " + desert.Id;
                CategoriesListBox.Items.Add(info);
            }
        }

        public void deleteForest(string ID, ListBox CategoriesListBox)
        {
            int id = Int32.Parse(ID);
            using (var db = new GameManagerContext())
            {
                var forest = db.Forests.SingleOrDefault(f => f.Id == id);
                db.Forests.Remove(forest);
                db.SaveChanges();
                CategoriesListBox.Items.Clear();
                fillListBox(CategoriesListBox);
            }
        }

        public void deleteTemple(string ID, ListBox CategoriesListBox)
        {
            int id = Int32.Parse(ID);
            using (var db = new GameManagerContext())
            {
                var temple = db.Temples.SingleOrDefault(t => t.Id == id);
                db.Temples.Remove(temple);
                db.SaveChanges();
                CategoriesListBox.Items.Clear();
                fillListBox(CategoriesListBox);
            }
        }

        public void deleteCastle(string ID, ListBox CategoriesListBox)
        {
            int id = Int32.Parse(ID);
            using (var db = new GameManagerContext())
            {
                var castle = db.Castles.SingleOrDefault(t => t.Id == id);
                db.Castles.Remove(castle);
                db.SaveChanges();
                CategoriesListBox.Items.Clear();
                fillListBox(CategoriesListBox);
            }
        }

        public void deleteCave(string ID, ListBox CategoriesListBox)
        {
            int id = Int32.Parse(ID);
            using (var db = new GameManagerContext())
            {
                var cave = db.Caves.SingleOrDefault(t => t.Id == id);
                db.Caves.Remove(cave);
                db.SaveChanges();
                CategoriesListBox.Items.Clear();
                fillListBox(CategoriesListBox);
            }
        }

        public void deleteDesert(string ID, ListBox CategoriesListBox)
        {
            int id = Int32.Parse(ID);
            using (var db = new GameManagerContext())
            {
                var desert = db.Deserts.SingleOrDefault(t => t.Id == id);
                db.Deserts.Remove(desert);
                db.SaveChanges();
                CategoriesListBox.Items.Clear();
                fillListBox(CategoriesListBox);
            }
        }
    }
}
