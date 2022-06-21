using FilmesAPI.Models;
using System.Collections.Generic;
namespace FilmesApi.Data.Dto.Gerente
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinema { get; set; } //objeto anonimo
    }
}
