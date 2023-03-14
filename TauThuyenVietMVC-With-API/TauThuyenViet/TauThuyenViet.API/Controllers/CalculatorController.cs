using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TauThuyenViet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        //Hàm cộng 2 số: Add(number1, number2)
        [HttpGet("Add")]
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        //Hàm trừ 2 số: Minus (number1, number2)
        [HttpGet("Minus")]
        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        //Hàm nhân 2 số: Multiply (number1, number2)
        [HttpGet("Multiply")]
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        //Hàm chia 2 số: Divide (number1, number2)
        [HttpGet("Divide")]
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
                return 0;

            return (number1 / number2);
        }

        [HttpGet("LoginFB")]
        public bool LoginFB(string username, string password)
        {
            //.....Do everything
            //.....Do something
            return true;
        }
    }
}
