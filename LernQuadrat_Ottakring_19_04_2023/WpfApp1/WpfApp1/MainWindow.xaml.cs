﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber, secondNumber, result;

            if (double.TryParse(txtFirstNumber.Text, out firstNumber) && double.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                result = firstNumber + secondNumber;
                ResultWindow resultWindow = new ResultWindow(result);
                resultWindow.Show();
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
