using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocLib.Models.Models
{
    class AdminModel :ValidatorModel
    {

        public int Userid { get; set; }
        public UserModel User { get; set; }
    }
}
