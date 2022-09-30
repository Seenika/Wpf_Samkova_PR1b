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
using System.Windows.Shapes;

namespace Wpf_Samkova_PR1b
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Win2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Hide();
        }

        private void Win3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void Win4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Close();
        }

        private void Win5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Close();
        }

        private void Win6_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
            this.Close();
        }
    }
}
