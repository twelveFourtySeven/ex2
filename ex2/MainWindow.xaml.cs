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
        public const double TOPPING_PRICE = 0.5;
        public double currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            currentNumber += SMALL_PRICE;
            contentUpdate();
        }
        private void mediumRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            currentNumber += MEDIUM_PRICE;
            contentUpdate();
        }

        private void largeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            currentNumber += LARGE_PRICE;
            contentUpdate();
        }
        private void smallRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            currentNumber -= SMALL_PRICE;
        }

        private void mediumRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            currentNumber -= MEDIUM_PRICE;
        }

        private void largeRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            currentNumber -= LARGE_PRICE;
        }

        private void onionCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            toppingAdded();
        }

        private void pepperCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            toppingAdded();
        }

        private void tomatoCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            toppingAdded();
        }

        private void onionCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            toppingRemoved();
        }

        private void pepperCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            toppingRemoved();
        }

        private void tomatoCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            toppingRemoved();
        }
        private void contentUpdate()
        {
            priceLabel.Content = $"Price is: {currentNumber}";
        }

        private void toppingAdded()
        {
            currentNumber += TOPPING_PRICE;
            contentUpdate();
        }

        private void toppingRemoved()
        {
            currentNumber -= TOPPING_PRICE;
            contentUpdate();
        }
    }
}
