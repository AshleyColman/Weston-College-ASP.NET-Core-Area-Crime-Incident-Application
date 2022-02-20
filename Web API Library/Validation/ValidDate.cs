using System.ComponentModel.DataAnnotations;

namespace Web_API_Library.Validation
{
    public sealed class ValidDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            return Convert.ToDateTime(value) >= DateTime.Now ? new ValidationResult(ErrorMessage) : ValidationResult.Success!;
        }
    }
}
