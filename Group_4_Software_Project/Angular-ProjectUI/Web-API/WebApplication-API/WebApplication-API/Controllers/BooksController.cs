using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_API.Data;
using WebApplication_API.Models;

namespace WebApplication_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly WebApiDbContext _webApiDbContext;

        public BooksController(WebApiDbContext webApiDbContext)
        {
            _webApiDbContext = webApiDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _webApiDbContext.Books.ToListAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book bookRequest)
        {
            bookRequest.ID = Guid.NewGuid();

            await _webApiDbContext.Books.AddAsync(bookRequest);
            await _webApiDbContext.SaveChangesAsync();

            return Ok(bookRequest);


        }
        [HttpGet]
        [Route("{id:Guid}")]

        public async Task<IActionResult> GetBook([FromRoute] Guid id)
        {
            var book = await _webApiDbContext.Books.FirstOrDefaultAsync(x => x.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);

        }
        [HttpPut]
        [Route("{id:Guid}")]

        public async Task<IActionResult> UpdateBook([FromRoute] Guid id, Book updateBookRequest)
        {
            var book = await _webApiDbContext.Books.FindAsync(id);  

            if (book == null)
            {
                return NotFound();

            }

            book.Title = updateBookRequest.Title;
            book.Author = updateBookRequest.Author;
            book.Publisher = updateBookRequest.Publisher;
            book.Genre = updateBookRequest.Genre;   
            book.Author_Email = updateBookRequest.Author_Email; 
            book.Published_Year = updateBookRequest.Published_Year;
            book.Edition = updateBookRequest.Edition;
            book.Language = updateBookRequest.Language; 
            book.Price = updateBookRequest.Price;

            await _webApiDbContext.SaveChangesAsync();
            return Ok(book);

        }

        [HttpDelete]
        [Route("{id:Guid}")]

        public async Task<IActionResult> DeleteBook([FromRoute] Guid id) 
        { 
            var book = await _webApiDbContext.Books.FindAsync(id);

            if(book == null)
            {
                return NotFound();
            }
            
            _webApiDbContext.Books.Remove(book);
            await _webApiDbContext.SaveChangesAsync();

            return Ok(book);
        }
        
    }
}
    

