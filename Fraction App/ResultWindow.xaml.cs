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

namespace Fraction_App
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        Fraction fraction1;
        Fraction fraction2;
        Fraction result;
        string operation;
        public ResultWindow(Fraction fraction1, Fraction fraction2, Fraction result, string op)
        {
            InitializeComponent();
            this.fraction1 = fraction1;
            this.fraction2 = fraction2;
            this.result = result;
            this.operation = op;

            OperationLabel.Content = operation;

            Numerator1.Text = fraction1.Numerator.ToString();
            Denominator1.Text = fraction1.Denominator.ToString();

            Numerator2.Text = fraction2.Numerator.ToString();

            Denominator2.Text = fraction2.Denominator.ToString();

            ResultNumerator.Text = result.Numerator.ToString();
            ResultDenominator.Text = result.Denominator.ToString();

            decimalBox.Text = result.GetIntegerOrDecimal().ToString();
        }
    }
}
