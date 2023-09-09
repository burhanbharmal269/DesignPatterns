﻿using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkMVCDemo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        public DbSet<Book> BooksTable { get; set; }
    }
}
