using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    public class Caves
    {
        [Key]
        public int Id { get; set; }
        public int caveArea { get; set; }
        public string caveName { get; set; }
        public string caveDescription { get; set; }
    }
}
