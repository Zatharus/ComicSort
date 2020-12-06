using ComicSort.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicSort.EntityFramework
{
    public class ComicSortDBContext : DbContext
    {
        private const string FILENAME = "Libraries.db";
        private static string _applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string _applicationPath = Path.Combine(_applicationDataPath, "ComicSort");
        public string ConnectionString { get; } = "DataSource=" + Path.Combine(_applicationPath, FILENAME);


        public DbSet<Libraries> Libraries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
