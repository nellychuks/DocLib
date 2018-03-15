using DocLib.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Models
{
    public class UserModel : ValidatorModel
    {
        public int Userid { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set;}
        public string LastName { get; set; }
        public string Role { get; set; }
        public override void Validate()
            {
            base.Validate();
        }

    }
}
