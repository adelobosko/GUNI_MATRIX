﻿namespace GUNI_MATRIX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.matrixResDataGridView = new System.Windows.Forms.DataGridView();
            this.matrix2DataGridView = new System.Windows.Forms.DataGridView();
            this.matrix1DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colM2Label = new System.Windows.Forms.Label();
            this.colM2TextBox = new System.Windows.Forms.TextBox();
            this.rowM1Label = new System.Windows.Forms.Label();
            this.rowM1TextBox = new System.Windows.Forms.TextBox();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.rowM2Label = new System.Windows.Forms.Label();
            this.rowM2TextBox = new System.Windows.Forms.TextBox();
            this.colM1Label = new System.Windows.Forms.Label();
            this.colM1TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixResDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MulMatrix";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.matrixResDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.matrix2DataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.matrix1DataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resTextBox);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(986, 586);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // matrixResDataGridView
            // 
            this.matrixResDataGridView.AllowUserToAddRows = false;
            this.matrixResDataGridView.AllowUserToDeleteRows = false;
            this.matrixResDataGridView.AllowUserToResizeColumns = false;
            this.matrixResDataGridView.AllowUserToResizeRows = false;
            this.matrixResDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixResDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.matrixResDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixResDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixResDataGridView.ColumnHeadersVisible = false;
            this.matrixResDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.matrixResDataGridView.Location = new System.Drawing.Point(480, 32);
            this.matrixResDataGridView.MultiSelect = false;
            this.matrixResDataGridView.Name = "matrixResDataGridView";
            this.matrixResDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixResDataGridView.RowHeadersVisible = false;
            this.matrixResDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixResDataGridView.Size = new System.Drawing.Size(240, 175);
            this.matrixResDataGridView.TabIndex = 2;
            this.matrixResDataGridView.TabStop = false;
            this.matrixResDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixDataGridView_EditingControlShowing);
            // 
            // matrix2DataGridView
            // 
            this.matrix2DataGridView.AllowUserToAddRows = false;
            this.matrix2DataGridView.AllowUserToDeleteRows = false;
            this.matrix2DataGridView.AllowUserToResizeColumns = false;
            this.matrix2DataGridView.AllowUserToResizeRows = false;
            this.matrix2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrix2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.matrix2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2DataGridView.ColumnHeadersVisible = false;
            this.matrix2DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.matrix2DataGridView.Location = new System.Drawing.Point(240, 32);
            this.matrix2DataGridView.MultiSelect = false;
            this.matrix2DataGridView.Name = "matrix2DataGridView";
            this.matrix2DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix2DataGridView.RowHeadersVisible = false;
            this.matrix2DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix2DataGridView.Size = new System.Drawing.Size(240, 175);
            this.matrix2DataGridView.TabIndex = 5;
            this.matrix2DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixDataGridView_EditingControlShowing);
            // 
            // matrix1DataGridView
            // 
            this.matrix1DataGridView.AllowUserToAddRows = false;
            this.matrix1DataGridView.AllowUserToDeleteRows = false;
            this.matrix1DataGridView.AllowUserToResizeColumns = false;
            this.matrix1DataGridView.AllowUserToResizeRows = false;
            this.matrix1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrix1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.matrix1DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1DataGridView.ColumnHeadersVisible = false;
            this.matrix1DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.matrix1DataGridView.Location = new System.Drawing.Point(0, 32);
            this.matrix1DataGridView.MultiSelect = false;
            this.matrix1DataGridView.Name = "matrix1DataGridView";
            this.matrix1DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix1DataGridView.RowHeadersVisible = false;
            this.matrix1DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix1DataGridView.Size = new System.Drawing.Size(240, 175);
            this.matrix1DataGridView.TabIndex = 4;
            this.matrix1DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixDataGridView_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.swapButton);
            this.panel1.Controls.Add(this.colM2Label);
            this.panel1.Controls.Add(this.colM2TextBox);
            this.panel1.Controls.Add(this.rowM1Label);
            this.panel1.Controls.Add(this.rowM1TextBox);
            this.panel1.Controls.Add(this.multiplicationButton);
            this.panel1.Controls.Add(this.rowM2Label);
            this.panel1.Controls.Add(this.rowM2TextBox);
            this.panel1.Controls.Add(this.colM1Label);
            this.panel1.Controls.Add(this.colM1TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 32);
            this.panel1.TabIndex = 3;
            // 
            // colM2Label
            // 
            this.colM2Label.Location = new System.Drawing.Point(292, 8);
            this.colM2Label.Name = "colM2Label";
            this.colM2Label.Size = new System.Drawing.Size(32, 14);
            this.colM2Label.TabIndex = 8;
            this.colM2Label.Text = "Col2:";
            // 
            // colM2TextBox
            // 
            this.colM2TextBox.Location = new System.Drawing.Point(330, 5);
            this.colM2TextBox.Multiline = true;
            this.colM2TextBox.Name = "colM2TextBox";
            this.colM2TextBox.Size = new System.Drawing.Size(56, 22);
            this.colM2TextBox.TabIndex = 3;
            this.colM2TextBox.TextChanged += new System.EventHandler(this.colM2TextBox_TextChanged);
            // 
            // rowM1Label
            // 
            this.rowM1Label.Location = new System.Drawing.Point(117, 8);
            this.rowM1Label.Name = "rowM1Label";
            this.rowM1Label.Size = new System.Drawing.Size(45, 14);
            this.rowM1Label.TabIndex = 6;
            this.rowM1Label.Text = "Row1:";
            // 
            // rowM1TextBox
            // 
            this.rowM1TextBox.Location = new System.Drawing.Point(168, 5);
            this.rowM1TextBox.Multiline = true;
            this.rowM1TextBox.Name = "rowM1TextBox";
            this.rowM1TextBox.Size = new System.Drawing.Size(56, 22);
            this.rowM1TextBox.TabIndex = 1;
            this.rowM1TextBox.TextChanged += new System.EventHandler(this.rowM1TextBox_TextChanged);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicationButton.Location = new System.Drawing.Point(499, 7);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(90, 22);
            this.multiplicationButton.TabIndex = 5;
            this.multiplicationButton.Text = "Multiplication";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            this.multiplicationButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.multiplicationButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // rowM2Label
            // 
            this.rowM2Label.Location = new System.Drawing.Point(392, 10);
            this.rowM2Label.Name = "rowM2Label";
            this.rowM2Label.Size = new System.Drawing.Size(45, 14);
            this.rowM2Label.TabIndex = 3;
            this.rowM2Label.Text = "Row2:";
            // 
            // rowM2TextBox
            // 
            this.rowM2TextBox.Location = new System.Drawing.Point(437, 7);
            this.rowM2TextBox.Multiline = true;
            this.rowM2TextBox.Name = "rowM2TextBox";
            this.rowM2TextBox.Size = new System.Drawing.Size(56, 22);
            this.rowM2TextBox.TabIndex = 4;
            this.rowM2TextBox.TextChanged += new System.EventHandler(this.rowM2TextBox_TextChanged);
            // 
            // colM1Label
            // 
            this.colM1Label.Location = new System.Drawing.Point(10, 10);
            this.colM1Label.Name = "colM1Label";
            this.colM1Label.Size = new System.Drawing.Size(45, 14);
            this.colM1Label.TabIndex = 1;
            this.colM1Label.Text = "Col1:";
            // 
            // colM1TextBox
            // 
            this.colM1TextBox.Location = new System.Drawing.Point(55, 7);
            this.colM1TextBox.Multiline = true;
            this.colM1TextBox.Name = "colM1TextBox";
            this.colM1TextBox.Size = new System.Drawing.Size(56, 22);
            this.colM1TextBox.TabIndex = 0;
            this.colM1TextBox.TextChanged += new System.EventHandler(this.colM1TextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(965, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 22);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // swapButton
            // 
            this.swapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swapButton.Location = new System.Drawing.Point(230, 5);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(56, 22);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // resTextBox
            // 
            this.resTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resTextBox.Location = new System.Drawing.Point(0, 0);
            this.resTextBox.Multiline = true;
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.ReadOnly = true;
            this.resTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resTextBox.Size = new System.Drawing.Size(986, 375);
            this.resTextBox.TabIndex = 0;
            this.resTextBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrixResDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox colM1TextBox;
        private System.Windows.Forms.DataGridView matrixResDataGridView;
        private System.Windows.Forms.DataGridView matrix2DataGridView;
        private System.Windows.Forms.DataGridView matrix1DataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label colM1Label;
        private System.Windows.Forms.Label rowM2Label;
        private System.Windows.Forms.TextBox rowM2TextBox;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Label rowM1Label;
        private System.Windows.Forms.TextBox rowM1TextBox;
        private System.Windows.Forms.Label colM2Label;
        private System.Windows.Forms.TextBox colM2TextBox;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.TextBox resTextBox;
    }
}

