using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Forests
    {
        [Key]
        public int Id { get; set; }
        public virtual Categories Category { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
    }
}
