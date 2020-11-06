using Xunit;
using RomanNumeral_App;

namespace RomanNumeral_Tests
{
  public class ValidatorTests
  {
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