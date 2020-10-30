using System;
using Xunit;
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
           var numeral = Program.ConvertToRomanNumeral(5);
           Assert.Equal(RomanNumeral.V.ToString(), numeral);
        }
    }
}
