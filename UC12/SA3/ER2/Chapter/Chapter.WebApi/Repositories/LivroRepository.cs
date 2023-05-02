using Chapter.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;

namespace Chapter.WebApi.Repositories
{
    public class LivroRepository
    {
        // retorna a lista de livros
        public List<Livro> Listar()
        {
            var livros = new List<Livro>() 
            {
                new Livro() { Id = 1, Disponivel = true, QuantidadePaginas = 120, Titulo = "O poder do agora" },
                new Livro() { Id = 2, Disponivel = false, QuantidadePaginas = 220, Titulo = "Do mil ao milhão" },
                new Livro() { Id = 3, Disponivel = true, QuantidadePaginas = 220, Titulo = "Breves respostas para grandes questões" },
                new Livro() { Id = 4, Disponivel = false, QuantidadePaginas = 220, Titulo = "Do mil ao milhão" },
            };
            return livros;
        }

    }
}
