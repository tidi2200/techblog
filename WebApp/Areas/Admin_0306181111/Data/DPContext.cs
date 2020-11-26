﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin_0306181111.Models;

namespace WebApp.Areas.Admin_0306181111.Data
{
    public class DPContext:DbContext
    {
        public DPContext(DbContextOptions<DPContext> options):base (options)
        {

        }

        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<PostModel> Post { get; set; }
    }
}
