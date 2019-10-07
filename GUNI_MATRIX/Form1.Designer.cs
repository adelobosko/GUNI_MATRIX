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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.matrixResDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToMatrix1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToMatrix2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrix2DataGridView = new System.Windows.Forms.DataGridView();
            this.matrix1DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mulOnDigitButton = new System.Windows.Forms.Button();
            this.transponationButton = new System.Windows.Forms.Button();
            this.aliedButton = new System.Windows.Forms.Button();
            this.detButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.colM2Label = new System.Windows.Forms.Label();
            this.colM2TextBox = new System.Windows.Forms.TextBox();
            this.rowM1Label = new System.Windows.Forms.Label();
            this.rowM1TextBox = new System.Windows.Forms.TextBox();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.rowM2Label = new System.Windows.Forms.Label();
            this.rowM2TextBox = new System.Windows.Forms.TextBox();
            this.colM1Label = new System.Windows.Forms.Label();
            this.colM1TextBox = new System.Windows.Forms.TextBox();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.resJordansTextBox = new System.Windows.Forms.TextBox();
            this.matrix3DataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.exceptButton = new System.Windows.Forms.Button();
            this.row3Label = new System.Windows.Forms.Label();
            this.row3TextBox = new System.Windows.Forms.TextBox();
            this.col3Label = new System.Windows.Forms.Label();
            this.col3TextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.doubleToResMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixResDataGridView)).BeginInit();
            this.dataGridContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix3DataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tabPage1.Text = "MatrixBase";
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
            this.matrixResDataGridView.ContextMenuStrip = this.dataGridContextMenuStrip;
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
            // dataGridContextMenuStrip
            // 
            this.dataGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToMatrix1ToolStripMenuItem,
            this.sendToMatrix2ToolStripMenuItem,
            this.doubleToResMatrixToolStripMenuItem});
            this.dataGridContextMenuStrip.Name = "dataGridContextMenuStrip";
            this.dataGridContextMenuStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // sendToMatrix1ToolStripMenuItem
            // 
            this.sendToMatrix1ToolStripMenuItem.Name = "sendToMatrix1ToolStripMenuItem";
            this.sendToMatrix1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendToMatrix1ToolStripMenuItem.Text = "SendToMatrix1";
            this.sendToMatrix1ToolStripMenuItem.Click += new System.EventHandler(this.sendToMatrix1ToolStripMenuItem_Click);
            // 
            // sendToMatrix2ToolStripMenuItem
            // 
            this.sendToMatrix2ToolStripMenuItem.Name = "sendToMatrix2ToolStripMenuItem";
            this.sendToMatrix2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendToMatrix2ToolStripMenuItem.Text = "SendToMatrix2";
            this.sendToMatrix2ToolStripMenuItem.Click += new System.EventHandler(this.sendToMatrix2ToolStripMenuItem_Click);
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
            this.matrix2DataGridView.ContextMenuStrip = this.dataGridContextMenuStrip;
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
            this.matrix1DataGridView.ContextMenuStrip = this.dataGridContextMenuStrip;
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
            this.panel1.Controls.Add(this.mulOnDigitButton);
            this.panel1.Controls.Add(this.transponationButton);
            this.panel1.Controls.Add(this.aliedButton);
            this.panel1.Controls.Add(this.detButton);
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
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(986, 32);
            this.panel1.TabIndex = 3;
            // 
            // mulOnDigitButton
            // 
            this.mulOnDigitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulOnDigitButton.Location = new System.Drawing.Point(883, 7);
            this.mulOnDigitButton.Name = "mulOnDigitButton";
            this.mulOnDigitButton.Size = new System.Drawing.Size(90, 22);
            this.mulOnDigitButton.TabIndex = 9;
            this.mulOnDigitButton.Text = "MulOnFraction";
            this.mulOnDigitButton.UseVisualStyleBackColor = true;
            this.mulOnDigitButton.Click += new System.EventHandler(this.mulOnDigitButton_Click);
            this.mulOnDigitButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.mulOnDigitButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // transponationButton
            // 
            this.transponationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transponationButton.Location = new System.Drawing.Point(787, 7);
            this.transponationButton.Name = "transponationButton";
            this.transponationButton.Size = new System.Drawing.Size(90, 22);
            this.transponationButton.TabIndex = 9;
            this.transponationButton.Text = "Transponation";
            this.transponationButton.UseVisualStyleBackColor = true;
            this.transponationButton.Click += new System.EventHandler(this.transponationButton_Click);
            this.transponationButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.transponationButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // aliedButton
            // 
            this.aliedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aliedButton.Location = new System.Drawing.Point(691, 7);
            this.aliedButton.Name = "aliedButton";
            this.aliedButton.Size = new System.Drawing.Size(90, 22);
            this.aliedButton.TabIndex = 9;
            this.aliedButton.Text = "Allied";
            this.aliedButton.UseVisualStyleBackColor = true;
            this.aliedButton.Click += new System.EventHandler(this.aliedButton_Click);
            this.aliedButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.aliedButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // detButton
            // 
            this.detButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detButton.Location = new System.Drawing.Point(595, 7);
            this.detButton.Name = "detButton";
            this.detButton.Size = new System.Drawing.Size(90, 22);
            this.detButton.TabIndex = 9;
            this.detButton.Text = "Determinant";
            this.detButton.UseVisualStyleBackColor = true;
            this.detButton.Click += new System.EventHandler(this.detButton_Click);
            this.detButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.detButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // swapButton
            // 
            this.swapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swapButton.Location = new System.Drawing.Point(230, 7);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(56, 22);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.swapButton_Click);
            // 
            // colM2Label
            // 
            this.colM2Label.Location = new System.Drawing.Point(292, 10);
            this.colM2Label.Name = "colM2Label";
            this.colM2Label.Size = new System.Drawing.Size(32, 14);
            this.colM2Label.TabIndex = 8;
            this.colM2Label.Text = "Col2:";
            // 
            // colM2TextBox
            // 
            this.colM2TextBox.Location = new System.Drawing.Point(330, 7);
            this.colM2TextBox.Multiline = true;
            this.colM2TextBox.Name = "colM2TextBox";
            this.colM2TextBox.Size = new System.Drawing.Size(56, 22);
            this.colM2TextBox.TabIndex = 3;
            this.colM2TextBox.TextChanged += new System.EventHandler(this.colM2TextBox_TextChanged);
            // 
            // rowM1Label
            // 
            this.rowM1Label.Location = new System.Drawing.Point(117, 10);
            this.rowM1Label.Name = "rowM1Label";
            this.rowM1Label.Size = new System.Drawing.Size(45, 14);
            this.rowM1Label.TabIndex = 6;
            this.rowM1Label.Text = "Row1:";
            // 
            // rowM1TextBox
            // 
            this.rowM1TextBox.Location = new System.Drawing.Point(168, 7);
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
            this.multiplicationButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.multiplicationButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jordan\'sExceptions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 36);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.resJordansTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.matrix3DataGridView);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(986, 553);
            this.splitContainer2.SplitterDistance = 173;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // resJordansTextBox
            // 
            this.resJordansTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resJordansTextBox.Location = new System.Drawing.Point(0, 232);
            this.resJordansTextBox.Multiline = true;
            this.resJordansTextBox.Name = "resJordansTextBox";
            this.resJordansTextBox.ReadOnly = true;
            this.resJordansTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resJordansTextBox.Size = new System.Drawing.Size(173, 321);
            this.resJordansTextBox.TabIndex = 1;
            this.resJordansTextBox.TabStop = false;
            // 
            // matrix3DataGridView
            // 
            this.matrix3DataGridView.AllowUserToAddRows = false;
            this.matrix3DataGridView.AllowUserToDeleteRows = false;
            this.matrix3DataGridView.AllowUserToResizeColumns = false;
            this.matrix3DataGridView.AllowUserToResizeRows = false;
            this.matrix3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrix3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.matrix3DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix3DataGridView.ColumnHeadersVisible = false;
            this.matrix3DataGridView.ContextMenuStrip = this.dataGridContextMenuStrip;
            this.matrix3DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.matrix3DataGridView.Location = new System.Drawing.Point(0, 0);
            this.matrix3DataGridView.MultiSelect = false;
            this.matrix3DataGridView.Name = "matrix3DataGridView";
            this.matrix3DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrix3DataGridView.RowHeadersVisible = false;
            this.matrix3DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix3DataGridView.Size = new System.Drawing.Size(173, 232);
            this.matrix3DataGridView.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 553);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 340);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.progressLabel);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.exceptButton);
            this.panel2.Controls.Add(this.row3Label);
            this.panel2.Controls.Add(this.row3TextBox);
            this.panel2.Controls.Add(this.col3Label);
            this.panel2.Controls.Add(this.col3TextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 33);
            this.panel2.TabIndex = 3;
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(617, 10);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(177, 16);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "0/100";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(350, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // exceptButton
            // 
            this.exceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exceptButton.Location = new System.Drawing.Point(230, 7);
            this.exceptButton.Name = "exceptButton";
            this.exceptButton.Size = new System.Drawing.Size(114, 22);
            this.exceptButton.TabIndex = 9;
            this.exceptButton.Text = "Jordans\'sExcept";
            this.exceptButton.UseVisualStyleBackColor = true;
            this.exceptButton.Click += new System.EventHandler(this.exceptButton_Click);
            // 
            // row3Label
            // 
            this.row3Label.Location = new System.Drawing.Point(117, 10);
            this.row3Label.Name = "row3Label";
            this.row3Label.Size = new System.Drawing.Size(45, 14);
            this.row3Label.TabIndex = 6;
            this.row3Label.Text = "Row3:";
            // 
            // row3TextBox
            // 
            this.row3TextBox.Location = new System.Drawing.Point(168, 7);
            this.row3TextBox.Multiline = true;
            this.row3TextBox.Name = "row3TextBox";
            this.row3TextBox.Size = new System.Drawing.Size(56, 22);
            this.row3TextBox.TabIndex = 1;
            this.row3TextBox.TextChanged += new System.EventHandler(this.row3TextBox_TextChanged);
            // 
            // col3Label
            // 
            this.col3Label.Location = new System.Drawing.Point(10, 10);
            this.col3Label.Name = "col3Label";
            this.col3Label.Size = new System.Drawing.Size(39, 14);
            this.col3Label.TabIndex = 1;
            this.col3Label.Text = "Col3:";
            // 
            // col3TextBox
            // 
            this.col3TextBox.Location = new System.Drawing.Point(55, 7);
            this.col3TextBox.Multiline = true;
            this.col3TextBox.Name = "col3TextBox";
            this.col3TextBox.Size = new System.Drawing.Size(56, 22);
            this.col3TextBox.TabIndex = 0;
            this.col3TextBox.TextChanged += new System.EventHandler(this.col3TextBox_TextChanged);
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
            this.closeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // doubleToResMatrixToolStripMenuItem
            // 
            this.doubleToResMatrixToolStripMenuItem.Name = "doubleToResMatrixToolStripMenuItem";
            this.doubleToResMatrixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleToResMatrixToolStripMenuItem.Text = "DoubleToResMatrix";
            this.doubleToResMatrixToolStripMenuItem.Click += new System.EventHandler(this.doubleToResMatrixToolStripMenuItem_Click);
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
            this.dataGridContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix3DataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button detButton;
        private System.Windows.Forms.Button aliedButton;
        private System.Windows.Forms.Button transponationButton;
        private System.Windows.Forms.Button mulOnDigitButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView matrix3DataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label row3Label;
        private System.Windows.Forms.TextBox row3TextBox;
        private System.Windows.Forms.Label col3Label;
        private System.Windows.Forms.TextBox col3TextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exceptButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox resJordansTextBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip dataGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sendToMatrix1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToMatrix2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToResMatrixToolStripMenuItem;
    }
}

