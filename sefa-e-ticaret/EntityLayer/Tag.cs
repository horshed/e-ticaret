using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        [StringLength(30)]
        public string TagName { get; set; }
    }
}
