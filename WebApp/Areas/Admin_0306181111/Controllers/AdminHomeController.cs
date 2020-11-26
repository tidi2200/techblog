using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin_0306181111.Controllers
{
    public class AdminHomeController : Controller
    {
        [Area("Admin_0306181111")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
