using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTOs
{
    public class MoviesCreationDTO
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Summary { get; set; }

        public bool InTheaters { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}