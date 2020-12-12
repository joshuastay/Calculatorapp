using System;

namespace Calculatorapp
{
    public class Operation
    {
        public static int Sum(int valueA, int valueB)
        {
            return valueA + valueB;
        }

        public static int Difference(int valueA, int valueB)
        {
            return valueA - valueB;
        }

        public static int Product(int valueA, int valueB)
        {
            return valueA * valueB;
        }

        public static int Quotient(int valueA, int valueB)
        {
            return valueA / valueB;
        }
    }
}
