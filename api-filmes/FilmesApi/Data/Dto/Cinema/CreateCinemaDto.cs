using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dto.Cinema
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }
    }
}
