using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class Dishe
    {
        [Key]
        [Required]
        public int DisheId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0,900)]
        public int Calorais { get; set; }

        [Required]
        [Range(1,5)]
        public int Tastiness { get; set; }
        [Required]
        public string Desc { get; set; }
        public Chef Creator { get; set; }

        [Required]
        public int ChefId { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}