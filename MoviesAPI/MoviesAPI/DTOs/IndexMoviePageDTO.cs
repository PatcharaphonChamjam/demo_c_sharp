using System.Collections.Generic;

namespace MoviesAPI.DTOs
{
    public class IndexMoviePageDTO
    {
        public List<MoviesDTO> upcomingRelease { get; set; }
        public List<MoviesDTO> InTheaters { get; set; }
    }
}