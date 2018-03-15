using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DocLib.Models;
using DocLib.Models.Models;

namespace DocLib.Models
{
    public class SignUpViewModel : ValidatorModel
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required, Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, DataType(DataType.Password), MinLength(8, ErrorMessage ="password Must be st least 8 characters")]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password != ConfirmPassword)
            {
                yield return new ValidationResult("Passwords do not match", new[] { nameof(Password), nameof(ConfirmPassword) });
            }
        }
           
    }
}