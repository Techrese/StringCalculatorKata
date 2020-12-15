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

            string[] numbers = input.Split(',');  
            


            if (numbers.Length == 2)
            {
                return Convert.ToInt32(numbers.GetValue(0)) + Convert.ToInt32(numbers.GetValue(1));
            }            

            return Convert.ToInt32(input);
        }
    }
}