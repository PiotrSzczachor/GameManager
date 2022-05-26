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
        public bool AddForests { get; set; }
        public bool AddTemples { get; set; }
        public bool AddCastles { get; set; }
        public bool AddCaves { get; set; }
        public bool AddDeserts { get; set; }
        public bool DeleteCategories { get; set; }
        public bool EditCategories { get; set; }
        public bool AddElements { get; set; }
        public bool EditElements { get; set; }
        public bool DeleteElements { get; set; }
        public bool AddRoles { get; set; }
        public bool EditRoles { get; set; }
        public bool DeleteRoles { get; set; }
        public bool AddUsers { get; set; }
        public bool DeleteUsers { get; set; }
        public bool EdidUsers { get; set; }
    }
}
