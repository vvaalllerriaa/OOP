using System;

namespace MathLibrary
{
    public class ExpressionCalculator
    {
        private double _a, _b, _c, _d;
                public double A => _a;
        public double B => _b;

        public ExpressionCalculator(double a, double b, double c, double d)
        {
            _a = a; _b = b; _c = c; _d = d;
        }

        private double CalculateSqrt(double value)
        {
            if (value < 0)

                throw new ArgumentException("Число під коренем менше нуля!");
            
            return Math.Sqrt(value);
        }

        public double CalculateResult()
        {
            if (_b == 0) 
                throw new DivideByZeroException("Спроба ділення на нуль (b=0)");

            double sqrtPart;
            try 
            {
                sqrtPart = CalculateSqrt(24 + _d - _c);
            }
            catch (ArgumentException ex)
            {

                throw new Exception("Помилка в математичному модулі: " + ex.Message);
            }

            double denominator = sqrtPart + (_a / _b);

            if (Math.Abs(denominator) < 0.000001) 
                throw new ArithmeticException("Весь знаменник дорівнює нулю!");

            double numerator = 1 + _a - (_b / 2.0);
            return numerator / denominator;
        }
    }
}