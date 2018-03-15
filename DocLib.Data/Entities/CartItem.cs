using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace DocLib.Data.Entities
{
    public partial class CartItem
    {
        public int CartItemid { get; set; }
        public int Userid { get; set; }
        public int Bookid { get; set; }
      

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
