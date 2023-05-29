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
                        Result.Text = result.ToString();
                        break;
                    case "-":
                        Fraction fraction3 = new Fraction(numerator1, denominator1);
                        Fraction fraction4 = new Fraction(numerator2, denominator2);
                        Fraction result2 = fraction3 - fraction4;
                        Result.Text = result2.ToString();
                        break;
                    case "*":
                        Fraction fraction5 = new Fraction(numerator1, denominator1);
                        Fraction fraction6 = new Fraction(numerator2, denominator2);
                        Fraction result3 = fraction5 * fraction6;
                        Result.Text = result3.ToString();
                        break;
                    case "/":
                        Fraction fraction7 = new Fraction(numerator1, denominator1);
                        Fraction fraction8 = new Fraction(numerator2, denominator2);
                        Fraction result4 = fraction7 / fraction8;
                        Result.Text = result4.ToString();
                        break;
                    default:
                        MessageBox.Show("Please select an operation");
                        break;
                }
            }
        }
    }
}
