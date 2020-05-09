using Microsoft.AspNetCore.Mvc;
using System;

namespace SquareRoot.Controllers
{
    public class SqrRootController : Controller
    {
        [HttpGet]
        public ActionResult Sqr()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqr(string firstNumber, string secondNumber)
        {
            ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber = secondNumber;

            int Num1 = 0;
            bool Converted1 = int.TryParse(firstNumber, out Num1);

            int Num2 = 0;
            bool Coverted2 = int.TryParse(secondNumber, out Num2);

            double Sqrt1 = Math.Sqrt(Num1);
            double Sqrt2 = Math.Sqrt(Num2);

            ViewBag.Result1 = Sqrt1;
            ViewBag.Result2 = Sqrt2;

            ViewBag.Num1 = Num1;
            ViewBag.Num2 = Num2;

            return View();
        }
    }
}