using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocLib.Data.Entities
{
   public class Admin
    {
        [Key, ForeignKey ("User")]
        public int Userid { get; set; }

        public virtual User User { get; set; }
    }
}
