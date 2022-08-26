﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(30)]
        public string CategoryName { get; set; }
    }
}
