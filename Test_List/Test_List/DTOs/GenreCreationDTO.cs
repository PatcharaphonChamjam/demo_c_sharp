using System.ComponentModel.DataAnnotations;

namespace Test_List.DTOs
{
    public class GenreCreationDTO
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
    }
}