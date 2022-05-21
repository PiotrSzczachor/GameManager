using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Ent
    {
        [Key]
        public int Id { get; set; }
        public virtual Forests Forest { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Brave { get; set; }
        public int Musculature { get; set; }
        public int Magica { get; set; }
        public int Armor { get; set; }

    }
}