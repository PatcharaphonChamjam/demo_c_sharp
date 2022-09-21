using System;

namespace Test_List.Entities
{
    public class MoviesActors
    {
        public int PersonId { get; set; }
        public int MovieId { get; set; }
        public Person Person { get; set; }
        public Movies Movie { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}