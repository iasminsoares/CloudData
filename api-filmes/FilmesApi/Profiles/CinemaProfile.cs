using AutoMapper;
using FilmesApi.Data.Dto.Cinema;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, CinemaModel>();
            CreateMap<UpdateCinemaDto, CinemaModel>();
            CreateMap<CinemaModel, ReadCinemaDto>();
        }
    }
}
