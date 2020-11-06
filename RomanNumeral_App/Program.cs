using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral_App
{
  public class Program
  {
    static void Main(string[] args)
    {

      bool running = true;

      while (running)
      {
        Console.WriteLine("Roman Numeral Converter. Enter a number between 1 and 3999 to see it as a numeral!");
        var userInput = Console.ReadLine();
        var validationStatus = Validator.CheckInput(userInput);
        RunConverter(userInput, validationStatus);
        running = SetRunning();
        //ask continue and set 'running'?
      }
    }

    public static void RunConverter(string userInput, Validation validationStatus)
    {
      while (validationStatus == Validation.Invalid)
      {
        Console.WriteLine("Can only represent numbers between 1 and 3999. Try another number!");
        userInput = Console.ReadLine();
        validationStatus = Validator.CheckInput(userInput);
      }
      var resultNumeral = NumeralConverter.ConvertToRomanNumeral(userInput);
      Console.WriteLine($"{userInput} in Roman Numeral representation is {resultNumeral}");
    }

    public static bool SetRunning()
    {
      Console.WriteLine("Continue Y/N");
      var userResponse = Console.ReadLine().ToUpper();
      if (userResponse == "Y")
      {
        return true;

      }
      else
      {
        return false;
      }
    }

  }
}
