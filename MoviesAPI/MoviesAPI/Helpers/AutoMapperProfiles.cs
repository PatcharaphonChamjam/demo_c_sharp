﻿using AutoMapper;
using MoviesAPI.DTOs;
using MoviesAPI.Models;

namespace MoviesAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genres, GenreDTO>().ReverseMap();

            CreateMap<GenreCreationDTO, Genres>();

            CreateMap<Person, PersonDTO>().ReverseMap();

            CreateMap<PersonCreationDTO, Person>();

            CreateMap<PersonFullDetailDTO, Person>();
        }
    }
}