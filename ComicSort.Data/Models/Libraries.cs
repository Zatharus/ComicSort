using System;
using System.Collections.Generic;
using System.Text;

namespace ComicSort.Data.Models
{
    public class Libraries
    {
        public Guid Id { get; set; }
        public string LibraryName { get; set; }
        public string LibraryPath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastAccessed { get; set; }
    }
}
