using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
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
        [HttpGet("{Id:int}/{param=john}")]
        public ActionResult<Genre> Get(int Id, string param)
        {
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
        public ActionResult Post()
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}