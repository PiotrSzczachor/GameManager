using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Desert
    {
        [Key]
        public int Id { get; set; }
        public virtual Categories Castegory { get; set; }
        public string name { get; set; }
        public int area { get; set; }

    }
}