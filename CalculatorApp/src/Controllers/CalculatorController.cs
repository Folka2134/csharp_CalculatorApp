using CalculatorApp.Services;
using CalculatorApp.View;

namespace CalculatorApp.Controllers
{
    public class CalculatorController
    {
        private readonly ICalculator _calculator;
        private readonly ConsoleView _view;

        public CalculatorController()
        {
            _calculator = new Calculator();
            _view = new ConsoleView();
        }

        public void Run()
        {
            _view.DisplayMessage("Calculator on.");

            while (true)
            {
                _view.DisplayMessage("Enter operation or Exit");
                var input = _view.UserInput();

                if (input == "Exit" || input == "exit")
                {
                    _view.DisplayMessage("Calculator off.");
                    break;
                }

                try
                {
                    var operation = input.Split(' ');
                    var a = double.Parse(operation[0]);
                    var op = operation[1];
                    var b = double.Parse(operation[2]);

                    double result = op switch
                    {
                        "+" => _calculator.Add(a, b),
                        "-" => _calculator.Subtract(a, b),
                        "*" => _calculator.Multiply(a, b),
                        "/" => _calculator.Divide(a, b),
                        _ => throw new InvalidOperationException("Invalid operator.")
                    };

                    _view.DisplayMessage($"{input} = {result}");
                }
                catch (Exception ex)
                {
                    _view.DisplayMessage($"Error: {ex.Message}");
                }
            }
        }
    }
}