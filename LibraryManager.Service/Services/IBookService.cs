using LibraryManager.Service.Models;
using System.Collections.Generic;

namespace LibraryManager.Service.Services
{
    //This Interface need to be implemented.
    public interface IBookService
    {
        IEnumerable<Book> GetAllAvailableBooks();

        Book GetBookDetails(int id);

        bool UpdateBookDetails(int id, Book book);

        int AddBook(Book book);

        bool IssueBooks(Dictionary<int, int> issueDetails);

        bool ReturnBooks(Dictionary<int, int> returnDetails);
    }
}
