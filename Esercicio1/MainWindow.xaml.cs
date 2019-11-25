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

namespace Esercicio1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore + 1).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore + 0.1).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore + 0.01).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore * 0.1).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore * 0.01).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore * 0.001).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore - 1).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore - 0.1).ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore - 0.01).ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore / 0.1).ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore / 0.01).ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            double valore = double.Parse(txtValore.Text);
            txtValore.Text = (valore / 0.001).ToString();
        }
    }
}
