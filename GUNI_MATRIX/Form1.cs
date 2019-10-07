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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.AutoScroll = false;
            panel3.AutoScroll = true;
        }

        private void sendToMatrix1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataGridView = (DataGridView)((ContextMenuStrip) (((ToolStripMenuItem) sender).Owner)).SourceControl;
            var arr = Matrix.GetFractialMatrixFromDataGrid(dataGridView);
            Matrix.PrintFractionMatrixToDataGrid(matrix1DataGridView, arr);
        }

        private void sendToMatrix2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataGridView = (DataGridView)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl;
            var arr = Matrix.GetFractialMatrixFromDataGrid(dataGridView);
            Matrix.PrintFractionMatrixToDataGrid(matrix2DataGridView, arr);
        }

        private void doubleToResMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataGridView = (DataGridView)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl;
            var arr = Matrix.GetFractialMatrixFromDataGrid(dataGridView);
            Matrix.PrintDoubleMatrixToDataGrid(matrixResDataGridView, arr);
        }
    }
}
