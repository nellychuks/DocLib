using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocLib.Models
{
  public  class BookModel
    {
        public int Bookid { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Desription { get; set; }
        public DateTime Publication { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}
