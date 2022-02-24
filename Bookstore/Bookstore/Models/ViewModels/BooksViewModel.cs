using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    //Create Variables to be passed through ViewModels
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public BookInfo BookInfo { get; set; }
    }
}
