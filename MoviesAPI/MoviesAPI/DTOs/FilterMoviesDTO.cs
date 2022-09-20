using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MoviesAPI.DTOs
{
    public class FilterMoviesDTO
    {
        public int Page { get; set; } = 1;
        public int RecordPerPage { get; set; } = 10;

        public PaginationDTO Pagination
        {
            get { return new PaginationDTO() { Page = Page, RecordPerPage = RecordPerPage }; }
        }

        public string Title { get; set; }
        public int GenresId { get; set; }
        public bool InTheaters { get; set; }
        public bool UpcomingRelease { get; set; }

        public string Summary { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PersonId { get; set; }
    }
}