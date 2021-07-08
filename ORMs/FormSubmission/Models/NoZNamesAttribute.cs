using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class NoZNamesAttribute :  ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null){
            return new ValidationResult("No names !");
        }
        else if (((string)value).ToLower()[0] == 'z')
            return new ValidationResult("No names that start with Z allowed!");
        return ValidationResult.Success;
    }
}
}