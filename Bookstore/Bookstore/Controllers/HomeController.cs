//using Bookstore.Models;
using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string bookCategory, int pageNum = 1)
        {
            //Determine the number of Books on a page
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == bookCategory || bookCategory == null) //Helps sort by category when selected by user
                .OrderBy(b => b.Title) // Orders all displayed Books in alphabetical order
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                BookInfo = new BookInfo
                {
                    //Gets inmportant Book info - If no category gets info for all books, other wise info is filtered by the selected category
                    TotalNumBooks = (bookCategory == null
                        ? repo.Books.Count() : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            
            return View(x);
        }
    }
}
