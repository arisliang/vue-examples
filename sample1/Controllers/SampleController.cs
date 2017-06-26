using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Sample1()
        {
            // binding and filtering
            return View();
        }

        public IActionResult Sample2()
        {
            // toggle visibility
            return View();
        }

        public IActionResult Sample3()
        {
            // event handling
            return View();
        }
    }
}
