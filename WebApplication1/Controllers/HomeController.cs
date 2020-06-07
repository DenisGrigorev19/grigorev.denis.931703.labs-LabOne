using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManualParsingInSingle()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                Numbers numbers = new Numbers();
                numbers.num1 = Int32.Parse(Request.Form["num1"]);
                numbers.num2 = Int32.Parse(Request.Form["num2"]);
                numbers.operation = Request.Form["operation"];
                numbers.Count();
                return View("Result", numbers);
            }
            else return View();
        }

        [HttpGet]
        public IActionResult ManualParsingInSeparate()
        {
            return View();
        }

        [HttpPost, ActionName("ManualParsingInSeparate")]
        public IActionResult ManualParsingInSeparatePost()
        {
            Numbers numbers = new Numbers();
            numbers.num1 = Int32.Parse(Request.Form["num1"]);
            numbers.num2 = Int32.Parse(Request.Form["num2"]);
            numbers.operation = Request.Form["operation"];
            numbers.Count();
            return View("Result", numbers);
        }

        [HttpGet]
        public IActionResult ModelBindingInParams()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelBindingInParams(int num1, int num2, string operation)
        {
            Numbers numbers = new Numbers();
            numbers.num1 = num1;
            numbers.num2 = num2;
            numbers.operation = operation;
            numbers.Count();
            return View("Result", numbers);
        }

        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(Numbers numbers)
        {
            numbers.Count();
            return View("Result", numbers);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
