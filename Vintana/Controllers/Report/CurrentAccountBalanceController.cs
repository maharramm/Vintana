using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vintana.Controllers.Report
{
    public class CurrentAccountBalanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
