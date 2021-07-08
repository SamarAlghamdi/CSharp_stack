using System;
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [NoZNames]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }
        [Required]
        [FutureDate]
        // [NoZNames]
        [DataType(DataType.Date)]
        public DateTime  Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}