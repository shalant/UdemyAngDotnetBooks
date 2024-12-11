using Microsoft.AspNetCore.Mvc;
using BookApi.Models;

namespace BookApi.Controllers
{
    //https://localhost:1234/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //for private fields use an underscore
        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Author = "John", Title = "Book One"},
            new Book { Id = 2, Author = "Betty", Title = "Book Two"},
            new Book { Id = 3, Author = "Trini", Title = "Book Three"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
