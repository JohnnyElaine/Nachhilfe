using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibrary
{
    public class Book : Item
    {

        protected string author;
        protected Category category;
        protected string isbn;

        public Book(string title, string author, string isbn, Category category, int stock, decimal price) : base(title, stock, price)
        { 
            this.author = author;
            this.isbn = isbn;
            this.category = category;
        }

        public override bool IsFromAuthor(string author)
        {
            return this.author.ToLower().Contains(author.ToLower());
        }

        public override void ReorderItem()
        {
            if (stock < 10) Purchase(20);
        }

        public override string ToString()
        {
            return $"Book: {title}, {price}€, {stock} int stock, {author} {isbn} {category.ToString()}";
        }
    }
}
