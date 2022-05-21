using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Dragon
    {
        [Key]
        public int Id { get; set; }
        public virtual Caves Cave { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Accuracy { get; set; }
        public int Power { get; set; }
        public int Magica { get; set; }

    }
}