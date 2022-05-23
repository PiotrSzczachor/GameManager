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
                var check = db.Forests.FirstOrDefault(c => c.Name == name && c.Area == area);
                if (check == null)
                {
                    Forests forest = new Forests { Name = name, Area = area , Category = category};
                    db.Forests.Add(forest);
                    db.SaveChanges();
                    MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("This forest already exists.",
                                    "Forest already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                
            }
        }

        public void addDesert(string name, int area)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Desert");
                var check = db.Deserts.FirstOrDefault(c => c.name == name && c.area == area);
                if (check == null)
                {
                    Desert desert = new Desert { name = name, area = area, Castegory = category };
                    db.Deserts.Add(desert);
                    db.SaveChanges();
                    MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("This desert already exists.",
                                    "Desert already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        public void addTemple(string name_, int chambersNumber, int buildYear_)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Temple");
                var check = db.Temples.FirstOrDefault(c => c.name == name_ && c.ChambersNumber == chambersNumber && c.buildYear == buildYear_);
                if (check == null)
                {
                    Temple temple = new Temple { name = name_, ChambersNumber = chambersNumber, buildYear = buildYear_, Castegory = category };
                    db.Temples.Add(temple);
                    db.SaveChanges();
                    MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("This temple already exists.",
                                    "Temple already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        public void addCastle(string name_, int towersNumber_, int buildYear_)
        {
            using (var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Castle");
                var check = db.Castles.FirstOrDefault(c => c.name == name_ && c.towersNumber == towersNumber_ && c.buildYear == buildYear_);
                if (check == null)
                {
                    Castles castle = new Castles { name = name_, towersNumber = towersNumber_, buildYear = buildYear_, Castegory = category };
                    db.Castles.Add(castle);
                    db.SaveChanges();
                    MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("This castle already exists.",
                                    "Castle already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        public void addCave(string name_, int area_, string description_)
        {
            using(var db = new GameManagerContext())
            {
                Categories category = db.Categories.FirstOrDefault(c => c.Name == "Cave");
                var check = db.Caves.FirstOrDefault(c => c.caveName == name_ && c.caveArea == area_ && c.caveDescription == description_);
                if (check == null)
                {
                    Caves cave = new Caves { caveName = name_, caveArea = area_, caveDescription = description_, Castegory = category };
                    db.Caves.Add(cave);
                    db.SaveChanges();
                    MessageBox.Show("Added successfully",
                                    "Added successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("This cave already exists.",
                                    "Cave already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }


    }
}
