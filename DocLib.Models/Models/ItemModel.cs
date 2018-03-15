using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Models
{
 public   class ItemModel
    {
        public int Bookid { get; set; }
        public int Quantity { get; set; }

        public BookModel Book { get; set; }
    }
}
