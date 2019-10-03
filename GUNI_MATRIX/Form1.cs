using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNI_MATRIX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetTheme();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            var size = "2";
            colM1TextBox.Text = size;
            rowM1TextBox.Text = size;
            colM2TextBox.Text = size;

            colM1TextBox.Focus();
        }


        private static void RepaintAllControls(Control control, Color backColor, Color textColor)
        {
            control.BackColor = backColor;
            control.ForeColor = textColor;

            foreach (Control cntrl in control.Controls)
            {
                cntrl.BackColor = backColor;
                cntrl.ForeColor = textColor;



                RepaintAllControls(cntrl, backColor, textColor);

                var dataGridView = cntrl as DataGridView;
                if (dataGridView == null)
                    continue;

                dataGridView.BackgroundColor = backColor;
            }
        }


        private void SetTheme()
        {
            var backColor1 = Color.FromArgb(21, 21, 21);
            var backColor2 = Color.FromArgb(30, 30, 30);
            var backColor3 = Color.FromArgb(42, 42, 42);
            var backColor4 = Color.FromArgb(53, 53, 53);

            var textColor1 = Color.FromArgb(100, 100, 100);
            var textColor2 = Color.FromArgb(120, 120, 120);
            var textColor3 = Color.FromArgb(130, 130, 130);

            var systemButtonsColor = Color.FromArgb(0, 0, 0);
            var systemButtonsTextColor = Color.FromArgb(255, 0, 0);



            RepaintAllControls(this, backColor2, textColor2);

            closeButton.BackColor = systemButtonsColor;
            closeButton.ForeColor = systemButtonsTextColor;

            this.BackColor = backColor1;

            tabControl1.BackColor = backColor1;

            tabPage1.BackColor = backColor2;
            panel1.BackColor = backColor3;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.FlatStyle = FlatStyle.Standard;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.FlatStyle = FlatStyle.Flat;
        }

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

        private double[,] GetDoubleMatrixFromDataGrid(DataGridView dataGrid)
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
                    catch/* (Exception e)*/
                    {
                        res[i, j] = 0;
                        dataGrid[j, i].Value = "0";
                    }
                    
                }
            }

            return res;
        }

        private void PrintDoubleMatrixToDataGrid(DataGridView dataGridView, double[,] res)
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

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            var arr1 = GetDoubleMatrixFromDataGrid(matrix1DataGridView);
            var arr2 = GetDoubleMatrixFromDataGrid(matrix2DataGridView);

            if (arr1.GetLength(1) != arr2.GetLength(0))
            {
                MessageBox.Show($"A[{arr1.GetLength(0)},{arr1.GetLength(1)}] cannt mult on B{arr2.GetLength(0)},{arr2.GetLength(1)}] because ColCount of A != RowCount of B ({arr1.GetLength(1)} != {arr2.GetLength(0)}).");
                return;
            }

            var inDetal = new StringBuilder("");
            var res = Matrix.Multiplication(arr1, arr2, ref inDetal);
            
            PrintDoubleMatrixToDataGrid(matrixResDataGridView, res);

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

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.User32.ReleaseCapture();
                WinAPI.User32.SendMessage(Handle, WinAPI.User32.WM_NCLBUTTONDOWN, WinAPI.User32.HT_CAPTION, 0);
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            var arr1 = GetDoubleMatrixFromDataGrid(matrix1DataGridView);
            var arr2 = GetDoubleMatrixFromDataGrid(matrix2DataGridView);

            colM1TextBox.Text = arr2.GetLength(1).ToString();
            rowM1TextBox.Text = arr2.GetLength(0).ToString();
            colM2TextBox.Text = arr1.GetLength(1).ToString();

            PrintDoubleMatrixToDataGrid(matrix1DataGridView, arr2);
            PrintDoubleMatrixToDataGrid(matrix2DataGridView, arr1);

        }
    }
}
