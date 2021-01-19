using LibraryManager.Service.Models;
using LibraryManager.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManager.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IBookService BookService { get; set; }

        public BooksController(IBookService bookService)
        {
            this.BookService = bookService;
        }

        [Route("all")]
        public IEnumerable<Book> GetAllAvailableBooks()
        {
            return this.BookService.GetAllAvailableBooks();
        }

        [Route("{id}/details")]
        public Book GetBookDetails(int id)
        {
            return this.BookService.GetBookDetails(id);
        }

        [Route("add")]
        public int PostBook(Book book)
        {
            return this.BookService.AddBook(book);
        }

        [Route("{id}/update")]
        public bool PutBookDetails(int id, [FromBody]Book book)
        {
            return this.BookService.UpdateBookDetails(id, book);
        }

        [Route("issue")]
        public bool PutIssueBooks([FromBody]Dictionary<int, int> issueDetails)
        {
            return this.BookService.IssueBooks(issueDetails);
        }

        [Route("return")]
        public bool PutReturnBooks([FromBody]Dictionary<int, int> returnDetails)
        {
            return this.BookService.ReturnBooks(returnDetails);
        }
    }
}
