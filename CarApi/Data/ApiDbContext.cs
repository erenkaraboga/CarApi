﻿using CarApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Data
{
    public class ApiDbContext : DbContext
    {
       
        public DbSet<Brand> Brands { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {


        }
       
     
    }
}
