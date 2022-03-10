using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        //Edit
        public void SaveBook(Book b);
        //Create
        public void CreateBook(Book b);
        //Delete
        public void DeleteBook(Book b);
    }
}
