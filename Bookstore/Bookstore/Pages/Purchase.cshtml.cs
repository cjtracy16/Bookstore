using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Infrastructure;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore.Pages
{

    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public PurchaseModel(IBookstoreRepository temp)
        {
            repo = temp;
        }

        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }

        //Pass the returnUrl to the Cart page so that a user can continue shopping
        public void OnGet(string returnUrl)
        {
            //if there is not returnURL send them to the home page
            ReturnUrl = returnUrl ?? "/";
            //pass in the session data
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            //pass in the session data
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            //Add the specific book to the cart and pass it's data
            cart.AddItem(b, 1);

            HttpContext.Session.SetJson("cart", cart);
            //using the returnUrl to return to previous page
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
