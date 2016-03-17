using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rv
{
    public static class rvMath
    {
        const double _2PI = Math.PI * 2;

        public static double Grad2Rad(double a)
        {
            return  a/180 * Math.PI;
        }

        public static double CorrectAngleRad(double a)
        {
            while (a >= _2PI) a -= _2PI;
            while (a < 0) a += _2PI;
            return a;
        }

        //БЫСТРЫЙ АЛГОРИТМ ЕВКЛИДА
        //ДЛЯ ВЫЧИСЛЕНИЯ НОД
        public static long NOD(long n1, long n2)
        {
            //если первое число меньше второго,
            //то меняем их значения:
            if (n1 < n2)
            {
                long n = n1;
                n1 = n2;
                n2 = n;
            }
            //находим НОД:
            if (n2 == 0) return n1;
            while (n2 > 0)
            {
                long n = n1 % n2;
                n1 = n2;
                n2 = n;
            }
            return n1;
        }

        //ВЫЧИСЛЯЕМ НОК
        public static long NOK(long n1, long n2)
        {
          //проверки:
          if (n1 < 0) return 0;           
          if (n1 * n2 == 0) return 0;
          //вычисляем НОК:
          return n1 * n2 / NOD(n1, n2);
        }





        //СТРУКТУРА ДЛЯ РАБОТЫ С КОМПЛЕКСНЫМИ ЧИСЛАМИ
        public struct Complex
        {
            //Действительная часть комплексного числа:
            private double re;
            //Мнимая часть действительного числа:
            private double im;

            public static Complex Infinity = new Complex(double.PositiveInfinity, 
                                                         double.PositiveInfinity);
            public static Complex NaN = new Complex(double.NaN, double.NaN);

            /// <summary>
            /// Действительная часть комплексного числа.
            /// </summary>
            public double Re
            {
                get { return this.re; }
                set { this.re = value; }
            }

            /// <summary>
            /// Мнимая часть комплексного числа.
            /// </summary>
            public double Im
            {
                get { return this.im; }
                set { this.im = value; }
            }

            /// <summary>
            /// Метод Real.
            /// Возвращает действительную часть комплексного числа.
            /// </summary>
            public static double Real(Complex z)
            {
                return (z.re);
            }
            /// <summary>
            /// Метод Imaginary.
            /// Возвращает мнимую часть комплексного числа.
            /// </summary> 
            public static double Imaginary(Complex z)
            {
                return (z.im);
            }



            /// <summary>
            /// Конструктор комплексного числа из действительного. 
            /// Мнимая часть равна нулю.
            /// </summary>
            /// <param name="re">Целая часть комплексного числа.</param>
            public Complex(double re)
            {
                this.re = re;
                this.im = 0;
            }

            /// <summary>
            /// Конструктор комплексного числа. 
            /// </summary>
            /// <param name="re">Целая часть комплексного числа.</param>
            /// <param name="im">Мнимая часть комплексного числа.</param>
            public Complex(double re, double im)
            {
                this.re = re;
                this.im = im;
            }

            /// <summary>
            /// Конструктор копирования.
            /// Создает комплексное число из другого комплексного числа.
            /// </summary>
            /// <param name="z">Исходное комплексное число.</param>
            public Complex(Complex z)
            {
                this.re = z.re;
                this.im = z.im;
            }

            /// <summary>
            /// Оператор равенства.
            /// </summary>
            /// <param name="z1">Первое комплексное число.</param>
            /// <param name="z2">Второе комплексное число.</param>
            /// <returns>Возвращает true, если числа равны, или false, если не равны.</returns>
            public static bool operator ==(Complex z1, Complex z2)
            {
                return ((z1.re == z2.re) && (z1.im == z2.im));
            }

            /// <summary>
            /// Оператор неравенства.
            /// </summary>
            /// <param name="z1">Первое комплексное число.</param>
            /// <param name="z2">Второе комплексное число.</param>
            /// <returns>Возвращает true, если числа не равны, или false, если равны.</returns>
            public static bool operator !=(Complex z1, Complex z2)
            {
                return !(z1 == z2);
            }


            /// <summary>
            /// Метод Norm возвращает модуль комплексного числа z.
            /// </summary>
            public static double Norm(Complex z)
            {
                return (Math.Sqrt((z.re * z.re) +
                                  (z.im * z.im)));
            }

            /// <summary>
            /// Свойство Mod возвращает модуль комплексного числа.
            /// </summary>
            public double Mod
            {
                get { return Math.Sqrt(re * re + im * im); }
            }

            /// <summary>
            /// Метод Argument возвращает модуль комплексного числа z.
            /// </summary>   
            public static double Argument(Complex z)
            {
                return (Math.Atan2(z.im, z.re));
            }
            /// <summary>
            /// Свойство Arg возвращает аргумент комплексного числа.
            /// </summary>
            public double Arg
            {
                get { return Math.Atan2(im, re); }
            }
            public double ArgGrad
            {
                get { return Math.Atan2(im, re)*180/Math.PI; }
            }


                     //АРИФМЕТИЧЕСКИЕ ДЕЙСТВИЯ


            /// <summary>
            /// Унарный плюс.
            /// Комплексное число не изменяется.
            /// </summary>
            public static Complex operator +(Complex z)
            {
                return z;
            }
            /// <summary>
            /// Бинарный плюс.
            /// Возвращает сумму комплексного и действительного чисел.
            /// </summary>
            public static Complex operator +(Complex z, double x)
            {
                return (new Complex(z.re + x, z.im));
            }
            /// <summary>
            /// Бинарный плюс.
            /// Возвращает сумму действительного и комплексного чисел.
            /// </summary>
            public static Complex operator +(double x, Complex z)
            {
                return (new Complex(x + z.re, z.im));
            }
            /// <summary>
            /// Бинарный плюс.
            /// Возвращает сумму двух и комплексных чисел z = z1 + z2.
            /// </summary>
            public static Complex operator +(Complex z1, Complex z2)
            {
                return (new Complex(z1.re + z2.re, z1.im + z2.im));
            }


            /// <summary>
            /// Унарный минус.
            /// Возвращает комплексное число -z.
            /// </summary>
            public static Complex operator -(Complex z)
            {
                return new Complex(-z.re, -z.im);
            }
            /// <summary>
            /// Бинарный минус.
            /// Возвращает разность комплексного и действительного чисел z-x.
            /// </summary>
            public static Complex operator -(Complex z, double x)
            {
                return (new Complex(z.re - x, z.im));
            }
            /// <summary>
            /// Бинарный минус.
            /// Возвращает разность действительного и комплексного чисел x-z.
            /// </summary>
            public static Complex operator -(double x, Complex z)
            {
                return (new Complex(x - z.re, -z.im));
            }
            /// <summary>
            /// Бинарный минус.
            /// Возвращает разность двух комплексных чисел z1-z2.
            /// </summary>
            public static Complex operator -(Complex z1, Complex z2)
            {
                return (new Complex(z1.re - z2.re, z1.im - z2.im));
                //return z1 + (-z2);
            }

            /// <summary>
            /// Оператор умножения.
            /// Возвращает произведение комплексного и действительного чисел z*x.
            /// </summary>
            public static Complex operator *(Complex z, double x)
            {
                return (new Complex(z.re * x, z.im * x));
            }
            /// <summary>
            /// Оператор умножения.
            /// Возвращает произведение действительного и комплексного   чисел x*z.
            /// </summary>
            public static Complex operator *(double x, Complex z)
            {
                return (new Complex(x * z.re, x * z.im));
            }
            /// <summary>
            /// Оператор умножения.
            /// Возвращает произведение двух комплексных чисел z1*z2.
            /// </summary>
            public static Complex operator *(Complex z1, Complex z2)
            {
                double re = (z1.re * z2.re) - (z1.im * z2.im);
                double im = (z1.re * z2.im) + (z1.im * z2.re);
                return (new Complex(re, im));
            }




            /// <summary>
            /// Оператор деления.
            /// Возвращает частное от деления комплексного числа на действительное z/x.
            /// </summary>
            public static Complex operator /(Complex z, double x)
            {
                if (x == 0.0) return Complex.Infinity;
                double re = z.re / x;
                double im = z.im / x;
                return (new Complex(re, im));
            }
            /// <summary>
            /// Метод IsZero 
            /// возвращает true, если комплексное число равно нулю, или
            /// false, если не равно.
            /// </summary>
            public bool IsZero
            { get { return ((re == 0.0) && (im == 0.0)); } }
            /// <summary>
            /// Оператор деления.
            /// Возвращает частное от деления действительного числа на комплексное x/z.
            /// </summary>
            public static Complex operator /(double x, Complex z)
            {
                if (z.IsZero) return Complex.Infinity;
                double denom = (double)(Math.Pow(z.re, 2.0) + Math.Pow(z.im, 2.0));
                double re = (x * z.re) / denom;
                double im = (0.0 - (x * z.im)) / denom;
                return (new Complex(re, im));
            }

            /// <summary>
            /// Оператор деления.
            /// Возвращает частное от деления первого комплексного числа на второе z1/z2.
            /// </summary>
            public static Complex operator /(Complex z1, Complex z2)
            {
                if (z2.IsZero) return Complex.Infinity;
                double denom = (double)(Math.Pow(z2.re, 2.0) + Math.Pow(z2.im, 2.0));
                double re = ((z1.re * z2.re) + (z1.im * z2.im)) / denom;
                double im = ((z1.im * z2.re) - (z1.re * z2.im)) / denom;
                return (new Complex(re, im));
            }










            /// <summary>
            /// Represents the implicit coversion of a scalar to a complex number.
            /// </summary>
            /// <param name="scalar">A double precision number to be converted.</param>
            /// <returns>Returns a ComplexNumber.</returns>
            //public static implicit operator Complex(double x)
            //{
            //    return new Complex(x);
            //}
            public static implicit operator double(Complex z)
            {
                return z.re;
            }
            public static explicit operator Complex(double x)
            {
                return (new Complex(x, 0.0));
            }







            /// <summary>
            /// Checks whether the given object is equal to this complex number.
            /// </summary>
            /// <param name="obj">Object to be checked if it is equal to this complex number.</param>
            /// <returns>Returns true if the given object is equal to this complex number, false otherwise.</returns>
            public override bool Equals(object obj)
            {
                return ((obj is Complex)) ? this == (Complex)obj : false;
            }

            /// <summary>
            /// Hashcode that reprsents this complex number.
            /// </summary>
            /// <returns>Returns integer value of the hashcode.</returns>
            public override int GetHashCode()
            {
                return re.GetHashCode() ^ im.GetHashCode();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(" + re.ToString());

                if (im > 0)
                    sb.Append(" + ");
                else if (im < 0)
                    sb.Append(" - ");

                sb.Append(System.Math.Abs(im).ToString());
                sb.Append("i)");

                return sb.ToString();
            }
        }


    }
}
