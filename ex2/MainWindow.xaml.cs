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

namespace ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const double SMALL_PRICE = 5.00;
        public const  double MEDIUM_PRICE = 6.25;
        public const double LARGE_PRICE = 7.75;
        public MainWindow()
        {
            InitializeComponent();

            
        }



        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {   
            priceLabel.Content = $"Price is: {SMALL_PRICE}$";
        }
        private void mediumRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priceLabel.Content = MEDIUM_PRICE;
        }

        private void largeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priceLabel.Content = LARGE_PRICE;
        }

        private void onionCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pepperCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void tomatoCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}
