using AT7.Models;
using Microsoft.EntityFrameworkCore;

namespace AT7.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options) { }

        public DbSet<Livro> livros { get; set; }
    }
}
