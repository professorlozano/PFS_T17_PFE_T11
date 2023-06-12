using Chapter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options): base(options)
        {
        }

        //vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) 
            {
                //cada provedor tem sua sintexe para especificação
                optionsBuilder.UseSqlServer("Data Source = PROFESSORLOB393\\SQLEXPRESS ; initial catalog = Chapter; Integrated Security = true");
            }
        }

        //dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e exclusão.
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
