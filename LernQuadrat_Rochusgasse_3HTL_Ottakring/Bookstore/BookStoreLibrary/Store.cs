using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStoreLibrary
{
     public class Store : ObservableCollection<Item>
    {
        public Store() 
        {
            Add(new Book("The Malta Exchange", "Steve Berry", "978-1250225658", Category.Thriller, 10, 12.8m));
            Add(new Newspaper("Der Standard", 20, 2.5m, new DateTime(2020, 10, 20), new List<string>() { "Christina Rebhahn-Roither", "Levin Wotke" }));
            Add(new Newspaper("Der Kurier", 15, 2m, new DateTime(2020, 10, 20), new List<string>() { "Elisabeth Holzer-Ottawa", "Hanno Lorenz" }));
            Add(new Audiobook("Alea Aquarius 4: Die Macht", "Tanya Stewner", "978-3789108884", Category.Fantasy, 8, 5, 90));
            Add(new Audiobook("Alea Aquarius 5: Die Botschaft", "Tanya Stewner", "978-3789113536", Category.Fantasy, 2, 5, 90));
            Add(new Book("Alea Aquarius 6: Der Fluss", "Tanya Stewner", "978-3789104367", Category.Fantasy, 5, 29.9m));
            Add(new Book("Harry Potter und die Kammer", "J.K. Rowling", "978-3551557421", Category.Fantasy, 10, 16.99m));
            Add(new Book("Harry Potter und der Gefangene", "J.K. Rowling", "978-3551559036", Category.Fantasy, 10, 32m));
            Add(new Book("Tramp a the fall of demokracy", "Johanna Roth", "978-3551559036", Category.Fantasy, 10, 32m));
            Add(new Audiobook("Harry Potter und der Feuerkelch", "J.K. Rowling", "978-1408855928", Category.Fantasy, 1337, 5, 90));
            Add(new Audiobook("Harry Potter und der Orden", "J.K. Rowling", "978-1408855935", Category.Fantasy, 1337, 5, 90));
            Add(new Audiobook("Harry Potter und der Halbblutprinz", "J.K. Rowling", "978-1408855942", Category.Fantasy, 7, 5, 90));
            Add(new Newspaper("Die Presse", 20, 2.5m, new DateTime(2020, 10, 20), new List<string>() { "Eduard Steiner", "Eduard Steiner" }));
            Add(new Newspaper("Die Zeit", 15, 2m, new DateTime(2020, 10, 20), new List<string>() { "Johanna Roth", "Paul Middelhoff", "Heinrich Wefing" }));
            Add(new Newspaper("Die Harry Potter News", 15, 2m, new DateTime(2020, 10, 20), new List<string>() { "J.K. Rowling", "Johanna Roth", "Paul Middelhoff", "Heinrich Wefing" }));
        }

        /*
        public void Add(Item i)
        {
            Items.Add(i);
        }

        public void Remove(Item i)
        {
            Items.Remove(i);
        }
        */

        public ObservableCollection<Item> GetByAuthor(string name)
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>();

            foreach (Item item in this.Items) if (item.IsFromAuthor(name)) items.Add(item);

            return items;
        }

        public ObservableCollection<Item> GetByTitle(string substring)
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>();

            foreach (Item item in this.Items) if (item.Title.Contains(substring)) items.Add(item);

            return items;
        }

        public void Reorder()
        {
            foreach (Item item in Items) item.ReorderItem();
        }
    }
}
