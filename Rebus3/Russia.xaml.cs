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

namespace Rebus3
{
    /// <summary>
    /// Логика взаимодействия для Russia.xaml
    /// </summary>
    public partial class Russia : Window
    {
        public Russia()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Glagol();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Prilag();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Главное_Меню главное_Меню = new Главное_Меню();
            главное_Меню.Show();
            Hide();
        }

        private void Button_syff(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Syffiks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Mejdy();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Mesto();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new Predlo();
        }
    }
}
