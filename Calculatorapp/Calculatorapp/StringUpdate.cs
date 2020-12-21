using System;
using System.Collections.Generic;

namespace Calculatorapp
{
    public class StringUpdate
    {
        private List<string> tempList = new List<string>();
        private int counter;

        public string[] Updater(string[] problem, int reference, int solution)
        {
            tempList.Clear();
            counter = 0;

            foreach (string value in problem)
            {
                if (counter == reference - 1)
                {
                    tempList.Add(Convert.ToString(solution));
                    counter++;
                    continue;
                }
                else if (counter == reference || counter == reference + 1)
                {
                    counter++;
                    continue;
                }
                else
                {
                    counter++;
                    tempList.Add(value);
                    continue;
                }
            }

            return tempList.ToArray();
        }
    }
}