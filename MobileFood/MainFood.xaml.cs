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

namespace MobileFood
{
    /// <summary>
    /// Interaction logic for MainFood.xaml
    /// </summary>
    public partial class MainFood : Page
    {
        public MainFood()
        {
            InitializeComponent();
            Menedger.MainFrame = MainFrame;
            MainFrame.Navigate(new News());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new News());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Orders());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Menedger.MainFrame.Navigate(new User());
        }
    }
}
