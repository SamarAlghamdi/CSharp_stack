using System.ComponentModel.DataAnnotations;

namespace Wedding_Planer.Models
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailLogin{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PasswordLogin{ get; set; } 
    }
}