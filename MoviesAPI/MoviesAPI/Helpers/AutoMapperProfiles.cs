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

            CreateMap<PersonCreationDTO, Person>()
                .ForMember(x => x.Picture, options => options.Ignore());

            CreateMap<Person, PersonPatchDTO>().ReverseMap();

            CreateMap<PersonFullDetailDTO, Person>();

            CreateMap<Movies, MoviesDTO>().ReverseMap();

            CreateMap<MoviesCreationDTO, Movies>().ReverseMap();
        }
    }
}