﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base (options){ }
       

        public DbSet<Slider> Sliders { get; set; }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Say> Says { get; set; }

        public DbSet<Instagram> Instagrams { get; set; }

        public DbSet<Category> Categories { get; set; }

        

        
    }
}
