using System.ComponentModel.DataAnnotations;

namespace task_2.Models
{
    public class SID : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string sid = value as string;
            if (sid == null || sid[sid.Length - 2] != '-' || sid[2] != '-' || int.Parse(sid[sid.Length - 1].ToString())>3 || int.Parse(sid[sid.Length - 1].ToString()) < 1)
            {
                return new ValidationResult("Enter a valid ID (23-50139-1)");
            }
            return ValidationResult.Success;
        }
    }
}
