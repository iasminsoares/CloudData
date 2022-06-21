using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dto.Gerente;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public GerenteController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente([FromBody]CreateGerenteDto gerenteDto)
        {
            GerenteModel gerente = _mapper.Map<GerenteModel>(gerenteDto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = gerente.Id});
        }

        [HttpGet]
        public IEnumerable<GerenteModel> RecuperaGerente()
        {
            return _context.Gerentes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId( int id)
        {
            GerenteModel gerente = _context.Gerentes.FirstOrDefault(endereco => endereco.Id == id);
            if (gerente is not null)
            {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(gerenteDto);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaGerente(UpdateGerenteDto gerenteDto, int id)
        {
            GerenteModel gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente is null)
            {
                return NotFound();
            }

            _mapper.Map(gerenteDto, gerente);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            GerenteModel gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente is null)
            {
                return NotFound();
            }

            _context.Remove(gerente);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
