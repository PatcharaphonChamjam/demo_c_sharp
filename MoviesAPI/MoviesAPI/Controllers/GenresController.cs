using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesAPI.DTOs;
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
        private readonly ILogger<GenresController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenresController(ILogger<GenresController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GenreDTO>>> Get()
        {
            var genres = await context.Genres.AsNoTracking().ToListAsync();
            var genresDTOs = mapper.Map<List<GenreDTO>>(genres);
            /* var genresDTOs = new List<GenreDTO>();
             foreach (var genre in genres)
             {
                 genresDTOs.Add(new GenreDTO()
                 {
                     Id = genre.Id,
                     Name = genre.Name
                 });
             }*/
            return genresDTOs;
        }

        [HttpGet("{Id:int}", Name = "getGenre")]
        public async Task<ActionResult<GenreDTO>> Get(int Id)
        {
            //var genre = repository.GetGenreById(Id);
            var genre = await context.Genres.FirstOrDefaultAsync(x => x.Id == Id);
            if (genre == null)
            {
                return NotFound();
            }
            var genresDTOs = mapper.Map<GenreDTO>(genre);
            return genresDTOs;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GenreCreationDTO genreCreation)
        {
            var genre = mapper.Map<Genre>(genreCreation);
            context.Add(genre);
            await context.SaveChangesAsync();
            var genreDTO = mapper.Map<GenreDTO>(genre);

            return new CreatedAtRouteResult("getGenre", new { genreDTO.Id }, genreDTO);
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