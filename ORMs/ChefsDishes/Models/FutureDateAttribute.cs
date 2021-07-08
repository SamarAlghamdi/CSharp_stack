using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FormSubmission.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        
    protected override ValidationResult IsValid(object v, ValidationContext validationContext)
    {
        DateTime date =Convert.ToDateTime(v);
        // CultureInfo enUS = new CultureInfo("en-US");
        // DateTime date = DateTime.ParseExact((string)v,"dd/MM/yyyy", enUS.DateTimeFormat );
        // Console.WriteLine(date);
        if(date >= DateTime.Now){
            return new ValidationResult("The date must be in the past!");
        }
        else{
            int dateYear = date.Year;
            int year = DateTime.Now.Year;
            int age = year-dateYear;
            if (age<=18){ 
                return new ValidationResult("Age must be over 18 years!");
            } else return ValidationResult.Success;
        }
    }

    }
}