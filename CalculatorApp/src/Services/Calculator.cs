namespace CalculatorApp.Services
{
  class Calculator : ICalculator
  {
    public double Add(double a, double b)
    {
      return a + b;
    }

    public double Subtract(double a, double b)
    {
      return b - a;
    }

    public double Multiply(double a, double b)
    {
      return a * b;
    }

    public double Divide(double a, double b)
    {
      return a / b;
    }
  }
}
