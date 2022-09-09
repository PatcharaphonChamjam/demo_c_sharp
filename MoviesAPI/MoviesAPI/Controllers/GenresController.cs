﻿using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;
using System.Collections.Generic;

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

        [HttpGet]
        public List<Genre> Get()
        {
            return repository.GetAllGenre();
        }

        [HttpGet]
        public Genre Get(int Id)
        {
            var genre = repository.GetGenreById(Id);
            if (genre == null)
            {
                //return NotFound();
            }
            return genre;
        }

        [HttpPost]
        public void Post()
        {
        }

        [HttpPut]
        public void Put()
        {
        }

        [HttpDelete]
        public void Delete()
        {
        }
    }
}