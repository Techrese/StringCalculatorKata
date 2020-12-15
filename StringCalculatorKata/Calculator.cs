using System;

namespace StringCalculatorKata
{
    class Calculator
    {
        public int Add(string input)
        {
            if (input == String.Empty)
            {
                return 0;
            }
            return Convert.ToInt32(input);
        }
    }
}