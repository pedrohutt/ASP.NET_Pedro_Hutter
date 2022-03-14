using Microsoft.AspNetCore.Mvc;

namespace TP2_Calculator.Controllers
{
    public class DividingController : Controller
    {
        [Route("div/{num1}/{num2}")]
        public string Div(double Num1, double Num2)
        {
            double operation = Num1 / Num2;
            string resultString = Convert.ToString(operation);
            string resultado = $"O resultado da divisão {Num1} / {Num2} = {resultString}";
            return resultado;
        }
     
    }
}
