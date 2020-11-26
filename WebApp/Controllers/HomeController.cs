using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApp.Areas.Admin_0306181111.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.listPost = _context.Post.ToList();
            ViewBag.listCategory = _context.Category.ToList();
            return View();
        }

        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.listPost = _context.Post.ToList();
            ViewBag.listCategory = _context.Category.ToList();

            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.IDPost == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }

        public async Task<IActionResult> Category(int? id)
        {
            ViewBag.listPost = _context.Post.ToList();
            ViewBag.listCategory = _context.Category.ToList();

            var list = from m in _context.Post select m;
            list = list.Where(m => m.CategoryID.Equals(id));


            return View(await list.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
