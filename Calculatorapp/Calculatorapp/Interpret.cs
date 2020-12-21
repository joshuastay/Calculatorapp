using System;

namespace Calculatorapp
{
    public class Interpret
    {
        private int valueA;
        private int valueB;
        private string operand;
        public int operandIndex;
        private int solution;
        private string[] tempProblem = new string[3];
        private bool multiplyCheck;
        private bool divideCheck;
        private bool addCheck;
        private bool subtractCheck;

        public int Operate(string[] problem)
        {
            valueA = Convert.ToInt32(problem[0]);
            operand = problem[1];
            valueB = Convert.ToInt32(problem[2]);

            solution = OpCheck();

            return solution;
        }

        public int OperationOrder(string[] problem)
        {
            multiplyCheck = finderIndexer(problem, "*");

            if (!multiplyCheck)
            {
                divideCheck = finderIndexer(problem, "/");

                if (!divideCheck)
                {
                    addCheck = finderIndexer(problem, "+");

                    if (!addCheck)
                    {
                        subtractCheck = finderIndexer(problem, "-");

                        if (operandIndex < 0)
                        {
                            return solution;
                        }
                    }
                }
            }
            return Operate(tempProblem);
        }

        public bool finderIndexer(string[] problem, string item)
        {
            operandIndex = Array.IndexOf(problem, item);

            if (operandIndex < 0)
            {
                return false;
            }
            else
            {
                tempProblem[0] = problem[operandIndex - 1];
                tempProblem[1] = problem[operandIndex];
                tempProblem[2] = problem[operandIndex + 1];

                return true;
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
