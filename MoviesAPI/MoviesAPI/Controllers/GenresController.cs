using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesAPI.DTOs;
using MoviesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly ILogger<GenresController> logger;
        private readonly Data.ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenresController(ILogger<GenresController> logger,
            Data.ApplicationDbContext context,
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
            //var genresDTOs = mapper.Map<List<GenreDTO>>(genres);
            var genresDTOs = new List<GenreDTO>();
            foreach (var genre in genres)
            {
                genresDTOs.Add(new GenreDTO()
                {
                    Id = genre.Id,
                    Name = genre.Name
                });
            }

            return genresDTOs;
        }

        [HttpGet("{id}", Name = "getGenre")]
        public async Task<ActionResult<GenreDTO>> Get(int id, string name)
        {
            //var genre = repository.GetGenreById(Id);
            var genre = await context.Genres.FirstOrDefaultAsync(x => x.Id == id);
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
            var genre = mapper.Map<Genres>(genreCreation);
            context.Add(genre);
            await context.SaveChangesAsync();
            var genreDTO = mapper.Map<GenreDTO>(genre);
            //genreDTO.Name = "xxxxxx";
            return new CreatedAtRouteResult("getGenre", new { id = genre.Id }, genreDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GenreCreationDTO genreCreation)
        {
            var genre = mapper.Map<Genres>(genreCreation);
            genre.Id = id;
            context.Entry(genre).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Genres.AnyAsync(x => x.Id == id);
            if (!exists)
            {
                return NotFound();
            }
            context.Remove(new Genres() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}