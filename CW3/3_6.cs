using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    public class Matrix <T>
        where T: IComparable<T>, IEquatable<T>, IConvertible, IFormattable, IComparable 

    {
        protected T[,] matrix;
        protected int n;
        protected int m;

        public Matrix(int n, int m)
        {
            matrix = new T[n, m];
            this.n = n;
            this.m = m;
        }

        public void Fill(T [,] matrix)
        {
            this.matrix = matrix;
        }

        public Matrix<T> Add(Matrix<T> matrix2, int n, int m)
        {
            if((this.n != n ) || (this.m!=m))
            {
                Console.WriteLine("Wrong size of matrix");
                return new Matrix<T>(0, 0);
            }
            Matrix<T> res = new Matrix<T>(this.n, m);
            T element;
            dynamic add1;
            dynamic add2;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    add1 = this.GetElement(i, j);
                    add2 = matrix2.GetElement(i, j);
                    element = add1 + add2;
                    res.SetElement(i, j, element);
                }
            }
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(res.GetElement(i, j) + " ");
                }
                Console.WriteLine();
            }
            return res;
        }

        public Matrix<T> Multiply(Matrix<T> matrix2, int n, int m)
        {

            if (this.m != n)
            {
                Console.WriteLine("Wrong size of matrix");
                return new Matrix<T>(0, 0);
            }
                

            Matrix<T> res = new Matrix<T>(this.n, m);
            T element;
            dynamic zero = 0;
            dynamic mult1;
            dynamic mult2;

            for (int i = 0; i < this.n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    res.SetElement(i, j, zero);
                }
            }

            for (int i = 0; i < this.n; ++i)
                for (int j = 0; j < m; ++j)
                    for (int k = 0; k < this.m; ++k)
                    {
                        mult1 = this.GetElement(i, k);
                        mult2 = matrix2.GetElement(k, j);
                        element = res.GetElement(i, j) + mult1 * mult2;
                        res.SetElement(i,j, element);
                    }
            
            for(int i=0; i<this.n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Console.Write(res.GetElement(i, j) + " ");
                }
                Console.WriteLine();
            }
            return res;
        }

        public void SetElement(int i, int j, T value)
        {
            this.matrix[i, j] = value;
        }
        public T GetElement(int i, int j)
        {
            return this.matrix[i, j];
        }
    }

    public class SquareMatrix<T> : Matrix<T>
        where T : struct, IComparable<T>, IEquatable<T>, IConvertible, IFormattable, IComparable
    {
        public SquareMatrix(int n) : base(n, n)
        { }

        public bool IsDiagonalMatrix()
        {
            dynamic element;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    element = this.GetElement(i, j);
                    if ((i != j) && (element != 0))
                        return false;
                }
            }
            return true;
        }
    }
}
