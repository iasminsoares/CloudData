using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dto.Cinema;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private FilmeContext _filmeContext;
        private IMapper _mapper;
        
        public CinemaController(FilmeContext filme, IMapper mapper)
        {
            _filmeContext = filme;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto) 
        {
            CinemaModel cinema = _mapper.Map<CinemaModel>(cinemaDto);
            _filmeContext.Cinemas.Add(cinema);
            _filmeContext.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpGet]
        public IEnumerable<CinemaModel> RecuperaCinema()
        {
            return _filmeContext.Cinemas;
        }

        [HttpGet ("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            CinemaModel cinema = _filmeContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id );
            if (cinema is not null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
            return NotFound();
        }

        [HttpPut ("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            CinemaModel cinema = _filmeContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id);

            if (cinema is null)
            {
                return NotFound();
            }
            _mapper.Map(cinemaDto, cinema);
            _filmeContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete ("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            CinemaModel cinema = _filmeContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema is null)
            {
                return NotFound();
            }

            _filmeContext.Remove(cinema);
            _filmeContext.SaveChanges ();
            return NoContent();
        }
    }
}
