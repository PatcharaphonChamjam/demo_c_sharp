using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_List.Entities
{
    public class Genres
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        public List<MoviesGenres> MoviesGenres { get; set; }
    }
}