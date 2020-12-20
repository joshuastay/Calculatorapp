using System;

namespace Calculatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpret();

            while (true)
            {
                Console.WriteLine("Enter a math problem: ");

                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                else
                {
                    int solution = interpreter.OperationOrder(Splitter.SplitOperation(input));
                    Console.WriteLine(solution);
                }

            }
        }
    }
}
