namespace DocLib.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Itemid { get; set; }

        public int Bookid { get; set; }

        public int Quantity { get; set; }

        public int CreatedDate { get; set; }

        public int Orderid { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}
