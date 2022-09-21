using System.ComponentModel.DataAnnotations;
using System;

namespace Test_List.DTOs
{
    public class MoviePatchDTO
    {
        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}