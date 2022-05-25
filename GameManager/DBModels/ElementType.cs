using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameManager.DBModels
{
    public class ElementType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Atributes { get; set; }
    }
}
