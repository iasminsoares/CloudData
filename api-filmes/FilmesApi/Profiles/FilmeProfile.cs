using AutoMapper;
using FilmesApi.Data.Dto.Filme;
using FilmesAPI.Models;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, FilmeModel>();
            CreateMap<FilmeModel, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, FilmeModel>();
        }
    }
}
