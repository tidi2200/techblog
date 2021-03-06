﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin_0306181111.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public PostAPIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/<PostAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PostAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<PostAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
