using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class GameManagerContext : DbContext
    {
        public GameManagerContext() : base()
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Castles> Castles { get; set; }
        public DbSet<Caves> Caves { get; set; }
        public DbSet<Forests> Forests { get; set; }
        public DbSet<Temple> Temples { get; set; }
        public DbSet<Desert> Deserts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Ent> Ents { get; set; }
        public DbSet<Warewolf> Warewolfs { get; set; }
        public DbSet<Spider> Spiders { get; set; }
        public DbSet<Wizzard> Wizzards { get; set; }
        public DbSet<Witch> Witches { get; set; }
        public DbSet<Alchemist> Alchemists { get; set; }
        public DbSet<Knight> Knights { get; set; }
        public DbSet<Warrior> Warriors { get; set; }
        public DbSet<Archer> Archers { get; set; }
        public DbSet<Dragon> Dragons { get; set; }
        public DbSet<Golem> Golems { get; set; }
        public DbSet<Bat> Bats { get; set; }
        public DbSet<Mummy> Mummies { get; set; }
        public DbSet<Scorpion> Scorpions { get; set; }
        public DbSet<Cobra> Cobras { get; set; }

    }
}
