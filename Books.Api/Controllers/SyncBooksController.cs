using System;
using System.Threading.Tasks;
using Books.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    [Route("api/syncbooks")]
    [ApiController]
    public class SyncBooksController: ControllerBase
    {

        private readonly IBookRepository _bookRepository;

        public SyncBooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository
                ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var bookEntities = _bookRepository.GetBooksAsync();
            return Ok(bookEntities);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBook(Guid id)
        {
            var bookEntity = _bookRepository.GetBookAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }

            return Ok(bookEntity);
        }
        
    }
}