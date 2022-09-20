using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.DTOs;
using MoviesAPI.Helpers;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MoviesController(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IndexMoviePageDTO>> Get()
        {
            var top = 2;
            var today = DateTime.Today;
            var upcomingRelease = await context.Movies
                .Where(x => x.ReleaseDate > today)
                .OrderBy(x => x.ReleaseDate)
                .Take(top)
                .ToListAsync();

            var InTheaters = await context.Movies
                .Where(x => x.InTheaters)
                .Take(top)
                .ToListAsync();

            var result = new IndexMoviePageDTO();
            result.InTheaters = mapper.Map<List<MoviesDTO>>(InTheaters);
            result.upcomingRelease = mapper.Map<List<MoviesDTO>>(upcomingRelease);
            return result;

            //var movie = await context.Movies.ToListAsync();
            //return mapper.Map<List<MoviesDTO>>(movie);
        }

        [HttpGet("filter")] //53.Filtering
        public async Task<ActionResult<List<MoviesDTO>>> filter([FromQuery] FilterMoviesDTO filterMoviesDTO)
        {
            var moviesQueryable = context.Movies.AsQueryable();
            if (!string.IsNullOrWhiteSpace(filterMoviesDTO.Title))
            {
                moviesQueryable = moviesQueryable.Where(x => x.Title.Contains(filterMoviesDTO.Title));
            }

            //รับค่าจาก param in postman if InTheaters == True แสดงค่าที่ InTheaters เป็น True
            moviesQueryable = moviesQueryable.Where(x => x.InTheaters == filterMoviesDTO.InTheaters);

            if (filterMoviesDTO.UpcomingRelease)
            {
                var today = DateTime.Today;
                moviesQueryable = moviesQueryable.Where(x => x.ReleaseDate > today);
            }
            if (filterMoviesDTO.GenresId != 0)
            {
                moviesQueryable = moviesQueryable
                    .Where(x => x.GenresId == filterMoviesDTO.GenresId);
            }

            await HttpContext.InsertPaginationParametersInResponse(moviesQueryable,
                filterMoviesDTO.RecordPerPage);

            var movies = await moviesQueryable.Pagination(filterMoviesDTO.Pagination).ToListAsync();

            return mapper.Map<List<MoviesDTO>>(movies);
        }

        [HttpGet("{id}", Name = "getMovie")]
        public async Task<ActionResult<MoviesDTO>> Get(int id)
        {
            var movie = await context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return mapper.Map<MoviesDTO>(movie);
        }

        [HttpPost]
        public async Task<ActionResult> Post(MoviesCreationDTO moviesCreationDTO)
        {
            var movie = mapper.Map<Movies>(moviesCreationDTO);

            context.Add(movie);
            await context.SaveChangesAsync();
            var movieDTO = mapper.Map<MoviesDTO>(movie);
            return Ok(movieDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, MoviesCreationDTO moviesCreationDTO)
        {
            /*var movieDB = context.Movies.FirstOrDefaultAsync(x => id == id);
            if (movieDB == null)
            {
                return NotFound();
            }*/
            var movie = mapper.Map<Movies>(moviesCreationDTO);
            movie.Id = id;
            context.Entry(movie).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Movies.AnyAsync(x => x.Id == id);
            if (!exists)
            {
                return NotFound();
            }
            context.Remove(new Movies() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(int id, [FromBody] JsonPatchDocument<MoviesCreationDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }
            var entityFromDB = await context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (entityFromDB == null)
            {
                return NotFound();
            }

            var entityDTO = mapper.Map<MoviesCreationDTO>(entityFromDB);
            patchDocument.ApplyTo(entityDTO, ModelState);

            var isValid = TryValidateModel(entityDTO);
            if (!isValid)
            {
                return BadRequest(ModelState);
            }
            mapper.Map(entityDTO, entityFromDB);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}