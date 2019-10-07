using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUNI_MATRIX
{
    public partial class Form1
    {
        private static DataGridView CreateDataGridView(string uniqueName, int index)
        {
            var dataGridView = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                ColumnHeadersVisible = false,
                Dock = DockStyle.Fill,
                Location = new System.Drawing.Point(240, 32),
                MultiSelect = false,
                Name = $"DataGridView_{uniqueName}_{index}",
                RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                RowHeadersVisible = false,
                RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
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
            tableLayoutPanel1.RowCount = arr.GetLength(0);
            tableLayoutPanel1.Height = matrix3DataGridView.Height * tableLayoutPanel1.RowCount;
            var strRes = new StringBuilder("");
            progressBar1.Maximum = arr.GetLength(0) * arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(0) * 2;

            new Thread(() =>
            {
                for (var k = 0; k < arr.GetLength(0); k++)
                {
                    var dataGridViewLeft = CreateDataGridView("LEFT", k);
                    var dataGridViewRight = CreateDataGridView("RIGHT", k);
                    dataGridViewLeft.ContextMenuStrip = dataGridContextMenuStrip;
                    dataGridViewRight.ContextMenuStrip = dataGridContextMenuStrip;

                    Invoke(new Action(() =>
                    {

                        dataGridList.Add(dataGridViewLeft);
                        dataGridViewLeft.RowCount = arr.GetLength(0);
                        dataGridViewLeft.ColumnCount = arr.GetLength(1);

                        dataGridList.Add(dataGridViewRight);
                        dataGridViewRight.RowCount = arr.GetLength(0);
                        dataGridViewRight.ColumnCount = arr.GetLength(1);

                        tableLayoutPanel1.Controls.Add(dataGridViewLeft, 0, k);
                        tableLayoutPanel1.Controls.Add(dataGridViewRight, 1, k);

                        tableLayoutPanel1.RowStyles.Add(new RowStyle()
                        {
                            Height = 100,
                            SizeType = SizeType.Percent
                        });
                    }));



                    var detFractionValue = new FractionValue($"{arr[k, k]}");
                    strRes.Append($"K[{k + 1}] det = {arr[k, k]}\r\n");

                    for (var i = 0; i < arr.GetLength(0); i++)
                    {
                        for (var j = 0; j < arr.GetLength(1); j++)
                        {
                            if (i == k || j == k)
                            {
                                continue;
                            }

                            strRes.Append($"A[{i + 1},{j + 1}] = {arr[i, j]} * {detFractionValue} - {arr[k, j]}  * {arr[i, k]} = ");

                            arr[i, j] = arr[i, j] * detFractionValue - arr[k, j] * arr[i, k];

                            strRes.Append($"{arr[i, j]}\r\n");
                            Invoke(new Action(() =>
                            {
                                progressBar1.Value = k * arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(0) * 2 + i * arr.GetLength(1) + j;
                                progressLabel.Text = $"{progressBar1.Value} / {progressBar1.Maximum} ({progressBar1.Value * 100.0 / progressBar1.Maximum:00}%)";
                            }));
                        }
                    }

                    for (var j = 0; j < arr.GetLength(0); j++)
                    {
                        if (j == k)
                        {
                            arr[k, k] = new FractionValue("1");
                            continue;
                        }

                        arr[k, j] *= -1;


                    }

                    Invoke(new Action(() =>
                    {
                        Matrix.PrintFractionMatrixToDataGrid(dataGridViewLeft, arr);
                    }));

                    for (var i = 0; i < arr.GetLength(0); i++)
                    {
                        for (var j = 0; j < arr.GetLength(1); j++)
                        {
                            strRes.Append($"A[{i}, {j}] = {arr[i, j]} / {detFractionValue} = ");
                            arr[i, j] /= detFractionValue;
                            strRes.Append($"{arr[i, j]}\r\n");
                            Invoke(new Action(() =>
                            {
                                progressBar1.Value = k * arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(0) * 2 + i * arr.GetLength(1) + j + arr.GetLength(1) * 2;
                                progressLabel.Text = $"{progressBar1.Value} / {progressBar1.Maximum} ({progressBar1.Value * 100.0 / progressBar1.Maximum:00}%)";
                            }));
                        }
                    }

                    Invoke(new Action(() =>
                    {
                        Matrix.PrintFractionMatrixToDataGrid(dataGridViewRight, arr);
                    }));
                }


                Invoke(new Action(() =>
                {
                    panel3.AutoScroll = false;
                    panel3.AutoScroll = true;
                    resJordansTextBox.Text = strRes.ToString();
                    progressBar1.Maximum = 0;
                    progressLabel.Text = "100%";
                }));
            }).Start();
        }

        private void col3TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var size = Byte.Parse(col3TextBox.Text);
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
            catch
            {
                // ignored
            }
        }
    }
}
