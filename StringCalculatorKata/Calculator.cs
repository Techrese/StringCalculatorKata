using System;
using System.Security.Cryptography.X509Certificates;

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
                        
            string[] numbers = input.Split(new char[] { ',', '\n' });

            int result;
            if (numbers.Length > 1 && !int.TryParse(numbers[0], out result))
            {
                numbers = numbers[1].Split(numbers[0]);
            }            

            int sum = 0;
            foreach (var number in numbers)
            {
                if (!String.Empty.Equals(number))
                {
                    sum += Convert.ToInt32(number);
                }
            }
            return sum;
        }
    }
}
