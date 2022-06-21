using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class EnderecoModel
    {
        //Model - é o mapeamento para o banco de dados.
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        [JsonIgnore]
        public virtual CinemaModel Cinema { get; set; } //representando o relacionamento 1:1
    }
}
