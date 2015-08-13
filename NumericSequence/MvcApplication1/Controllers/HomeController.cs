using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumberSequence.Models; 

namespace NumberSequence.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
                        
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetNumericSequenceValues(int uservalue)
        {

            SequenceNumeric Seq_Num = new SequenceNumeric();
                        
            var numbers = Seq_Num.Numbers(uservalue );
            var odd_numbers = Seq_Num.OddNumbers(uservalue);
            var even_numbers = Seq_Num.EvenNumbers(uservalue);
            var custom_numbers = Seq_Num.CustomNumbers(uservalue);
            var fibonacci_numbers = Seq_Num.FibonacciNumbers(uservalue);
            return Json(new { numbers = numbers, oddnumbers=odd_numbers,evennumbers=even_numbers,customnumbers=custom_numbers,fibonaccinumbers=fibonacci_numbers,message="success"  });
        }

    }
}
