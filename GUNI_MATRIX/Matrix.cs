using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

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




        public static void PrintFractionMatrixToDataGrid(DataGridView dataGridView, FractionValue[,] res)
        {
            dataGridView.RowCount = res.GetLength(0);
            dataGridView.ColumnCount = res.GetLength(1);


            for (var i = 0; i < dataGridView.RowCount; i++)
            {
                for (var j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Value = res[i, j].ToString();
                }
            }
        }

        public static FractionValue[,] GetFractialMatrixFromDataGrid(DataGridView dataGrid)
        {
            var res = new FractionValue[dataGrid.RowCount, dataGrid.ColumnCount];

            for (var i = 0; i < dataGrid.RowCount; i++)
            {
                for (var j = 0; j < dataGrid.ColumnCount; j++)
                {
                    try
                    {
                        res[i, j] = new FractionValue(dataGrid[j, i].Value.ToString());
                    }
                    catch/* (Exception e)*/
                    {
                        res[i, j] = new FractionValue(1, 1);
                        dataGrid[j, i].Value = "1";
                    }

                }
            }

            return res;
        }



        public static double[,] GetDoubleMatrixFromDataGrid(DataGridView dataGrid)
        {
            double[,] res = new double[dataGrid.RowCount, dataGrid.ColumnCount];

            for (var i = 0; i < dataGrid.RowCount; i++)
            {
                for (var j = 0; j < dataGrid.ColumnCount; j++)
                {
                    try
                    {
                        res[i, j] = Convert.ToDouble(dataGrid[j, i].Value.ToString());
                    }
                    catch
                    {
                        res[i, j] = 0;
                        dataGrid[j, i].Value = "0";
                    }

                }
            }

            return res;
        }

        public static void PrintDoubleMatrixToDataGrid(DataGridView dataGridView, double[,] res)
        {
            dataGridView.RowCount = res.GetLength(0);
            dataGridView.ColumnCount = res.GetLength(1);


            for (var i = 0; i < dataGridView.RowCount; i++)
            {
                for (var j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Value = res[i, j];
                }
            }
        }


        public static string GetStringMatrixByArray(double[,] a)
        {
            var str = "";
            for (var i = 0; i < a.GetLength(0); i++)
            {
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    str += $"{a[i,j]}\t";
                }

                str += "\r\n";
            }

            return str + " = ";
        }

        public static string GetStringMatrixByArray(FractionValue[,] a)
        {
            var str = "";
            for (var i = 0; i < a.GetLength(0); i++)
            {
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    str += $"{a[i, j]}\t";
                }

                str += "\r\n";
            }

            return str + " = ";
        }


        public static double[,] GetMinor(double[,] a, int row, int col)
        {
            var res = new double[a.GetLength(0) - 1, a.GetLength(1) - 1];
            var resi = 0;
            var resj = 0;

            for (var i = 0; i < a.GetLength(0); i++)
            {
                if (i == row) continue;
                resj = 0;
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    if (col == j) continue;
                    res[resi, resj] = a[i, j];
                    resj++;
                }

                resi++;
            }

            return res;
        }


        public static FractionValue[,] GetMinor(FractionValue[,] a, int row, int col)
        {
            var res = new FractionValue[a.GetLength(0) - 1, a.GetLength(1) - 1];
            var resi = 0;
            var resj = 0;

            for (var i = 0; i < a.GetLength(0); i++)
            {
                if (i == row) continue;
                resj = 0;
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    if (col == j) continue;
                    res[resi, resj] = a[i, j];
                    resj++;
                }

                resi++;
            }

            return res;
        }


        public static double Determinate(double[,] a, ref StringBuilder inDetal)
        {
            if (a.GetLength(0) == 2)
            {
                var res = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                return res;
            }

            double sum = 0;
            for (var i = 0; i < a.GetLength(0); i++)
            {
                var minor = GetMinor(a, 0, i);
                var sign = (((1 + i) % 2 == 0) ? 1 : -1);

                inDetal.Append($"+ [{i}] {sign} * {a[0, i]} * \r\n");
                inDetal.Append($"{GetStringMatrixByArray(minor)} = \r\n");

                var determinate = Determinate(minor, ref inDetal);
                var mulit = (sign) * a[0, i] * determinate;


                inDetal.Append($"+ [{i}] {sign * a[0, i]} * {determinate} = \r\n");
                inDetal.Append($"+ [{i}] {mulit} \r\n\r\n\r\n");
                sum += mulit;
            }

            return sum;
        }


        public static FractionValue Determinate(FractionValue[,] a, ref StringBuilder inDetal)
        {
            if (a.GetLength(0) == 2)
            {
                var res = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                return res;
            }

            FractionValue sum = new FractionValue(0,1);
            for (var i = 0; i < a.GetLength(0); i++)
            {
                var minor = GetMinor(a, 0, i);
                var sign = (((1 + i) % 2 == 0) ? 1 : -1);

                inDetal.Append($"+ [{i}] {sign} * {a[0, i]} * \r\n");
                inDetal.Append($"{GetStringMatrixByArray(minor)} = \r\n");

                var determinate = Determinate(minor, ref inDetal);
                var mulit =  a[0, i] * determinate * sign;


                inDetal.Append($"+ [{i}] {a[0, i] * sign} * {determinate} = \r\n");
                inDetal.Append($"+ [{i}] {mulit} \r\n\r\n\r\n");
                sum += mulit;
            }

            return sum;
        }
    }
}
