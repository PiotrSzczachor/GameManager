using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Warrior
    {
        [Key]
        public int Id { get; set; }
        public virtual Castles Castle { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Musculature { get; set; }
        public int Brave { get; set; }
        public int Armor { get; set; }

    }
}