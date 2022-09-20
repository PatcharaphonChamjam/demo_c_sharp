using MoviesAPI.Models;
using System.Collections.Generic;

namespace MoviesAPI.DTOs
{
    public class MoviesDetailsDTO : MoviesDTO
    {
        public List<GenreDTO> Genres { get; set; }
        //public virtual Genres Genres { get; set; }
    }
}