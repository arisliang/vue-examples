﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample2.Controllers
{
    public class VueSampleController : Controller
    {
        public IActionResult BasicDataBinding()
        {
            return View();
        }

        public IActionResult Lists()
        {
            return View();
        }

        public IActionResult AttributeBinding()
        {
            return View();
        }

        public IActionResult ComputedProperties()
        {
            return View();
        }

        public IActionResult Components()
        {
            return View();
        }
    }
}
