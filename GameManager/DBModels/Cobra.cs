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
    public class Cobra
    {
        [Key]
        public int Id { get; set; }
        public virtual Desert Category { get; set; }
        public string Name { get; set; }
        public int Virulence { get; set; }
        public int Speed { get; set; }
        public int Shell { get; set; }
        public int Seeing { get; set; }
        public int Agility { get; set; }

        public virtual ElementType Type { get; set; }

    }
}
