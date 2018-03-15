namespace DocLib.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public string Email { get; set; }

       
        public string Password { get; set; }

       
        public DateTime CreatedDate { get; set; }

        public virtual Role Role { get; set; }
    }
}
