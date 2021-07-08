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

        public IActionResult Somar(string numero1, string numero2)
        {
            if (IsNumeric(numero1) && IsNumeric(numero2))
            {
                var soma = ConvertToDouble(numero1) + ConvertToDouble(numero2);
                return Ok(soma.ToString());
            } else
            {
                return BadRequest("Deu ruim!");
            }
            
        }


        [HttpGet("subtrair/{numero1}/{numero2}")]

        public IActionResult Subtrair(string numero1, string numero2)
        {
            if (IsNumeric(numero1) && IsNumeric(numero2))
            {
                var soma = ConvertToDouble(numero1) - ConvertToDouble(numero2);
                return Ok(soma.ToString());
            }
            else
            {
                return BadRequest("Deu ruim!");
            }

        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private double ConvertToDouble(string strNumber)
        {
            double number;
            if (double.TryParse(strNumber, out number))
            {
                return number;
            } else
            {
                return 0;
            }

        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal number;
            if (decimal.TryParse(strNumber, out number))
            {
                return number;
            }
            else
            {
                return 0;
            }

        }

    }
}
