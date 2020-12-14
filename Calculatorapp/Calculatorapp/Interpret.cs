using System;

namespace Calculatorapp
{
    public class Interpret
    {
        private int valueA;
        private int valueB;
        private string operand;
        private int operandIndex;
        public int Operate(string[] problem)
        {
            operandIndex = Array.IndexOf(problem, "*");

            return operandIndex;


            
            
            
            //valueA = Convert.ToInt32(problem[0]);
            //operand = problem[1];
            //valueB = Convert.ToInt32(problem[2]);

            //return OpCheck();
        }
        public int OperationOrder(string[] problem)
        {
            operandIndex = Array.IndexOf(problem, "*");

            if (operandIndex < 0)
            {
                operandIndex = Array.IndexOf(problem, "/");

                if (operandIndex < 0)
                {
                    operandIndex = Array.IndexOf(problem, "+");

                    if (operandIndex < 0)
                    {
                        operandIndex = Array.IndexOf(problem, "-");
                        
                        if (operandIndex < 0)
                        {
                            return solution;
                        }
                    }
                }
            }
        }

        public int OpCheck()
        {
            if (operand == "+")
            {
                return Operation.Sum(valueA, valueB);
            }
            else if (operand == "-")
            {
                return Operation.Difference(valueA, valueB);
            }
            else if (operand == "*")
            {
                return Operation.Product(valueA, valueB);
            }
            else if (operand == "/")
            {
                return Operation.Quotient(valueA, valueB);
            }
            else
            {
                Console.WriteLine("Equation Not Valid");
                return 0;
            }
        }
    }
}
