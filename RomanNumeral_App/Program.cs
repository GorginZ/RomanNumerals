using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral_App
{
  public class Program
  {
    static void Main(string[] args)
    {
      ReturnNumberComponents(24);
    }

    public static string ConvertToRomanNumeral(List<int> numbers)
    {
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


    public static List<int> ReturnNumberComponents(int number)
    {
      List<int> allRomanNumeralValues = new List<int> { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
      List<int> potentialValues = new List<int>();

      List<int> resultValues = new List<int>();

      //find list of values less than the number
      foreach (int value in allRomanNumeralValues)
      {
        if (value <= number)
        {
          potentialValues.Add(value);
        }
      }
      //finding the numeral component we want to use
      //we want to look at the last number of the array
      while (number != 0)
      {
        resultValues.Add(potentialValues.Last());
        Console.WriteLine(potentialValues.Last());
        number = number - potentialValues.Last();

        //update relevantNumbers
        potentialValues = potentialValues.Where(x => x <= number).ToList();

      }
      Console.WriteLine(resultValues.ToString());
      return resultValues;
    }


  }
}
