using Chapter.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class SqlContext : DbContext

    {
        public SqlContext()
        {
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão foi depende da SUA máquina.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-EVA10TL\\SQLEXPRESS; initial catalog = Chapter; user id = sa; password = 1234");
                // Exemplo 1 de string de conexão:
                // User ID=sa;Password=admin;Server=localhost;Database=Chapter;-
                // + Trusted_Connection=False;
                // Exemplo 2 de string de conexão:
                // 
                // Server = localhost\\SQLEXPRESS; Database = Chapter; Trusted_Connection = True;
            }
        }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
