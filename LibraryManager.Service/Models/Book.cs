using System;

namespace LibraryManager.Service.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public int TotalCount { get; set; }
        public int AvailableCount { get; set; }
    }
}
