using System.ComponentModel.DataAnnotations;

namespace RomanNumeral.Models
{
    public class RomanNumeralViewModel
    {
        [Display(Name = "Number to Convert")]
        [Range(1, 2000)]
        public int NumberToConvert { get; set; }

        [Display(Name = "Roman Numeral")]
        public string RomanNumeral { get; set; }
    }
}
