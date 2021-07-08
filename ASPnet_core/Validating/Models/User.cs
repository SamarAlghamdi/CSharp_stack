using System.ComponentModel.DataAnnotations;

namespace Validating.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First name:")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        [Required]
        [Range(1,120)]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email:")]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Your password:")]
        public string Password { get; set; }

    }
}