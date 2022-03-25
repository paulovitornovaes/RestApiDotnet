using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<FilmeDto, Filme>();
            CreateMap<Filme, FilmeDto>();
        }
    }
}
