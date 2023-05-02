using Chapter.WebApi.Models;
using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chapter.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints (URLs) referentes aos livros
    /// </summary>

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    // ex: http://localhost:5000/api/livros
    [Route("api/[controller]")]

    // atributo para habilitar comportamentos especificos de API, como status, retorno
    [ApiController]
    // [ControllerBase] - requisicoes HTTP
    public class LivrosController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivrosController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        // GET /api/livros
        [HttpGet]
        public IActionResult Listar()
        {
            // retorna no corpo da resposta, a lista de livros
            // retorna o status Ok - 200, sucesso
            return Ok(_livroRepository.Listar());
        }
    }
}
