using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin_0306181111.Data;
using WebApp.Areas.Admin_0306181111.Models;

namespace WebApp.Areas.Admin_0306181111.Controllers
{
    [Area("Admin_0306181111")]
    public class PostController : Controller
    {
        private readonly DPContext _context;

        public PostController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin_0306181111/Post
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Post.Include(p => p.Category);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin_0306181111/Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
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

        // GET: Admin_0306181111/Post/Create
        public IActionResult Create()
        {
            //ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory");
            ViewBag.ListCategory = _context.Category.ToList();
            return View();
        }

        // POST: Admin_0306181111/Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPost,Img,Title,Description,Content,Author,CategoryID")] PostModel postModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", postModel.IDPost + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                postModel.Img = postModel.IDPost + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(postModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDPost", "IDCategory", postModel.Category);
            return View(postModel);
        }

        // GET: Admin_0306181111/Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post.FindAsync(id);
            if (postModel == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory", postModel.CategoryID);
            return View(postModel);
        }

        // POST: Admin_0306181111/Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPost,Img,Title,Description,Content,Author,CategoryID")] PostModel postModel, IFormFile ful)
        {
            if (id != postModel.IDPost)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postModel);
                    if (ful != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", postModel.Img);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", postModel.IDPost + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        postModel.Img = postModel.IDPost + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        _context.Update(postModel);
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostModelExists(postModel.IDPost))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDPost", "IDCategory", postModel.Category);
            return View(postModel);
        }

        // GET: Admin_0306181111/Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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

        // POST: Admin_0306181111/Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postModel = await _context.Post.FindAsync(id);
            _context.Post.Remove(postModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostModelExists(int id)
        {
            return _context.Post.Any(e => e.IDPost == id);
        }
    }
}
