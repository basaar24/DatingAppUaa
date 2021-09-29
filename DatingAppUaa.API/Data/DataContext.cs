﻿using DatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppUaa.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
