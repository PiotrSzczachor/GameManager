using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Logic
{
    public class AddCategoryLogic
    {
        public void addForest(string name, int area)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Forest");
                Forests forest = new Forests { Name = name, Area = area , Category = category};
                db.Forests.Add(forest);
                db.SaveChanges();
            }
        }

        public void addDesert(string name, int area)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Desert");
                Desert desert = new Desert { name = name, area = area, Castegory = category };
                db.Deserts.Add(desert);
                db.SaveChanges();
            }
        }

        public void addTemple(string name_, int chambersNumber, int buildYear_)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Temple");
                Temple temple = new Temple { name = name_, ChambersNumber = chambersNumber, buildYear = buildYear_, Castegory = category };
                db.Temples.Add(temple);
                db.SaveChanges();
            }
        }

        public void addCastle(string name_, int chambersNumber, int buildYear_)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Castle");
                Castles castle = new Castles { name = name_, towersNumber = chambersNumber, buildYear = buildYear_, Castegory = category };
                db.Castles.Add(castle);
                db.SaveChanges();
            }
        }

        public void addCave(string name_, int area_, string description_)
        {
            using(var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Cave");
                Caves cave = new Caves { caveName = name_, caveArea = area_, caveDescription = description_ , Castegory = category};
                db.Caves.Add(cave);
                db.SaveChanges();
            }
        }


    }
}
