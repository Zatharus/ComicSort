using ComicSort.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicSort.EntityFramework
{
    public class ComicDatabaseDBContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
