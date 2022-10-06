using Microsoft.AspNetCore.Mvc;
using RomanNumeral.Interface;
using RomanNumeral.Models;

namespace RomanNumeral.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRomanNumeralConversion _romanNumeralConversion;

        public HomeController(IRomanNumeralConversion romanNumeralConversion)
        {
            _romanNumeralConversion = romanNumeralConversion;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int numberToConvert)
        {
            var romanModel = new RomanNumeralViewModel();
            romanModel.NumberToConvert = numberToConvert;

            if (numberToConvert <= 0 || numberToConvert > 2000)
                ModelState.AddModelError("NumberToConvert", "Invalid value entered, must be a number between 1 and 2000");
            else
            {
                var convertedNumber = _romanNumeralConversion.GetRomanNumeralFromNumber(numberToConvert);
                romanModel.RomanNumeral = convertedNumber;
            }

            return View(romanModel);
        }

    }
}
