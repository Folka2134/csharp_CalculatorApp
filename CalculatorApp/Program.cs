using System.Runtime.CompilerServices;
using CalculatorApp.Controllers;
using CalculatorApp.Services;
using CalculatorApp.View;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new CalculatorController();
            controller.Run();
        }
    }
}