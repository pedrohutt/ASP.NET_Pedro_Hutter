using Microsoft.AspNetCore.Mvc;

namespace TP2_Calculator.Controllers
{
    public class AddingController : Controller
    {
        [Route("add/{num1}/{num2}")]
        public string Add(double Num1, double Num2)
        {
            double operation = Num1 + Num2;
            string resultString = Convert.ToString(operation);
            string resultado = $"O resultado da soma {Num1} + {Num2} = {resultString}";
            return resultado;
        }
    }
}
