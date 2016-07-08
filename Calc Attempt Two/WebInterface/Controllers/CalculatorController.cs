using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calc_Attempt_Two.Functions_with_two_operators;

namespace WebInterface.Controllers
{
    public class CalculatorController : Controller
    {
        private SelectListItem[] Operations = 
            {
                new SelectListItem { Text = "Сложение", Value = "button1", Selected = true },
                new SelectListItem { Text = "Вычитание", Value = "button2"},
                new SelectListItem { Text = "Умножение", Value = "button3"},
                new SelectListItem { Text = "Деление", Value = "button4"},
                new SelectListItem { Text = "Возведение в степень", Value = "button8"},
                new SelectListItem { Text = "Крутой корень", Value = "button14"},
            };
        // GET: Calculator
        public ActionResult Index()
        {
            ViewBag.Operations = Operations;
            return View();
        }
        [HttpPost]
        public ActionResult Index(double firstOperator, double secondOperator, string operation)
        {
            ITwoOperatorsCalculator calculator = TwoOperatorsFactory.CreateCalculator(operation);
            ViewBag.result = calculator.Calculate(firstOperator, secondOperator);
            ViewBag.Operations = Operations;
            return View();

        }
    }
}