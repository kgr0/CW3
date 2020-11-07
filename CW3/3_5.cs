using System;

namespace CW3
{
    public class Complex<T> : IConvertible, IFormattable, IComparable
    {
        private T real;
        private T imaginary;

        public Complex(T real, T imagine)
        {
            this.real = real;
            this.imaginary = imagine;
        }

        #region interfaces implementation
        public T GetReal()
        {
            return real;
        }
        public T GetImagine()
        {
            return imaginary;
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
        #endregion



        public override string ToString()
        {
            return $"{real.ToString()} + {imaginary.ToString()}i";
        }

        public static Complex<T> operator +(Complex<T> num1, Complex<T> num2)
        {
            dynamic r1 = num1.real;
            dynamic r2 = num2.real;
            dynamic i1 = num1.imaginary;
            dynamic i2 = num2.imaginary;
            return new Complex<T>(r1 + r2, i1 + i2);
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
