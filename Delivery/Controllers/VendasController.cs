using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}