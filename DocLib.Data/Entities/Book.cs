namespace DocLib.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Items = new HashSet<Item>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bookid { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Author { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(250)]
        public string Image { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime Publication { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
