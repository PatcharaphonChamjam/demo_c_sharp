using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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

        public int PersonId { get; set; }
        public int GenresId { get; set; }

        //public List<int> genresId { get; set; }
    }
}