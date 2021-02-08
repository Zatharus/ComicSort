using System;
using System.Collections.Generic;
using System.Text;

namespace ComicSort.Data.Models
{
    public class ComicBook
    {
        public Guid Id { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime ReleasedTime { get; set; }
        public DateTime OpenedTime { get; set; }
        public int OpenedCount { get; set; }
        public int CurrentPage { get; set; }
        public int LastPageRead { get; set; }
        public float Rating { get; set; }
        public string Tags { get; set; }
        public bool EnabledProposed { get; set; }
        public bool EnableDynamicUpdate { get; set; }
        public Guid LastOpenedFromListId { get; set; }




    }
}
