using RomanNumeral.Interface;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeral.Service
{
    public class RomanNumeralConversion : IRomanNumeralConversion
    {

       Dictionary<int, string> RomanNumeralsDictionary = new Dictionary<int, string>()
       {
           { 1000, "M" },
           { 900, "CM" },
           { 500, "D" },
           { 400, "CD" },
           { 100, "C" },
           { 90, "XC" },
           { 50, "L" },
           { 40, "XL" },
           { 10, "X" },
           { 9, "IX" },
           { 5, "V" },
           { 4, "IV" },
           { 1, "I" },
       };

        public string GetRomanNumeralFromNumber(int numberToConvert)
        {
            if (numberToConvert <= 0 || numberToConvert > 2000)
                return "Invalid value entered, must be a number between 1 and 2000";
            
            var romanNumerals = new StringBuilder();

            foreach (var item in RomanNumeralsDictionary)
            {
                while (numberToConvert >= item.Key)
                {
                    romanNumerals.Append(item.Value);
                    numberToConvert -= item.Key;
                }
            }

            return romanNumerals.ToString();
        }      

    }
}
