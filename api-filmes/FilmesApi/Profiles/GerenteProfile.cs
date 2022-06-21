using AutoMapper;
using FilmesApi.Data.Dto.Gerente;
using FilmesApi.Models;
using System.Linq;

namespace FilmesApi.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, GerenteModel>();
            CreateMap<GerenteModel, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinema, opts => opts
                .MapFrom(gerente => gerente.Cinema.Select
                (c => new { c.Id, c.Nome, c.Endereco, c.EnderecoId })))
                ;
        }
    }
}
