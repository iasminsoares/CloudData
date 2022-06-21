using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dto.Endereco;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private  IMapper _mapper;
        private FilmeContext _context;
        public EnderecoController(IMapper mapper, FilmeContext context)
        {
            _context = context;
            _mapper = mapper;   
        }

        [HttpPost]
        public IActionResult AdicionaEndereço([FromBody]CreateEnderecoDto enderecoDto)
        {
            EnderecoModel endereco = _mapper.Map<EnderecoModel>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new {Id = endereco.Id}, endereco);
        }

        [HttpGet]
        public IEnumerable<EnderecoModel> RetornaEndereco()
        {
            return _context.Enderecos;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco is not null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(enderecoDto);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto updateEnderecoDto)
        {
            EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco is null)
            {
                return NotFound();
            }

            _mapper.Map(updateEnderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco is null)
            {
                return NotFound();
            }

            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
