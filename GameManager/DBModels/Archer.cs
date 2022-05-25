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
    public class Archer
    {
        [Key]
        public int Id { get; set; }
        public virtual Castles Category { get; set; }
        public string Name { get; set; }
        public int Accuracy { get; set; }
        public int Inteligence { get; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }
        public int Focusing { get; set; }

        public virtual ElementType Type { get; set; }


    }
}