using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Wedding_Planer.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        
    protected override ValidationResult IsValid(object v, ValidationContext validationContext)
    {
        DateTime date =Convert.ToDateTime(v);
        // CultureInfo enUS = new CultureInfo("en-US");
        // DateTime date = DateTime.ParseExact((string)v,"dd/MM/yyyy", enUS.DateTimeFormat );
        // Console.WriteLine(date);
        if(date <= DateTime.Now){
            return new ValidationResult("The date must be in the Future!");
        }
        else{
            return ValidationResult.Success;
        }
    }

    }
}