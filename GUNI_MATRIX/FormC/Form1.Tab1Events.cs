using System;
using System.CodeDom;
using System.Text;
using System.Windows.Forms;

namespace GUNI_MATRIX
{
    public partial class Form1
    {
        private void matrixDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                if (e.KeyChar == '/')
                {
                    e.Handled = false;
                }
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            var arr1 = Matrix.GetFractialMatrixFromDataGrid(matrix1DataGridView);
            var arr2 = Matrix.GetFractialMatrixFromDataGrid(matrix2DataGridView);

            if (arr1.GetLength(1) != arr2.GetLength(0))
            {
                MessageBox.Show($"A[{arr1.GetLength(0)},{arr1.GetLength(1)}] cannt mult on B{arr2.GetLength(0)},{arr2.GetLength(1)}] because ColCount of A != RowCount of B ({arr1.GetLength(1)} != {arr2.GetLength(0)}).");
                return;
            }

            var inDetal = new StringBuilder("");
            var res = Matrix.Multiplication(arr1, arr2, ref inDetal);

            Matrix.PrintFractionMatrixToDataGrid(matrixResDataGridView, res);

            resTextBox.Text = inDetal.ToString();
        }

        private void rowM1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(rowM1TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix1DataGridView.RowCount = size;
            }
            catch { }
        }

        private void colM1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(colM1TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix1DataGridView.ColumnCount = size;
                rowM2TextBox.Text = size.ToString();

            }
            catch { }

        }

        private void colM2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(colM2TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix2DataGridView.ColumnCount = size;
            }
            catch { }
        }

        private void rowM2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(rowM2TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix2DataGridView.RowCount = size;
            }
            catch { }
        }

        private void swapButton_Click(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView1 = matrix1DataGridView;
            DataGridView dataGridView2;

            if (e.Button == MouseButtons.Right)
            {
                dataGridView2 = matrixResDataGridView;
            }
            else
            {
                dataGridView2 = matrix2DataGridView;
            }


            var arr1 = Matrix.GetFractialMatrixFromDataGrid(dataGridView1);
            var arr2 = Matrix.GetFractialMatrixFromDataGrid(dataGridView2);
            colM1TextBox.Text = arr2.GetLength(1).ToString();
            rowM1TextBox.Text = arr2.GetLength(0).ToString();

            Matrix.PrintFractionMatrixToDataGrid(dataGridView1, arr2);
            Matrix.PrintFractionMatrixToDataGrid(dataGridView2, arr1);

        }
        

        private void detButton_Click(object sender, EventArgs e)
        {
            if (matrix1DataGridView.RowCount != matrix1DataGridView.ColumnCount)
            {
                MessageBox.Show($"RowCount != ColCount");
                return;
            }
            var arr1 = Matrix.GetFractialMatrixFromDataGrid(matrix1DataGridView);
            var inDetal = new StringBuilder("");

            var result = Matrix.Determinate(arr1, ref inDetal);
            resTextBox.Text = inDetal.ToString();

            resTextBox.Text += result.ToString();
        }



        private void aliedButton_Click(object sender, EventArgs e)
        {
            if (matrix1DataGridView.RowCount != matrix1DataGridView.ColumnCount)
            {
                MessageBox.Show($"RowCount != ColCount");
                return;
            }

            var arr1 = Matrix.GetFractialMatrixFromDataGrid(matrix1DataGridView);
            var inDetal = new StringBuilder("");

            var result = Matrix.Alied(arr1, ref inDetal);

            resTextBox.Text = inDetal.ToString();
            Matrix.PrintFractionMatrixToDataGrid(matrixResDataGridView, result);
            resTextBox.Text += $"~A = \r\n{Matrix.GetStringMatrixByArray(result)}";
        }



        private void transponationButton_Click(object sender, EventArgs e)
        {
            if (matrix1DataGridView.RowCount != matrix1DataGridView.ColumnCount)
            {
                MessageBox.Show($"RowCount != ColCount");
                return;
            }

            var arr1 = Matrix.GetFractialMatrixFromDataGrid(matrix1DataGridView);
            var result = Matrix.Transposition(arr1);


            Matrix.PrintFractionMatrixToDataGrid(matrixResDataGridView, result);
            resTextBox.Text = $"At = \r\n{Matrix.GetStringMatrixByArray(result)}";
        }


        private void mulOnDigitButton_Click(object sender, EventArgs e)
        {
            var value = "";
            if (TMP.InputBox("Input FractalValue", "Input FractalValue like \"1/12\" or \"7\":", ref value) != DialogResult.OK)
            {
                return;
            }


            var arr1 = Matrix.GetFractialMatrixFromDataGrid(matrix1DataGridView);
            FractionValue fractionValue;
            try
            {
                fractionValue = new FractionValue(value);
            }
            catch
            {
                MessageBox.Show($"I can not create FractionValue from this string \"{value}\"");
                return;;
            }

            var result = Matrix.MultiplicateOnFractionValue(arr1, fractionValue);

            Matrix.PrintFractionMatrixToDataGrid(matrixResDataGridView, result);
            resTextBox.Text = $"A * {fractionValue} = \r\n{Matrix.GetStringMatrixByArray(result)}";

        }
    }
}
