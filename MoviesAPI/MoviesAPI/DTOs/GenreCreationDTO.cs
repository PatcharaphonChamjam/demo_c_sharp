using MoviesAPI.Validations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTOs
{
    public class GenreCreationDTO
    {
        [Required]
        [StringLength(40)]
        [FirstLetterUppercase]
        public string Name { get; set; }

        public int MovieId { get; set; }
    }
}