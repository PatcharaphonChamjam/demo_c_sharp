using AutoMapper;
using System.Collections.Generic;
using Test_List.DTOs;
using Test_List.Entities;

namespace Test_List.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genres, GenresDTO>().ReverseMap();

            CreateMap<GenreCreationDTO, Genres>();

            CreateMap<Person, PersonDTO>().ReverseMap();

            CreateMap<PersonCreationDTO, Person>()
                .ForMember(x => x.Picture, options => options.Ignore());

            CreateMap<Person, PersonPatchDTO>().ReverseMap();

            CreateMap<Movies, MovieDTO>().ReverseMap();

            CreateMap<MovieCreationDTO, Movies>()
                .ForMember(x => x.Poster, options => options.Ignore())
                .ForMember(x => x.MoviesGenres, options => options.MapFrom(MapMoviesGenres))
                .ForMember(x => x.MoviesActors, options => options.MapFrom(MapMoviesActors));

            /*CreateMap<Movies, MovieDetailsDTO>()
               .ForMember(x => x.Genres, options => options.MapFrom(MapMoviesGenres))
               .ForMember(x => x.Actors, options => options.MapFrom(MapMoviesActors));
            CreateMap<Movies, MoviePatchDTO>().ReverseMap();*/
        }

        /*   private List<GenresDTO> MapMoviesGenres(Movies movie, MovieDetailsDTO movieDetailsDTO)
           {
               var result = new List<GenresDTO>();
               foreach (var moviegenre in movie.MoviesGenres)
               {
                   result.Add(new GenresDTO() { Id = moviegenre.GenreId, Name = moviegenre.Genre.Name });
               }
               return result;
           }

           private List<ActorDTO> MapMoviesActors(Movies movie, MovieDetailsDTO movieDetailsDTO)
           {
               var result = new List<ActorDTO>();
               foreach (var actor in movie.MoviesActors)
               {
                   result.Add(new ActorDTO() { PersonId = actor.PersonId, Character = actor.Character, PersonName = actor.Person.Name });
               }
               return result;
           }*/

        private List<MoviesGenres> MapMoviesGenres(MovieCreationDTO movieCreationDTO, Movies movies)
        {
            var result = new List<MoviesGenres>();
            foreach (var id in movieCreationDTO.GenresIds)
            {
                result.Add(new MoviesGenres() { GenreId = id });
            }
            return result;
        }

        private List<MoviesActors> MapMoviesActors(MovieCreationDTO movieCreationDTO, Movies movies)
        {
            var result = new List<MoviesActors>();
            foreach (var actor in movieCreationDTO.Actors)
            {
                result.Add(new MoviesActors() { PersonId = actor.PersonId, Character = actor.Character });
            }
            return result;
        }
    }
}