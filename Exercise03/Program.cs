using System;
using Exercise02;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
                Console.WriteLine("Enter a Number to convert to words");
                string number = Console.ReadLine();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    Console.WriteLine("The number in word format is \nZero Only");
                }
                else
                {
                    Console.WriteLine("The number in word fomat is \n{0}", isNegative + NumtoWords.ConvertToWords(number));
                    //numToWords.
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
