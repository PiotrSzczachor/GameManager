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
    public class Knight
    {
        [Key]
        public int Id { get; set; }
        public virtual Castles Category { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Musculature { get; set; }
        public int Brave { get; set; }
        public int Armor { get; set; }

        public virtual ElementType Type { get; set; }


    }
}