using BookStoreLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Bookstore
{
    public partial class MainWindow : Window
    {
        private Store store;
        
        public MainWindow()
        {
            InitializeComponent();

            store = new Store();
            listBoxResult.ItemsSource = store;

            comboBoxCategory.ItemsSource = Enum.GetNames(typeof(Category));
            comboBoxCategory.SelectedIndex = 0;

        }

        private bool IsCreatePossible()
        {

            if (textBoxTitle.Text.Length <= 0)
            {
                labeStatus.Content = "Title must not be empty";
                return false;
            }

            if (textBoxTitle.Text.Length <= 0)
            {
                labeStatus.Content = "Title must not be empty";
                return false;
            }

            return true;
        }

        private void SetStatusMsg(string msg)
        {
            labeStatus.Content = msg;
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                SetStatusMsg("Title must not be empty");
                return;
            }

            string title = textBoxTitle.Text;

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || !int.TryParse(textBoxStock.Text, out int stock))
            {
                SetStatusMsg("Price and stock must be numeric values");
                return;
            }

            if (radioButtonNewspaper.IsChecked == true)
            {
                if (!datePickerIssueDate.SelectedDate.HasValue)
                {
                    SetStatusMsg("Invalid date selected");
                    return;
                }

                DateTime parsedDate = datePickerIssueDate.SelectedDate.Value;

                // Add Newspaper
                store.Add(new Newspaper(title,
                    stock,
                    price,
                    parsedDate,
                    new List<string>()
                    ));

                return;
            }

 
            // If Newspapaer is not selected, then either Book or Audiobook must be selected
            if (string.IsNullOrWhiteSpace(textBoxAuthor.Text) || string.IsNullOrWhiteSpace(textBoxIsbn.Text))
            {
                SetStatusMsg("Author and ISBN must not be empty");
                return;
            }

            string author = textBoxAuthor.Text;
            string isbn = textBoxIsbn.Text;

            if (!Enum.TryParse<Category>((string) comboBoxCategory.SelectedItem, out Category category))
            {
                SetStatusMsg("No valid category selected");
                return;
            }

            if (radioButtonAudioBook.IsChecked == true)
            {
                if (!int.TryParse(textBoxDuration.Text, out int duration) || duration < 0)
                {
                    SetStatusMsg("Duration must be > 0");
                    return;
                }

                // Add Audiobook
                store.Add(new Audiobook(title,
                    author,
                    isbn,
                    category,
                    stock,
                    price,
                    duration
                    ));

                return;
            }

            // Add Book
            store.Add(new Book(title,
                author,
                isbn,
                category,
                stock,
                price));
        }

        private void buttonSearchByTitle_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Item> o = store.GetByTitle(textBoxSearch.Text);
            listBoxResult.ItemsSource = o;
        }

        private void buttonSearchAuthor_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Item> o = store.GetByAuthor(textBoxSearch.Text);
            listBoxResult.ItemsSource = o;
        }

        private int verifyPurchaseSell()
        {
            if (listBoxResult.SelectedItem == null)
            {
                SetStatusMsg("No item is selected"); 
                return -1;
            }

            if (!int.TryParse(textBoxAmount.Text, out int amount) || amount < 0)
            {
                SetStatusMsg("Amount must be a positive integer value"); 
                return - 1;
            }

            return amount;
        }

        private void buttonPurchase_Click(object sender, RoutedEventArgs e)
        {
            int amount = verifyPurchaseSell();
            if (amount < 0) return;

            Item i = (Item)listBoxResult.SelectedItem;

            i.Purchase(amount);
        }

        private void buttonSell_Click(object sender, RoutedEventArgs e)
        {
            int amount = verifyPurchaseSell();
            if (amount < 0) return;

            Item i = (Item)listBoxResult.SelectedItem;

            if (!i.Sell(amount)) SetStatusMsg("Not enough stock available");
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxResult.SelectedItem != null) store.Remove((Item) listBoxResult.SelectedItem);
        }

        private void buttonReorder_Click(object sender, RoutedEventArgs e)
        {
            store.Reorder();
        }

        private void textBoxSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                listBoxResult.ItemsSource = store;
            }

        }
    }
}
