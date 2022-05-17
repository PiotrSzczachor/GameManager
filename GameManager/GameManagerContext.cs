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

        public DbSet<Castles> Castles { get; set; }
        public DbSet<Caves> Caves { get; set; }
        public DbSet<Forests> Forest { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
