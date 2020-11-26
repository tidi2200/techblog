using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApp.Areas.Admin_0306181111.Data;
using WebApp.Areas.Admin_0306181111.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public CategoryAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<CategoryAPIController>
        [HttpGet]
        public async Task<string> GetCategoryAsync(int id)
        {
            CategoryModel categoryModel = await _context.Category
                .FirstOrDefaultAsync(m => m.IDCategory == id);
            return JsonConvert.SerializeObject(categoryModel);
        }
        //[HttpGet]
        //public string GetCategory(int id)
        //{

        //}

        // GET api/<CategoryAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
