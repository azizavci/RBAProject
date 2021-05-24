using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBAProject.Controllers
{
    public class Rentals2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
