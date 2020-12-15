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

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += Convert.ToInt32(number);
            }
            return sum;
        }
    }
}