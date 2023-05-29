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

namespace Fraction_App
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numerator1 = int.Parse(NumeratorFirst.Text);
                int denominator1 = int.Parse(DenominatorFirst.Text);

                int numerator2 = int.Parse(NumeratorSecond.Text);
                int denominator2 = int.Parse(DenominatorSecond.Text);

                string operation = comboBox.Text;

                switch(operation)
                {
                    case "+":
                        Fraction fraction1 = new Fraction(numerator1, denominator1);
                        Fraction fraction2 = new Fraction(numerator2, denominator2);
                        Fraction result = fraction1 + fraction2;

                        ResultWindow resultWindow = new ResultWindow(fraction1, fraction2, result, operation);
                        resultWindow.Show();
                        
                        break;
                    case "-":
                        Fraction fraction3 = new Fraction(numerator1, denominator1);
                        Fraction fraction4 = new Fraction(numerator2, denominator2);
                        Fraction result2 = fraction3 - fraction4;

                        ResultWindow resultWindow2 = new ResultWindow(fraction3, fraction4, result2, operation);
                        resultWindow2.Show();
                      
                        break;
                    case "*":
                        Fraction fraction5 = new Fraction(numerator1, denominator1);
                        Fraction fraction6 = new Fraction(numerator2, denominator2);
                        Fraction result3 = fraction5 * fraction6;

                        ResultWindow resultWindow3 = new ResultWindow(fraction5, fraction6, result3, operation);
                        resultWindow3.Show();
                        
                        break;
                    case "/":
                        Fraction fraction7 = new Fraction(numerator1, denominator1);
                        Fraction fraction8 = new Fraction(numerator2, denominator2);
                        Fraction result4 = fraction7 / fraction8;

                        ResultWindow resultWindow4 = new ResultWindow(fraction7, fraction8, result4, operation);
                        resultWindow4.Show();
                       
                        break;
                    default:
                        MessageBox.Show("Please select an operation");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, incorrect input(s)","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
