using System;

namespace Calculatorapp
{
    public class Splitter
    {
        public static string[] SplitOperation(string equation)
        {
            string[] problem = equation.Split(' ');
            return problem;
             
        }

    }
}
