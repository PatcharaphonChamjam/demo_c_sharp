using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Test_List.Entities
{
    public class MoviesGenres
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movies Movie { get; set; }
        public Genres Genre { get; set; }
    }
}