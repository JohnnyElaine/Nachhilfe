using HelpRequestLibrary; // Library wurde als reference hinzugefügt: HelpDesk_with_Qeue -> Dependencies -> Add project reference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelpDesk_with_Queue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Queue<HelpRequest> helpRequestQueue;
        private HelpRequest currentSupportRequest;

        public MainWindow()
        {
            InitializeComponent();
            
            InitUI();
        }

        private void initClassVariables()
        {
            helpRequestQueue = new Queue<HelpRequest>();
            currentSupportRequest = new HelpRequest(string.Empty, string.Empty, new DateTime());
        }

        private void InitUI()
        {
            userDpDate.SelectedDate = DateTime.Now;
        }

        private void userBtnSend_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = (DateTime) userDpDate.SelectedDate;
            helpRequestQueue.Enqueue(new HelpRequest(userTbName.Text, userTbRequest.Text, dt));

            userLbSendConfirmation.Content = "Request is sent to support";
        }

        private void supportBtnGetNextRequest_Click(object sender, RoutedEventArgs e)
        {
            currentSupportRequest = helpRequestQueue.Dequeue();

            supportTbName.Text = currentSupportRequest.name;
            supportTbDate.Text = currentSupportRequest.date.ToString();
            supportTbRequest.Text = currentSupportRequest.request;
        }

        private void supportBtnSendAgain_Click(object sender, RoutedEventArgs e)
        {
            helpRequestQueue.Enqueue(new HelpRequest(currentSupportRequest.name, supportTbRequest.Text, currentSupportRequest.date));
        }
    }
}
