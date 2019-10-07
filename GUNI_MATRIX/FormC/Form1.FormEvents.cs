using System;
using System.Windows.Forms;

namespace GUNI_MATRIX
{
    public partial class Form1
    {
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            closeButton.FlatStyle = FlatStyle.Standard;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            closeButton.FlatStyle = FlatStyle.Flat;
        }


        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.User32.ReleaseCapture();
                WinAPI.User32.SendMessage(Handle, WinAPI.User32.WM_NCLBUTTONDOWN, WinAPI.User32.HT_CAPTION, 0);
            }
        }
    }
}
