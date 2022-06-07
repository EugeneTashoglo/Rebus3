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

namespace Rebus3
{
    /// <summary>
    /// Логика взаимодействия для Predlo.xaml
    /// </summary>
    public partial class Predlo : Page
    {
        public Predlo()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (num1.Text == "Предложение")
            {
                num1.Background = Brushes.LightGreen;
            }
            else
            {
                num1.Background = Brushes.Red;
            }
        }
    }
}
