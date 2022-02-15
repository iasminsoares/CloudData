using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace WebApiIBGE.Data
{
    public class AppDbContexto : DbContext
    {
       
        // Definindo mapeamento ORM entre a entidade Municipio e a tabela municipio que será gerado
        
        public AppDbContexto(DbContextOptions<AppDbContexto> options) : base(options)
        {

        }

        public DbSet<Municipios> Municipios { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Municipios>()
        //        .Property(p => p.Nome)
        //            .HasMaxLength(80);

        //    //modelBuilder.Entity<Municipios>()
        //        //.HasData(
        //        //    new Municipios { Id = 1 , Nome = ""}
        //        //);

        //}

        //HttpClient municipio = new HttpClient();

        //public MunicipiosRepositorio()
        //{
        //    municipio.BaseAddress = new Url()
        //}

    }
}
