using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PessoaAPI.Model;
using PessoaAPI.Business;

namespace PessoaAPI.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : ControllerBase
    {
        
        private readonly ILogger<PessoaController> _logger;
        private ILivroBusiness _livroBusiness;

        public LivroController(ILogger<PessoaController> logger, ILivroBusiness livroBusiness)
        {
            _logger = logger;
            _livroBusiness = livroBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_livroBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _livroBusiness.FindById(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_livroBusiness.Create(livro));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_livroBusiness.Update(livro));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();
            _livroBusiness.Delete(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _livroBusiness.DeleteById(id);
            return NoContent();
        }

    }
}
