using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral_App
{
    public class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Roman Numeral Converter. Enter a number between 1 and 3999 to see it as a numeral!");
          var userInput = Console.ReadLine();
          var validationStatus = CheckInput(userInput);
          while (validationStatus == Validation.Invalid)
          {
            Console.WriteLine("Can only represent numbers between 1 and 3999. Try another number!");
            userInput = Console.ReadLine();
           
          }
            ConvertToRomanNumeral(userInput);
        }

        public static string ConvertToRomanNumeral(string input)
        {
          int inputNumber = int.Parse(input);
            var numbers = GetNumeralNumberComponents(inputNumber);
            var resultNumerals = "";
            foreach (int number in numbers)
            {
                var romanList = Enum.GetValues(typeof(RomanNumeral));
                foreach (RomanNumeral numeral in romanList)
                {
                    var intNumeral = (int)numeral;
                    if (intNumeral == number)
                    {
                        resultNumerals += numeral.ToString();
                    }
                }

            }
            return resultNumerals;

        }

        public static List<int> GetNumeralNumberComponents(int number)
        {
            List<int> allRomanNumeralValues = new List<int> { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            List<int> potentialValues = new List<int>();

            List<int> resultValues = new List<int>();

            foreach (int value in allRomanNumeralValues)
            {
                if (value <= number)
                {
                    potentialValues.Add(value);
                }
            }
            while (number != 0)
            {
                resultValues.Add(potentialValues.Last());
                number = number - potentialValues.Last();
                potentialValues = potentialValues.Where(x => x <= number).ToList();
            }
            return resultValues;
        }

        public static Validation CheckInput(string input)
        {
            var isInt = int.TryParse(input, out int number);
            if (number <= 0 || number > 3999)
            {
                return Validation.Invalid;
            }
            else
            {
                return Validation.Valid;
            }
        }
    }
}
