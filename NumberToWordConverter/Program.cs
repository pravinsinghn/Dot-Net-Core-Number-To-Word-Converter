using System;

namespace NumberToWordConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
                Console.WriteLine("**** enter number convert to words. Example 55 with fifty five. ****");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number < 0)
                {
                    isNegative = "minus ";
                    number = Math.Abs(number);
                }
                if (number == 0)
                    Console.WriteLine($"The number is :: zero only");
                else if (Math.Abs(number) <= 999999999)
                    Console.WriteLine($"The number is :: {isNegative + NumberToText.ConvertNumberToText(number.ToString())}");
                else
                    Console.WriteLine("Invalid number range. Number range should be from -999999999 to 999999999");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
