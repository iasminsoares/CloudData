using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class GerenteModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string  Nome { get; set; }

        [JsonIgnore]
        public virtual List<CinemaModel> Cinema { get; set; } //representando o relacionamento 1:n

    }
}
