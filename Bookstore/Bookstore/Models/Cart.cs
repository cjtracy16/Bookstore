using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Bookstore.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>(); // Declaration & Instantiation

        public void AddItem(Book book, int qty)
        {
            //Get the specific book selected based off bookID
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            //if the Book isn't in cart (is null) then create a new line item
            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            //Otherwise increase the qty for that Book
            else
            {
                line.Quantity += qty;
            }
        }
        //Function to create the subtotal for all items in the cart
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

    //Create Instance of a line item - creates variables
    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
