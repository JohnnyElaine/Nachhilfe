using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibrary
{
    public class Newspaper : Item
    {
        private List<string> authors;
        private DateTime dateOfIssue;

        public Newspaper(string title, int stock, decimal price, DateTime date, List<string> authors) : base(title, stock, price)
        {
            this.dateOfIssue = date;
            this.authors = authors;
        }

        public override bool IsFromAuthor(string author)
        {
            return authors.Contains(author);
        }

        public override string ToString()
        {
            return $"Newspaper: {title}, {price}€, {stock} int stock, {dateOfIssue}";
        }
    }
}
