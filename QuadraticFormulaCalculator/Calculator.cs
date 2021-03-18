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

    //Function for calculating the zeroes of a quadratic equation of the form a*x^2 + b*x + c = 0, where a, b, and c are real numbers
    //Returns an 3-value array of complex numbers. The real part of the first one indicates the number and type of solutions
    //0.0 Indicates 2 real solutions, 1.0 indicates 1 real solution, and 2.0 Indicates 2 complex solutions
    public static class Calculator
    {
        public static Complex[] Calculate(double a, double b, double c)
        {
            var results = new Complex[3];
            double discriminant = b * b - 4 * a * c;
            //Compare discriminant to determine number and types of solutions
            //Subtraction comparison is nessecary because of floating point imprecision
            if (0 - discriminant > 0.0000001)
                results[0] = new Complex(2.0, 0.0); //Discriminant is negative, therfore we have 2 complex solutions
            else if (0 - discriminant < -0.0000001)
                results[0] = new Complex(0.0, 0.0);  //Discriminant is positve, therefore we have 2 real solutions
            else //difference between discriminant and 0.0 is small enough that it is esentially zero
                results[0] = new Complex(1.0, 0.0); //Discriminant is zero, therefore we have 1 real solution
            results[1] = new Complex(2.0, 0.0);
            results[2] = new Complex(3.0, 0.0);
            return results;
        }
    }
    
}
