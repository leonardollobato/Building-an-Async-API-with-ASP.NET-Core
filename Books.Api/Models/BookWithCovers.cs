using System.Collections.Generic;

namespace Books.Api.Models
{
    public class BookWithCovers:Book
    {
       public IEnumerable<Models.BookCover> BookCovers { get; set; } = new List<Models.BookCover>();
    }
}