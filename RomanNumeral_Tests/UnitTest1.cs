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
      var number = "24";
      var numeral = NumeralConverter.ConvertToRomanNumeral(number);
      var expected = RomanNumeral.X.ToString() + RomanNumeral.X.ToString() + RomanNumeral.IV.ToString();
      Assert.Equal(expected, numeral);
    }

    [Theory]
    [InlineData("40", RomanNumeral.XL)]
    [InlineData("400", RomanNumeral.CD)]
    public void WillNotRepeatNumeralMoreThanThreeTimes(string number, RomanNumeral expectedNumeral)
    {
      var actualNumeral = NumeralConverter.ConvertToRomanNumeral(number);
      var expectedNumeralString = expectedNumeral.ToString();
      Assert.Equal(expectedNumeralString, actualNumeral);
    }

    [Fact]
    public void BaseNumeralsCanBeRepresentedUpToThreeTime()
    {
      var number = "300";
      var actualNumeral = NumeralConverter.ConvertToRomanNumeral(number);
      var expectedNumeral =RomanNumeral.C.ToString() + RomanNumeral.C.ToString() + RomanNumeral.C.ToString();
      Assert.Equal(expectedNumeral, actualNumeral);
    }

    [Fact]
    public void AllSubtractiveNumeralsCanOnlyAppearOnceInAnySequence()
    {
      var number = "8";
      var actualNumeral = NumeralConverter.ConvertToRomanNumeral(number);
      var expectedNumeral = RomanNumeral.V.ToString() + RomanNumeral.I.ToString() + RomanNumeral.I.ToString() + RomanNumeral.I.ToString();
      Assert.Equal(expectedNumeral, actualNumeral);
    }

    [Theory]
    [InlineData("0", Validation.Invalid)]
    [InlineData("3999", Validation.Valid)]
    public void OnlyRepresentNumbersBetween1And3999(string number, Validation expected)
    {
      var actualValidation = Validator.CheckInput(number);
      Assert.Equal(expected, actualValidation);
    }
    
  }
}
