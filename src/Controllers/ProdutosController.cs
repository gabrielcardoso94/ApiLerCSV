using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace src.Controllers
{
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly ProdutoService _produtoService;

        public ProdutosController(ILogger<ProdutosController> logger, ProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _produtoService.ObterTodos();
        }

        [HttpGet("{id:int}")]
        public Produto Get(int id)
        {
            return _produtoService.ObterPorId(id);
        }
    }
}