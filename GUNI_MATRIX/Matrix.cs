using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNI_MATRIX
{
    public class Matrix
    {
        public static double[,] Multiplication(double[,] a, double[,] b, ref StringBuilder inDetal)
        {
            var rows1 = a.GetLength(0);
            var cols2 = b.GetLength(1);
            var rows2 = b.GetLength(0);
            var res = new double[rows1,cols2];
            
            for (var i = 0; i < rows1; i++)
                for (var j = 0; j < cols2; j++)
                {
                    res[i,j] = 0;
                    for (var k = 0; k < rows2; k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                        inDetal.Append($"[{i},{j}] += {a[i, k]} * {b[k, j]} = {res[i, j]}\r\n");
                    }
                }

            return res;
        }


        public static FractionValue[,] Multiplication(FractionValue[,] a, FractionValue[,] b, ref StringBuilder inDetal)
        {
            var rows1 = a.GetLength(0);
            var cols2 = b.GetLength(1);
            var rows2 = b.GetLength(0);
            var res = new FractionValue[rows1, cols2];

            for (var i = 0; i < rows1; i++)
            for (var j = 0; j < cols2; j++)
            {
                res[i, j] = new FractionValue(0,1);
                for (var k = 0; k < rows2; k++)
                {
                    res[i, j] += a[i, k] * b[k, j];
                    inDetal.Append($"[{i},{j}] += {a[i, k]} * {b[k, j]} = {res[i, j]}\r\n");
                }
            }

            return res;
        }
    }
}
