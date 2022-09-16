using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Validations
{
    public class FirstLetterUppercaseAttribute : ValidationAttribute //24.Custom Validation
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstLetter = value.ToString()[0].ToString();
            if (firstLetter != firstLetter.ToUpper())
            {
                return new ValidationResult("First Letter should be uppercase");
            }
            return ValidationResult.Success;

            //return base.IsValid(value, validationContext);
        }
    }
}