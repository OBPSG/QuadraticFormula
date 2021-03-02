using System;

namespace QuadraticFormulaCalculator
{
    public class Complex
    {
        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public double Real { get; set; }
        public double Imaginary { get; set; }

    }

    public static class Calcuator
    {
        public static Complex[] Calculate(double a, double b, double c)
        {
            var results = new Complex[] { new Complex(a, 0.0), new Complex(b, 0.0), new Complex(c, 0.0) };
            return results;
        }
    }
    
}
