using System;

namespace Calculatorapp
{
    public class Interpret
    {
        private int valueA;
        private int valueB;
        private string operand;
        public int Operate(string[] problem)
        {
            valueA = Convert.ToInt32(problem[0]);
            operand = problem[1];
            valueB = Convert.ToInt32(problem[2]);

            return OpCheck();
        }

        public int OpCheck()
        {
            if (operand == "+")
            {
                return valueA + valueB;
            }
            else if (operand == "-")
            {
                return valueA - valueB;
            }
            else if (operand == "*")
            {
                return valueA * valueB;
            }
            else if (operand == "/")
            {
                return valueA / valueB;
            }
            else
            {
                Console.WriteLine("Equation Not Valid");
                return 0;
            }
        }
    }
}
