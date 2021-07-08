using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="First name should be more than 2 letters")]
        [Display(Name = "Your First Name")]
        public string FirstName{ get; set;}

        [Required]
        [MinLength(2, ErrorMessage="Last name should be more than 2 letters")]
        [Display(Name = "Your Last Name")]
        public string LastName{ get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email{ get; set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password{ get; set;}

        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm { get; set; }

        public double balance { get; set; }=0.0;
        public List<Transaction> Transactions { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}