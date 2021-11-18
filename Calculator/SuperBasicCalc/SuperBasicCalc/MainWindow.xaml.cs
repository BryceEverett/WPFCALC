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

namespace SuperBasicCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addition(object sender, RoutedEventArgs e)
        {
           Double.TryParse(input1.Text, out num1);
           Double.TryParse(input2.Text, out num2);
           Double numfinal = num1 + num2;
           Answer.Text = numfinal.ToString();
        }

        private void subtraction(object sender, RoutedEventArgs e)
        {
            Double.TryParse(input1.Text, out num1);
            Double.TryParse(input2.Text, out num2);
            Double numfinal = num1 - num2;
            Answer.Text = numfinal.ToString();
        }

        private void multiplication(object sender, RoutedEventArgs e)
        {
            Double.TryParse(input1.Text, out num1);
            Double.TryParse(input2.Text, out num2);
            Double numfinal = num1 * num2;
            Answer.Text = numfinal.ToString();
        }

        private void division(object sender, RoutedEventArgs e)
        {
            if (num1 != 0 && num2 != 0) {
                Double.TryParse(input1.Text, out num1);
                Double.TryParse(input2.Text, out num2);
                Double numfinal = num1 / num2;
                Answer.Text = numfinal.ToString();
            }
            else
            {
                Answer.Text = "You are dumb".ToString();
            }
        }

     
    }
}
