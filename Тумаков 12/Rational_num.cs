using System;

namespace Тумаков_12
{
    internal class Rational_num
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Rational_num(int numerator, int denominator)
        {
            Denominator = denominator;
            Numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("Нельзя делить на ноль. Нулевого знаменателя не бывает.");
            }
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }


        public static bool operator ==(Rational_num a, Rational_num b)
        {
            if (Equals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
        }

        public static bool operator !=(Rational_num a, Rational_num b)
        {
            return !(a == b);
        }

        public static bool operator <(Rational_num a, Rational_num b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static bool operator >(Rational_num a, Rational_num b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }

        public static bool operator <=(Rational_num a, Rational_num b)
        {
            return a < b || a == b;
        }

        public static bool operator >=(Rational_num a, Rational_num b)
        {
            return a > b || a == b;
        }

        public static Rational_num operator +(Rational_num a, Rational_num b)
        {
            return new Rational_num(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static Rational_num operator -(Rational_num a, Rational_num b)
        {
            return new Rational_num(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static Rational_num operator ++(Rational_num a)
        {
            return new Rational_num(a.Numerator + a.Denominator, a.Denominator);
        }

        public static Rational_num operator --(Rational_num a)
        {
            return new Rational_num(a.Numerator - a.Denominator, a.Denominator);
        }

        public static implicit operator float(Rational_num a) // слово implicit используется для неявного преобразования типов. Компилятор автоматически преобразует его к типу float.
        {
            return (float)a.Numerator / a.Denominator;
        }

        public static implicit operator int(Rational_num a)
        {
            return (int)a.Numerator / a.Denominator;
        }

        public static Rational_num operator *(Rational_num a, Rational_num b)
        {
            return new Rational_num(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Rational_num operator /(Rational_num a, Rational_num b)
        {
            return new Rational_num(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static Rational_num operator %(Rational_num a, Rational_num b)
        {
            int a_int = a.Numerator * b.Denominator;
            int b_int = a.Denominator * b.Numerator;
            return new Rational_num (a_int % b_int, a.Denominator * b.Denominator);
        }
    } 
}
