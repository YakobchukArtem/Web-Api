﻿using Microsoft.EntityFrameworkCore;
using CodePulse.API.Models.Domain;
namespace CodePulse.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
