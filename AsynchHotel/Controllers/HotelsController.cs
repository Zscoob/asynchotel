using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsynchHotel.Controllers
{
    public class Class HotelsController : Controller
    {
        public IActionResult Index()
         {
        return View();
         }
    }
}

