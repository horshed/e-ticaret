using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStoc { get; set; }
        
        public double ProductPrice { get; set; }
        public Category Category { get; set; }
        
        public Tag Tag { get; set; }
        
    }
}
