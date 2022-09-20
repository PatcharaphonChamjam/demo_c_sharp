using AutoMapper;
using MoviesAPI.DTOs;
using MoviesAPI.Models;
using System.Collections.Generic;

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

            CreateMap<Movies, MoviesDetailsDTO>()
                .ForMember(x => x.Genres, optios => optios.MapFrom(MapMoviesGenres));
        }

        private List<GenreDTO> MapMoviesGenres(Movies movies, MoviesDetailsDTO moviesDetailsDTO)
        {
            var result = new List<GenreDTO>();
            foreach (var moviegenre in movies.Genres)
            {
                result.Add(new GenreDTO() { Id = moviegenre.Id, Name = moviegenre.Name });
            }
            return result;
        }
    }
}