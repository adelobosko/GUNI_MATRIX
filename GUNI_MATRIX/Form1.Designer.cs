namespace GUNI_MATRIX
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
            this.sizeM2Label = new System.Windows.Forms.Label();
            this.sizeM2TextBox = new System.Windows.Forms.TextBox();
            this.sizeM1Label = new System.Windows.Forms.Label();
            this.sizeM1TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 618);
            this.tabControl1.TabIndex = 0;
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
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(986, 586);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
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
            this.matrix2DataGridView.TabIndex = 1;
            this.matrix2DataGridView.TabStop = false;
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
            this.matrix1DataGridView.TabIndex = 0;
            this.matrix1DataGridView.TabStop = false;
            this.matrix1DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixDataGridView_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.sizeM2Label);
            this.panel1.Controls.Add(this.sizeM2TextBox);
            this.panel1.Controls.Add(this.sizeM1Label);
            this.panel1.Controls.Add(this.sizeM1TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 32);
            this.panel1.TabIndex = 3;
            // 
            // sizeM2Label
            // 
            this.sizeM2Label.Location = new System.Drawing.Point(120, 10);
            this.sizeM2Label.Name = "sizeM2Label";
            this.sizeM2Label.Size = new System.Drawing.Size(45, 14);
            this.sizeM2Label.TabIndex = 3;
            this.sizeM2Label.Text = "SizeM2:";
            // 
            // sizeM2TextBox
            // 
            this.sizeM2TextBox.Location = new System.Drawing.Point(165, 7);
            this.sizeM2TextBox.Multiline = true;
            this.sizeM2TextBox.Name = "sizeM2TextBox";
            this.sizeM2TextBox.Size = new System.Drawing.Size(56, 22);
            this.sizeM2TextBox.TabIndex = 2;
            this.sizeM2TextBox.TextChanged += new System.EventHandler(this.sizeM2TextBox_TextChanged);
            // 
            // sizeM1Label
            // 
            this.sizeM1Label.Location = new System.Drawing.Point(10, 10);
            this.sizeM1Label.Name = "sizeM1Label";
            this.sizeM1Label.Size = new System.Drawing.Size(45, 14);
            this.sizeM1Label.TabIndex = 1;
            this.sizeM1Label.Text = "SizeM1:";
            // 
            // sizeM1TextBox
            // 
            this.sizeM1TextBox.Location = new System.Drawing.Point(55, 7);
            this.sizeM1TextBox.Multiline = true;
            this.sizeM1TextBox.Name = "sizeM1TextBox";
            this.sizeM1TextBox.Size = new System.Drawing.Size(56, 22);
            this.sizeM1TextBox.TabIndex = 0;
            this.sizeM1TextBox.TextChanged += new System.EventHandler(this.sizeM1TextBox_TextChanged);
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
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox sizeM1TextBox;
        private System.Windows.Forms.DataGridView matrixResDataGridView;
        private System.Windows.Forms.DataGridView matrix2DataGridView;
        private System.Windows.Forms.DataGridView matrix1DataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label sizeM1Label;
        private System.Windows.Forms.Label sizeM2Label;
        private System.Windows.Forms.TextBox sizeM2TextBox;
    }
}

