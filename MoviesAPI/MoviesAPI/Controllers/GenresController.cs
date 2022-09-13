using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using MoviesAPI.Entities;
using MoviesAPI.Filters;
using MoviesAPI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repository;
        private readonly ILogger<GenresController> logger;

        public GenresController(IRepository repository, ILogger<GenresController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet] //https://localhost:44305/allgenres
        [HttpGet("list")] //https://localhost:44305/api/genres/list
        [HttpGet("/allgenres")] //https://localhost:44305/allgenres
        //[ResponseCache(Duration = 60)]
        [ServiceFilter(typeof(MyActionFilter))] //31.Custom filters
        public async Task<ActionResult<List<Genre>>> Get()
        {
            logger.LogInformation("Getting all the genre");
            return await repository.GetAllGenre();
        }

        //[HttpGet("example")]
        [HttpGet("{Id:int}", Name = "getGenre")]
        [ServiceFilter(typeof(MyActionFilter))] //31.Custom filters
        public ActionResult<Genre> Get(int Id, string param)
        {
            logger.LogDebug("get by Id method executing....");
            var genre = repository.GetGenreById(Id);
            if (genre == null)
            {
                logger.LogWarning($"Genre with Id {Id} not found");
                logger.LogError("this is an error");
                //throw new ApplicationException(); //31.Custom filters
                return NotFound();
            }
            //return Ok(2);
            //return Ok("Sam");
            return genre;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genre genre)
        {
            repository.AddGenre(genre);
            return new CreatedAtRouteResult("getGenre", new { Id = genre.Id }, genre);
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