using Microsoft.AspNetCore.Mvc;

namespace TP2_Calculator.Controllers
{
    public class MultiplyingController : Controller
    {
        [Route("mult/{num1}/{num2}")]
        public string Mult(double Num1, double Num2)
        {
            double operation = Num1 * Num2;
            string resultString = Convert.ToString(operation);
            string resultado = $"O resultado da multiplicação {Num1} x {Num2} = {resultString}";
            return resultado;
        }

    }
}
