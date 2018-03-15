using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Models.Models
{
    public class CategoryModel :ValidatorModel
    {
        public int Categoryid { get; set; }
        public string CategoryName { get; set; } 
    }
}
