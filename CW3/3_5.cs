using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    public class Complex<T> 
    {
        private T real;
        private T imaginary;

        public Complex(T real, T imagine)
        {
            this.real = real;
            this.imaginary = imagine;
        }

        public T GeTeal()
        {
            return real;
        }
        public T GetImagine()
        {
            return imaginary;
        }

        public static Complex<T> operator +(Complex<T> num1, Complex<T> num2)
        {
            dynamic r1 = num1.real;
            dynamic r2 = num2.real;
            dynamic i1 = num1.imaginary;
            dynamic i2 = num2.imaginary;
            return new Complex<T>( r1 + r2, i1 + i2);
        }

        public static Complex<T> operator -(Complex<T> num1, Complex<T> num2)
        {
            dynamic r1 = num1.real;
            dynamic r2 = num2.real;
            dynamic i1 = num1.imaginary;
            dynamic i2 = num2.imaginary;
            return new Complex<T>(r1 - r2, i1 - i2);
        }
        public static Complex<T> operator *(Complex<T> num1, Complex<T> num2)
        {
            dynamic r1 = num1.real;
            dynamic r2 = num2.real;
            dynamic i1 = num1.imaginary;
            dynamic i2 = num2.imaginary;
            return (new Complex<T>(r1 * r2 - i1 * i2, 
                r1 * i2 + r2 * i1));
        }
    }
}
