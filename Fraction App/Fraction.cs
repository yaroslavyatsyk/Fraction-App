using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_App
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;

            if (denominator != 0)
            {
                this.denominator = denominator;
            }
            else
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
        }

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

       public object GetIntegerOrDecimal()
        {
            if (numerator % denominator == 0)
            {
                return (int) numerator / denominator;
            }
            else
            {
                return numerator / denominator;
            }
        }

        public static Fraction operator + (Fraction fraction1, Fraction fraction2)
        {
            if(fraction1.Denominator == fraction2.Denominator)
            {
                return new Fraction(fraction1.Numerator + fraction2.Numerator, fraction1.Denominator);
            }
            else
            {
                var commonDenominator = fraction1.Denominator * fraction2.Denominator;
                var firstNumerator = fraction1.Numerator * (commonDenominator / fraction1.Denominator);
                var secondNumerator = fraction2.Numerator * (commonDenominator / fraction2.Denominator);

                return new Fraction(firstNumerator + secondNumerator, commonDenominator);
            }
        }

        public static Fraction operator - (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Denominator == fraction2.Denominator)
            {
                return new Fraction(fraction1.Numerator - fraction2.Numerator, fraction1.Denominator);
            }
            else
            {
                var commonDenominator = fraction1.Denominator * fraction2.Denominator;
                var firstNumerator = fraction1.Numerator * (commonDenominator / fraction1.Denominator);
                var secondNumerator = fraction2.Numerator * (commonDenominator / fraction2.Denominator);
                return new Fraction(firstNumerator - secondNumerator, commonDenominator);
            }
        }

        public bool IsRegularFraction()
        {
            return numerator < denominator;
        }

        public bool IsImproperFraction()
        {
            return numerator > denominator;
        }

        public bool isMixedFraction()
        {
            return numerator % denominator != 0;
        }

        public static Fraction InverseFraction(Fraction fraction)
        {
            return new Fraction(fraction.Denominator, fraction.Numerator);
        }

        public static Fraction operator / (Fraction fraction1, Fraction fraction2)
        {
            
            var inverseFraction = InverseFraction(fraction2);

            if(fraction1.Numerator % inverseFraction.Denominator == 0 && inverseFraction.Numerator % fraction1.Denominator == 0)
            {
                var newNumerator = (fraction1.Numerator / inverseFraction.Denominator) * inverseFraction.Numerator;
                var newDenominator = (inverseFraction.Numerator / fraction1.Denominator) * fraction1.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
            else if (fraction1.Numerator % inverseFraction.Denominator == 0)
            {
                var newNumerator = (fraction1.Numerator / inverseFraction.Denominator) * inverseFraction.Numerator;
                return new Fraction(newNumerator, fraction1.Denominator);
            }
            else if (inverseFraction.Numerator % fraction1.Denominator == 0)
            {
                var newNumerator = (inverseFraction.Numerator / fraction1.Denominator) * fraction1.Numerator;
                return new Fraction(newNumerator, inverseFraction.Denominator);
            }
            else
            {
                var newNumerator = fraction1.Numerator * inverseFraction.Numerator;
                var newDenominator = fraction1.Denominator * inverseFraction.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }

        }

        public static Fraction operator * (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator % fraction2.Denominator == 0 && fraction2.Numerator % fraction1.Denominator == 0)
            {
                var newNumerator = (fraction1.Numerator / fraction2.Denominator) * fraction2.Numerator;
                var newDenominator = (fraction2.Numerator / fraction1.Denominator) * fraction1.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
            else if (fraction1.Numerator % fraction2.Denominator == 0)
            {
                var newNumerator = (fraction1.Numerator / fraction2.Denominator) * fraction2.Numerator;
                return new Fraction(newNumerator, fraction1.Denominator);
            }
            else if (fraction2.Numerator % fraction1.Denominator == 0)
            {
                var newNumerator = (fraction2.Numerator / fraction1.Denominator) * fraction1.Numerator;
                return new Fraction(newNumerator, fraction2.Denominator);
            }
            else
            {
                var newNumerator = fraction1.Numerator * fraction2.Numerator;
                var newDenominator = fraction1.Denominator * fraction2.Denominator;
                return new Fraction(newNumerator, newDenominator);

            }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        
        public static bool operator == (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator == fraction2.Numerator && fraction1.Denominator == fraction2.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator != fraction2.Numerator || fraction1.Denominator != fraction2.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator > (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator > fraction2.Numerator && fraction1.Denominator > fraction2.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator < (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator < fraction2.Numerator && fraction1.Denominator < fraction2.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
