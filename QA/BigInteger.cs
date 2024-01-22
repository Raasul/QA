using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA
{
    internal class BigInteger<T>
    {
        private T value;

        public BigInteger(T initialValue)
        {
            this.value = initialValue;
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public static BigInteger<T> operator +(BigInteger<T> num1, BigInteger<T> num2)
        {
            dynamic result = Convert.ToDouble(num1.Value) + Convert.ToDouble(num2.Value);
            return new BigInteger<T>((T)Convert.ChangeType(result, typeof(T)));
            // Реализация сложения
        }

        public static BigInteger<T> operator -(BigInteger<T> num1, BigInteger<T> num2)
        {
            dynamic result = Convert.ToDouble(num1.Value) - Convert.ToDouble(num2.Value);
            return new BigInteger<T>((T)Convert.ChangeType(result, typeof(T)));
            // Реализация вычитания
        }

        public static BigInteger<T> operator *(BigInteger<T> num1, BigInteger<T> num2)
        {
            if (EqualityComparer<T>.Default.Equals(num2.Value, default(T)))
            {
                throw new ArgumentException("Умножение на ноль недопустимо.");
            }
            dynamic result = Convert.ToDouble(num1.Value) * Convert.ToDouble(num2.Value);
            return new BigInteger<T>((T)Convert.ChangeType(result, typeof(T)));
            // Реализация умножения
        }

        public static BigInteger<T> operator /(BigInteger<T> num1, BigInteger<T> num2)
        {
            if (EqualityComparer<T>.Default.Equals(num2.Value, default(T)))
            {
                throw new ArgumentException("Деление на ноль недопустимо.");
            }
            dynamic result = Convert.ToDouble(num1.Value) / Convert.ToDouble(num2.Value);
            return new BigInteger<T>((T)Convert.ChangeType(result, typeof(T)));
            // Реализация деления
        }

    }
}
