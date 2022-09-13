using MoviesAPI.Validations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field with name {0} is require")]
        [StringLength(10)]
        [FirstLetterUppercase]
        public string Name { get; set; }

        /*[Range(18, 120)]
        public int Age { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [Url]
        public string Url { get; set; }*/

        /* public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
         {
             if (!string.IsNullOrEmpty(Name))
             {
                 var FirstLetter = Name[0].ToString();
                 if (FirstLetter != FirstLetter.ToUpper())
                 {
                     yield return new ValidationResult("First Letter should be uppercase Genre", new string[] { nameof(Name) });
                 }
             }
         }*/
        public IEnumerable<string> Test = new string[] { };
    }
}