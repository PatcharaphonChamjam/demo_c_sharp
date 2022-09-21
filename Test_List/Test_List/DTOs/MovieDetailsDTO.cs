using System.Collections.Generic;

namespace Test_List.DTOs
{
    public class MovieDetailsDTO
    {
        public List<GenresDTO> Genres { get; set; }
        public List<ActorDTO> Actors { get; set; }
    }
}