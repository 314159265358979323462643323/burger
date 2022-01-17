using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WilliamToddSite.Models;

namespace WilliamToddSite.Controllers
{
    public class ReferencesController : Controller
    {
        
        private readonly ILogger<ReferencesController> _logger;

        public ReferencesController(ILogger<ReferencesController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Links()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}