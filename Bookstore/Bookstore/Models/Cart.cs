using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Bookstore.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>(); // Declaration & Instantiation

        public virtual void AddItem(Book book, int qty)
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

        //This allows user to remove a book from their cart
        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        //Allows user to empty they entire cart
        public virtual void ClearCart()
        {
            Items.Clear();
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
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
