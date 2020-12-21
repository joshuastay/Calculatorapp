using System;

namespace Calculatorapp
{
    public class CalculateOOO
    {
        private Interpret _interpreter = new Interpret();
        private StringUpdate _updater = new StringUpdate();
        private string[] tempArray;
        private int tempSolution;
        public int Calculation(string[] problem)
        {
            tempArray = problem;
            while (tempArray.Length > 1)
            {
                tempSolution = _interpreter.OperationOrder(tempArray);
                tempArray = _updater.Updater(tempArray, _interpreter.operandIndex, tempSolution);
            }
            return _interpreter.OperationOrder(tempArray);
        }
    }
}
