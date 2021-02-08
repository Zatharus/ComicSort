using System;
using System.Collections.Generic;
using System.Text;

namespace ComicSort.Data.Models
{
    public class Books
    {
        public Guid Id { get; set; }
        public string File { get; set; }
        public string Series { get; set; }
        public string Title { get; set; }
        public float Number { get; set; }
        public string Volume { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Writer { get; set; }
        public string Penciller { get; set; }
        public string Inker { get; set; }
        public string Colorist { get; set; }
        public string Letterer { get; set; }
        public string CoverArtist { get; set; }
        public string Publisher { get; set; }
        public string Web { get; set; }
        public int PageCount { get; set; }
        public string Characters { get; set; }
        public string CustomValues { get; set; }

    }
}
