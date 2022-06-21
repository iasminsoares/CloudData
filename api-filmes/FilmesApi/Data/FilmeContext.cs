using FilmesApi.Models;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Relacionamento 1:1
            builder.Entity<EnderecoModel>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<CinemaModel>(cinema => cinema.EnderecoId);

            //Relacionamento 1:n
            builder.Entity<CinemaModel>()
                .HasOne(cinema => cinema.Gerente) //cinema possui um gerente
                .WithMany(gerente => gerente.Cinema) //gerente pode possuir uma Lista de cinemas
                .HasForeignKey(cinema => cinema.GerenteId).IsRequired(false); //permite q cinema seja criado com o GerenteId null
                //.OnDelete(DeleteBehavior.Restrict); - não deixa deletar cinema que tem um GerenteId
        }
        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<GerenteModel> Gerentes { get; set; }
    }
}
