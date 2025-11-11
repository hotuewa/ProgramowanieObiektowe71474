using Lab3;
using MyApplication;
using System;
using System.Numerics;


namespace MyApplication
{


    class Program
    {
        static void Main(string[] args)
        {

            ComplexNumber urojona1 = new ComplexNumber(3.2, -4.5);
            ComplexNumber urojona2 = new ComplexNumber(1.5, 2.3);
            ComplexNumber suma = urojona1 + urojona2;
            ComplexNumber roznica = urojona1 - urojona2;
            ComplexNumber iloczyn = urojona1 * urojona2;

            ComplexNumber clone = urojona1.Clone() as ComplexNumber;


            ComplexNumber sprzezenie = -urojona1;

            Console.WriteLine($"Suma: {urojona1} + {urojona2} = {suma}");
            Console.WriteLine($"Różnica: {urojona1} - {urojona2} = {roznica}");
            Console.WriteLine($"Iloczyn: {urojona1} * {urojona2} = {iloczyn}");
 
            Console.WriteLine(urojona1 == urojona2);
            Console.WriteLine(urojona1 != urojona2);

            Console.WriteLine($"Sprzężenie: {urojona1} = {sprzezenie}");

            Console.WriteLine($"Moduł liczby {urojona1} wynosi: {urojona1.Module()}");

            Console.WriteLine(clone);

            Console.WriteLine(clone.Equals(urojona1));





        }

    }


    class ComplexNumber: Lab3.ICloneable,IEquatable<ComplexNumber>,IModular
    {
        private double re;
        private double im;
        
        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }


        public override string ToString()
        {
            if (im > 0)
                return $"{re} + {im}i";
            else
                return $"{re}  {im}i";
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.re + c2.re, c1.im + c2.im);
        }

        public static ComplexNumber operator - (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.re - c2.re, c1.im - c2.im);
        }

        public static ComplexNumber operator * (ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.re * c2.re - c1.im * c2.im;
            double imaginaryPart = c1.re * c2.im + c1.im * c2.re;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            if (a is null || b is null)
                return false;
            return a.re == b.re && a.im == b.im;
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        { 
            if (a is null || b is null)
                return true;

            return !(a == b); 
        }


        public static ComplexNumber operator -(ComplexNumber c)

        => new ComplexNumber(c.re, -c.im);

        public object Clone()
        {
            return new ComplexNumber(this.re, this.im);
        }
        
        public double Module()
            => Math.Sqrt(re * re + im * im);

        public bool Equals(ComplexNumber? other)
        {
            if (other == null) return false;
            return this.Re == other.Re && this.Im == other.Im;
        }
        public override bool Equals(object? obj)
        {
            ComplexNumber? other = obj as ComplexNumber;
            return Equals(other);
        }


    }

}