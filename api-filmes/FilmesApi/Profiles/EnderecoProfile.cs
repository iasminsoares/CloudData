using AutoMapper;
using FilmesApi.Data.Dto.Endereco;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, EnderecoModel>().ReverseMap();
            CreateMap<EnderecoModel, ReadEnderecoDto>().ReverseMap();
            CreateMap<UpdateEnderecoDto, EnderecoModel>().ReverseMap();
        }
    }
}
