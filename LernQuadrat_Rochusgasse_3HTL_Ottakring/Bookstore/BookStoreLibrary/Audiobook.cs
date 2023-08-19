using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibrary
{
    public class Audiobook : Book
    {
        private int duration;

        public Audiobook(string title, string author, string isbn, Category category, int stock, decimal price, int duration) : base (title, author, isbn, category, stock, price)
        {
            if (duration < 0) throw new ArgumentException("Duration can not be < 0");

            this.duration = duration;
        }

        public override string ToString()
        {
            return $"Audiobook: {title}, {price}€, {stock} int stock, {author} {isbn} {category.ToString()} {duration} min";
        }
    }
}
