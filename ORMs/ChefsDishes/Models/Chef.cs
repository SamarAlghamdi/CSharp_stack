using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FormSubmission.Models;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        [Required]
        public int ChefId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [FutureDate]
        public DateTime DoB { get; set; }
        public List<Dishe> Dishes{ get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}