using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {

        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("somar/{numero1}/{numero2}")]

        public IActionResult Get(decimal numero1, decimal numero2)
        {
            if (numero1 >= 0 && numero2 >= 0)
            {
                var soma = numero2 + numero1;
                return Ok(soma.ToString());
            }

            return BadRequest("Deu ruim!");
        }
    }
}
