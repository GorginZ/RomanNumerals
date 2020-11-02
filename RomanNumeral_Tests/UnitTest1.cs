using System;
using Xunit;
using System.Collections.Generic;
using RomanNumeral_App;
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

namespace RomanNumeral_Tests
{
  public class UnitTest1
  {
    [Fact]
    public void CanConvertANumberToABaseNumeral()
    {
      var numbers = new List<int> { 10, 10, 4 };
      var numeral = Program.ConvertToRomanNumeral(numbers);
      //  XXIV
      var expected = RomanNumeral.X.ToString() + RomanNumeral.X.ToString() + RomanNumeral.IV.ToString();
      Assert.Equal(expected, numeral);
    }

    public void WillNotRepeatNumeralMoreThanThreeTimes()
    {

    }

    public void AllSubtractiveNumeralsCanOnlyAppearOnceInAnySequence()
    {

    }

    public void OnlyReprsentNumbersBetween1And3999(){

    }
    
  }
}
