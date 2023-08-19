namespace BookStoreLibrary
{
    public class Item
    {
        protected string title;
        protected decimal price;
        protected int stock;

        public string Title
        {
            get { return title; }
        }
        

        public Item(string title, int stock, decimal price)
        {
            if (stock < 0) throw new ArgumentException("Stock can not be < 0");
            if (price < 0) throw new ArgumentException("Price can not be < 0");
            if (title.Length <= 0) throw new ArgumentException("Title cannot be empty");

            this.title = title;
            this.stock = stock;
            this.price = price;
        }

        public virtual bool IsFromAuthor(string author)
        {
            return false;
        }

        public void Purchase(int amount)
        {
            stock += amount;
        }

        public virtual void ReorderItem()
        {
            if (stock < 20) Purchase(50);
        }

        public bool Sell(int amount)
        {
            if (amount > stock) return false;
            
            stock -= amount;

            return true;
        }

        public override string ToString()
        {
            return $"Item: {title}, {price}€, {stock} int stock";
        }
    }
}