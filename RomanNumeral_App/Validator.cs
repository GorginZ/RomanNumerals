namespace RomanNumeral_App
{
    public static class Validator
    {
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