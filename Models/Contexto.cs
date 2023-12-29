using Microsoft.EntityFrameworkCore;

namespace TeladeCadastro.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options)
        {
        }
        public DbSet<Cadastro> cadastros { get; set; }
    }
}
