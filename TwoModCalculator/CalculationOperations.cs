using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoModCalculator
{
    class CalculationOperations
    {
        public static double Sum(double first_operator, double second_operator)
        {
            return first_operator + second_operator;
        }

        public static double Subtraction(double first_operator, double second_operator)
        {
            return first_operator - second_operator;
        }

        public static double Multiplication(double first_operator, double second_operator)
        {
            return first_operator * second_operator;
        }

        public static double Division(double first_operator, double second_operator)
        {
            return first_operator / second_operator;
        }

        public static double SquareRoot(double first_operator)
        {
            return System.Math.Sqrt(first_operator);
        }

        public static double Absolute(double first_operator)
        {
            return System.Math.Abs(first_operator);
        }

        public static double Pow(double first_operator, double second_operator)
        {
            return System.Math.Pow(first_operator, second_operator);
        }

        public static double Tan(double first_operator)
        {
            return System.Math.Tan(first_operator);
        }

        public static double Sin(double first_operator)
        {
            return System.Math.Sin(first_operator);
        }

        public static double Cos(double first_operator)
        {
            return System.Math.Cos(first_operator);
        }

        public static double Exp(double first_operator)
        {
            return System.Math.Exp(first_operator);
        }
    }
}
