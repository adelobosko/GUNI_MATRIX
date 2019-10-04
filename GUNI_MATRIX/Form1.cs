using System;
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
            var size = "2";
            colM1TextBox.Text = size;
            rowM1TextBox.Text = size;
            colM2TextBox.Text = size;

            colM1TextBox.Focus();
        }
    }
}
