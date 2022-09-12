using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MoviesAPI.Entities;
using MoviesAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet] //https://localhost:44305/allgenres
        [HttpGet("list")] //https://localhost:44305/api/genres/list
        [HttpGet("/allgenres")] //https://localhost:44305/allgenres
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await repository.GetAllGenre();
        }

        //[HttpGet("example")]
        [HttpGet("{Id:int}")]
        public ActionResult<Genre> Get(int Id, [BindNever] string param)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var genre = repository.GetGenreById(Id);
            if (genre == null)
            {
                return NotFound();
            }
            //return Ok(2);
            //return Ok("Sam");
            return genre;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genre genre)
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genre genre)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Genre genre)
        {
            return NoContent();
        }
    }
}