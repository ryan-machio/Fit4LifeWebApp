using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fit4Life_WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Fit4Life_WebApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}