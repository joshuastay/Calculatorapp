using System;

namespace Calculatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpret();

            Console.WriteLine("Enter a math problem: ");

            string input = Console.ReadLine();

            int solution = interpreter.Operate(Splitter.SplitOperation(input));

            Console.WriteLine(solution);
        }
    }
}
