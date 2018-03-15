using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Models.Models
{
    public class RoleModel :ValidatorModel
    {
        public int Roleid { get; set; }
        public string Name { get; set; }
    }
}
