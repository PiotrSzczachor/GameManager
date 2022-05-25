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
    public class Wizzard
    {
        [Key]
        public int Id { get; set; }
        public virtual Temple Category { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Inteligence { get; set; }
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public virtual ElementType Type { get; set; }

    }
}