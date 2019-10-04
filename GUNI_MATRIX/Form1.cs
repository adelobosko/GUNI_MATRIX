using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var size = "3";
            colM1TextBox.Text = size;
            rowM1TextBox.Text = size;
            colM2TextBox.Text = size;
            col3TextBox.Text = size;
            row3TextBox.Text = size;
            colM1TextBox.Focus();
        }


        private static DataGridView CreateDataGridView(string uniqueName, int index)
        {
            var dataGridView = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader,
                AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders,
                ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None,
                ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                ColumnHeadersVisible = false,
                Dock = DockStyle.Fill,
                Location = new System.Drawing.Point(240, 32),
                MultiSelect = false,
                Name = $"DataGridView_{uniqueName}_{index}",
                RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None,
                RowHeadersVisible = false,
                RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                Size = new System.Drawing.Size(240, 175)
            };

            return dataGridView;
        }

        private static void ClearCreatedItems(List<Control> controls)
        {
            if (controls == null) return;

            for (var i = 0; i < controls.Count; i++)
            {
                controls[i].Dispose();
                controls[i] = null;
            }
            controls.Clear();
        }

        private List<Control> dataGridList;


        private void exceptButton_Click(object sender, EventArgs e)
        {
            var arr = Matrix.GetFractialMatrixFromDataGrid(matrix3DataGridView);

            if (arr.GetLength(0) != arr.GetLength(1))
            {
                MessageBox.Show($"RowCount != ColCount");
                return;
            }

            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.Height = 0;
            tableLayoutPanel1.RowStyles.Clear();
            ClearCreatedItems(dataGridList);
            dataGridList = new List<Control>();
            tableLayoutPanel1.RowCount = matrix3DataGridView.RowCount;
            tableLayoutPanel1.Height = matrix3DataGridView.Height * tableLayoutPanel1.RowCount;

            for (var k = 0; k < matrix3DataGridView.RowCount; k++)
            {
                var dataGridViewTmp1 = CreateDataGridView("LEFT", k);
                var dataGridViewTmp2 = CreateDataGridView("LEFT", k);

                dataGridList.Add(dataGridViewTmp1);
                dataGridViewTmp1.RowCount = matrix3DataGridView.RowCount;
                dataGridViewTmp1.ColumnCount = matrix3DataGridView.ColumnCount;

                dataGridList.Add(dataGridViewTmp2);
                dataGridViewTmp2.RowCount = matrix3DataGridView.RowCount;
                dataGridViewTmp2.ColumnCount = matrix3DataGridView.ColumnCount;

                tableLayoutPanel1.Controls.Add(dataGridViewTmp1);
                tableLayoutPanel1.Controls.Add(dataGridViewTmp2);

                tableLayoutPanel1.RowStyles.Add(new RowStyle()
                {
                    Height = 100,
                    SizeType = SizeType.Percent
                });

                var detFractionValue = new FractionValue($"{arr[k, k]}");

                for (var i = 0; i < arr.GetLength(0); i++)
                {
                    for (var j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }
                        arr[i, j] = (arr[i, j] * detFractionValue) - (arr[k, j] * arr[i, k]);
                    }
                }

                for (var j = 0; j < arr.GetLength(0); j++)
                {
                    if (j == k)
                    {
                        arr[k,k] /= detFractionValue;
                        continue;
                    }
                    arr[k, j] *= -1;
                }

                Matrix.PrintFractionMatrixToDataGrid(dataGridViewTmp1, arr);


                for (var i = 0; i < arr.GetLength(0); i++)
                {
                    for (var j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] /= detFractionValue;

                    }
                }

                Matrix.PrintFractionMatrixToDataGrid(dataGridViewTmp2, arr);
            }

            panel3.VerticalScroll.Enabled = true;
            panel3.VerticalScroll.Visible = true;
        }

        private void col3TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(col3TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix3DataGridView.ColumnCount = size;
            }
            catch { }
        }

        private void row3TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(row3TextBox.Text);
                if (size <= 0 || size >= 50)
                {
                    return;
                }
                matrix3DataGridView.RowCount = size;
            }
            catch { }
        }
    }
}
