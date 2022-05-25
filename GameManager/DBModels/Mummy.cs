using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GameManager.DBModels;
using System.ComponentModel;

namespace GameManager
{
    public class Mummy
    {
        [Key]
        public int Id { get; set; }
        public virtual Desert Category { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Magica { get; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }
        public int Stamina { get; set; }

        public virtual ElementType Type { get; set; }


    }
}