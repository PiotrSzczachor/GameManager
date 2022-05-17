﻿using System;
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
        public int forestArea { get; set; }
        public string forestName { get; set; }
        public string forestType { get; set; }
    }
}