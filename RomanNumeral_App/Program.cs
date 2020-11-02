using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral_App
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");
      // ConvertToRomanNumeral(5);
      ReturnNumberComponents(24);
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

    //base numerals
    // Number	Numeral	Words
    // 1	I	one
    // 5	V	five
    // 10	X	ten
    // 50	L	fifty
    // 100	C	one hundred
    // 500	D	five hundred
    // 1000	M	one thousand

    //subtractive (one less)
    // Number	Numeral	Words
    // 4	IV	four
    // 9	IX	nine
    // 40	XL	forty
    // 90	XC	ninety
    // 400	CD	four hundred
    // 900	CM	nine hundred

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
