using System.ComponentModel;
using static System.Math;

namespace E1_Calculator
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Power(double x, double exp)
        {
            return Pow(x, exp);
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}