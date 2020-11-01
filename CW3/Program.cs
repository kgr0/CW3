using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3_6 Test
            int[,] arr1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix<int> m1 = new Matrix<int>(2, 3);
            m1.Fill(arr1);

            int[,] arr2 = new int[,] { { 7, 8 }, { 9, 10 }, { 11, 12 } };
            Matrix<int> m2 = new Matrix<int>(3, 2);
            m2.Fill(arr2);

            int[,] arr3 = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };
            Matrix<int> m3 = new Matrix<int>(2, 3);
            m3.Fill(arr3);

            m1.Multiply(m2, 3, 2);
            Console.WriteLine();
            m1.Add(m3, 2, 3);
            Console.WriteLine();

            int[,] arr4 = { { 4, 0, 0, 0 },
                        { 0, 7, 0, 0 },
                        { 0, 0, 5, 0 },
                        { 0, 0, 0, 1 } };
            SquareMatrix<int> m4 = new SquareMatrix<int>(4);
            m4.Fill(arr4);
            Console.WriteLine(m4.IsDiagonalMatrix());
            Console.WriteLine();
            #endregion

         //   Complex<int>[,] arr5 = new Complex<int>[,] { { new Complex<int>(1, 2) }, { new Complex<int>(3, 4) } };
         //   Matrix<Complex<int>> m5 = new Matrix<Complex<int>>(1, 1);
         //   m5.Fill(arr5);

        }
    }
}
