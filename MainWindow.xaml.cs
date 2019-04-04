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

        private void Txtketqua_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            int gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt = gt * i;
            }
            txtKQ.Text = gt.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double s =1;
            for (int i = 2; i <= n; i++)
            {
                s += (double)Math.Sqrt(i);
            }
            txtKQ.Text = s.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double b=0;
            int x=2;
            for (int i = 2; i <= n; i++)
            {
                b = Math.Pow(i, x);
            }
            txtKQ.Text =b.ToString();
        }

    }
}