using System;
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

        private void sizeM1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(sizeM1TextBox.Text);
                matrix1DataGridView.ColumnCount = size;
                matrix1DataGridView.RowCount = size;
            }
            catch { }

        }

        private void sizeM2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte size = Byte.Parse(sizeM2TextBox.Text);
                matrix2DataGridView.ColumnCount = size;
                matrix2DataGridView.RowCount = size;
            }
            catch { }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar == '/')
                {
                    e.Handled = false;
                }
            }
        }
    }
}
