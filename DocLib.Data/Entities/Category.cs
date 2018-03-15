using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DocLib.Data.Entities
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }
    }
}
