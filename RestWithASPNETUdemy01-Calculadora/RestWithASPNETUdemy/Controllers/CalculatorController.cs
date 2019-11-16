using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        // GET api/values/5
        [HttpGet("/sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string  secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);

                return  Ok(sum.ToString());
            }
            return  BadRequest("invalid input") ;
        }

        [HttpGet("/Divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(string firstNumber, string  secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divide = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);

                return  Ok(divide.ToString());
            }
            return  BadRequest("invalid input") ;
        }

        [HttpGet("/Mutiply/{firstNumber}/{secondNumber}")]
        public IActionResult Mutiply(string firstNumber, string  secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divide = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);

                return  Ok(divide.ToString());
            }
            return  BadRequest("invalid input") ;
        }

        [HttpGet("/Subtract/{firstNumber}/{secondNumber}")]
        public IActionResult Subtract(string firstNumber, string  secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divide = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);

                return  Ok(divide.ToString());
            }
            return  BadRequest("invalid input") ;
        }


        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

    }
}
