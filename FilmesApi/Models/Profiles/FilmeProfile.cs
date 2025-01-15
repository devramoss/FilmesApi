using AutoMapper;
using FilmesApi.Data.Dtos;

namespace FilmesApi.Models.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile() {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
