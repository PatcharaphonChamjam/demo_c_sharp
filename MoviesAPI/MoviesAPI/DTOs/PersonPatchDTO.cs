using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTOs
{
    public class PersonPatchDTO
    {
        public int GenderId { get; set; }
        public int DepartmentId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
    }
}