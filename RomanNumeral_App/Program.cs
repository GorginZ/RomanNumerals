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
          var validationStatus = Validator.CheckInput(userInput);
          while (validationStatus == Validation.Invalid)
          {
            Console.WriteLine("Can only represent numbers between 1 and 3999. Try another number!");
            userInput = Console.ReadLine();
           
          }
            NumeralConverter.ConvertToRomanNumeral(userInput);
        }

    
    
    }
}
