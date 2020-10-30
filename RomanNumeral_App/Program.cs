using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConvertToRomanNumeral(5);
        }

        public static string ConvertToRomanNumeral(int number)
        {
            var resultNumerals = "";

            var romanList = Enum.GetValues(typeof(RomanNumeral));
            foreach (RomanNumeral numeral in romanList)
            {
                var intNumeral = (int)numeral;
                if (intNumeral == number)
                {
                    resultNumerals += numeral.ToString();
                }
            }

            return resultNumerals;
        }
    }
}
