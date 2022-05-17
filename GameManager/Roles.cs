using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace GameManager
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
