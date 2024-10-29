namespace Purchasing_Management_System
{
    partial class CategoryManagementFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTypeOfCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cboCatClass = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnToolAdd = new System.Windows.Forms.ToolStripButton();
            this.btnToolEdit = new System.Windows.Forms.ToolStripButton();
            this.btnToolDelete = new System.Windows.Forms.ToolStripButton();
            this.btnToolActivate = new System.Windows.Forms.ToolStripButton();
            this.btnToolDeactivate = new System.Windows.Forms.ToolStripButton();
            this.btnToolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTools = new System.Windows.Forms.ToolStripSplitButton();
            this.toolExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImport = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForDatagridViewCategory = new System.Windows.Forms.Panel();
            this.cboFilterCategory = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboActiveCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelForDatagridViewCategory.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 348);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 77.0922F;
            this.Column1.HeaderText = "Category No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 100.8623F;
            this.Column2.HeaderText = "Category Class";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 100.8623F;
            this.Column3.HeaderText = "Category Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Types";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 120.3209F;
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Blue;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column6.FillWeight = 100.8623F;
            this.Column6.HeaderText = "Deactivated";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 283);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cboTypeOfCategory);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCatDesc);
            this.panel2.Location = new System.Drawing.Point(553, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 253);
            this.panel2.TabIndex = 17;
            // 
            // cboTypeOfCategory
            // 
            this.cboTypeOfCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTypeOfCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeOfCategory.FormattingEnabled = true;
            this.cboTypeOfCategory.Items.AddRange(new object[] {
            "IT",
            "OE",
            "FU",
            "GS",
            "STN",
            "STFA"});
            this.cboTypeOfCategory.Location = new System.Drawing.Point(139, 74);
            this.cboTypeOfCategory.Name = "cboTypeOfCategory";
            this.cboTypeOfCategory.Size = new System.Drawing.Size(311, 28);
            this.cboTypeOfCategory.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Types";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category Description";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(19, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 1);
            this.panel3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatDesc.Location = new System.Drawing.Point(139, 131);
            this.txtCatDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(314, 82);
            this.txtCatDesc.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.cboCatClass);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtCatNo);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.txtCatName);
            this.panel8.Location = new System.Drawing.Point(14, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(530, 253);
            this.panel8.TabIndex = 16;
            // 
            // cboCatClass
            // 
            this.cboCatClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCatClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatClass.FormattingEnabled = true;
            this.cboCatClass.Items.AddRange(new object[] {
            "Goods",
            "Services"});
            this.cboCatClass.Location = new System.Drawing.Point(175, 130);
            this.cboCatClass.Name = "cboCatClass";
            this.cboCatClass.Size = new System.Drawing.Size(311, 28);
            this.cboCatClass.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "General Information";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(19, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(496, 1);
            this.panel9.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category No.";
            // 
            // txtCatNo
            // 
            this.txtCatNo.Enabled = false;
            this.txtCatNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatNo.Location = new System.Drawing.Point(175, 75);
            this.txtCatNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatNo.Name = "txtCatNo";
            this.txtCatNo.Size = new System.Drawing.Size(311, 27);
            this.txtCatNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category Name";
            // 
            // txtCatName
            // 
            this.txtCatName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(175, 182);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(311, 27);
            this.txtCatName.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnToolAdd,
            this.btnToolEdit,
            this.btnToolDelete,
            this.btnToolActivate,
            this.btnToolDeactivate,
            this.btnToolSearch,
            this.toolStripSeparator1,
            this.btnTools});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 5, 1, 5);
            this.toolStrip1.Size = new System.Drawing.Size(1076, 37);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Purchasing_Management_System.Properties.Resources.refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 24);
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnToolAdd
            // 
            this.btnToolAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolAdd.Image = global::Purchasing_Management_System.Properties.Resources.plus__2_;
            this.btnToolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolAdd.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolAdd.Name = "btnToolAdd";
            this.btnToolAdd.Size = new System.Drawing.Size(99, 24);
            this.btnToolAdd.Text = " Add New";
            this.btnToolAdd.Click += new System.EventHandler(this.btnToolAdd_Click);
            // 
            // btnToolEdit
            // 
            this.btnToolEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolEdit.Image = global::Purchasing_Management_System.Properties.Resources.pencil;
            this.btnToolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolEdit.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolEdit.Name = "btnToolEdit";
            this.btnToolEdit.Size = new System.Drawing.Size(67, 24);
            this.btnToolEdit.Text = "  Edit";
            this.btnToolEdit.Click += new System.EventHandler(this.btnToolEdit_Click_1);
            // 
            // btnToolDelete
            // 
            this.btnToolDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolDelete.Image = global::Purchasing_Management_System.Properties.Resources.trash;
            this.btnToolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolDelete.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolDelete.Name = "btnToolDelete";
            this.btnToolDelete.Size = new System.Drawing.Size(85, 24);
            this.btnToolDelete.Text = "  Delete";
            this.btnToolDelete.Click += new System.EventHandler(this.btnToolDelete_Click);
            // 
            // btnToolActivate
            // 
            this.btnToolActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolActivate.Image = global::Purchasing_Management_System.Properties.Resources.unlock;
            this.btnToolActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolActivate.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolActivate.Name = "btnToolActivate";
            this.btnToolActivate.Size = new System.Drawing.Size(95, 24);
            this.btnToolActivate.Text = "  Activate";
            this.btnToolActivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToolActivate.Click += new System.EventHandler(this.btnToolActivate_Click);
            // 
            // btnToolDeactivate
            // 
            this.btnToolDeactivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolDeactivate.Image = global::Purchasing_Management_System.Properties.Resources.ban__1_;
            this.btnToolDeactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolDeactivate.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolDeactivate.Name = "btnToolDeactivate";
            this.btnToolDeactivate.Size = new System.Drawing.Size(112, 24);
            this.btnToolDeactivate.Text = "  Deactivate";
            this.btnToolDeactivate.Click += new System.EventHandler(this.btnToolDeactivate_Click);
            // 
            // btnToolSearch
            // 
            this.btnToolSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolSearch.Image = global::Purchasing_Management_System.Properties.Resources.search;
            this.btnToolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolSearch.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnToolSearch.Name = "btnToolSearch";
            this.btnToolSearch.Size = new System.Drawing.Size(85, 24);
            this.btnToolSearch.Text = "  Search";
            this.btnToolSearch.Click += new System.EventHandler(this.btnToolSearch_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnTools
            // 
            this.btnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExport,
            this.toolImport});
            this.btnTools.Image = global::Purchasing_Management_System.Properties.Resources.tools;
            this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTools.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(91, 24);
            this.btnTools.Text = "  Tools";
            // 
            // toolExport
            // 
            this.toolExport.Name = "toolExport";
            this.toolExport.Size = new System.Drawing.Size(175, 26);
            this.toolExport.Text = "Export Excel";
            // 
            // toolImport
            // 
            this.toolImport.Name = "toolImport";
            this.toolImport.Size = new System.Drawing.Size(175, 26);
            this.toolImport.Text = "Import Excel";
            // 
            // panelForDatagridViewCategory
            // 
            this.panelForDatagridViewCategory.Controls.Add(this.dataGridView1);
            this.panelForDatagridViewCategory.Location = new System.Drawing.Point(14, 47);
            this.panelForDatagridViewCategory.Name = "panelForDatagridViewCategory";
            this.panelForDatagridViewCategory.Size = new System.Drawing.Size(1050, 348);
            this.panelForDatagridViewCategory.TabIndex = 6;
            // 
            // cboFilterCategory
            // 
            this.cboFilterCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterCategory.FormattingEnabled = true;
            this.cboFilterCategory.Items.AddRange(new object[] {
            "All Category",
            "Goods",
            "Services"});
            this.cboFilterCategory.Location = new System.Drawing.Point(14, 7);
            this.cboFilterCategory.Name = "cboFilterCategory";
            this.cboFilterCategory.Size = new System.Drawing.Size(191, 28);
            this.cboFilterCategory.TabIndex = 6;
            this.cboFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cboFilterCategory_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboActiveCategory);
            this.panel5.Controls.Add(this.cboFilterCategory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1076, 41);
            this.panel5.TabIndex = 7;
            // 
            // cboActiveCategory
            // 
            this.cboActiveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboActiveCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActiveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActiveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActiveCategory.FormattingEnabled = true;
            this.cboActiveCategory.Items.AddRange(new object[] {
            "Active Category",
            "Inactive Category"});
            this.cboActiveCategory.Location = new System.Drawing.Point(211, 7);
            this.cboActiveCategory.Name = "cboActiveCategory";
            this.cboActiveCategory.Size = new System.Drawing.Size(191, 28);
            this.cboActiveCategory.TabIndex = 7;
            this.cboActiveCategory.SelectedIndexChanged += new System.EventHandler(this.cboActiveCategory_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panelForDatagridViewCategory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1076, 440);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblTotalRows);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lblPageNumber);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.btnNextPage);
            this.panel6.Controls.Add(this.btnFirstPage);
            this.panel6.Controls.Add(this.btnBackPage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 396);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1076, 44);
            this.panel6.TabIndex = 8;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(96, 12);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(14, 16);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Rows:";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(994, 12);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(14, 16);
            this.lblPageNumber.TabIndex = 4;
            this.lblPageNumber.Text = "0";
            this.lblPageNumber.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(955, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Page";
            this.label7.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Image = global::Purchasing_Management_System.Properties.Resources.arrow_small_right;
            this.btnNextPage.Location = new System.Drawing.Point(1014, 9);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 23);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Visible = false;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstPage.BackColor = System.Drawing.Color.White;
            this.btnFirstPage.FlatAppearance.BorderSize = 0;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Image = global::Purchasing_Management_System.Properties.Resources.angle_double_small_left;
            this.btnFirstPage.Location = new System.Drawing.Point(873, 9);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(35, 23);
            this.btnFirstPage.TabIndex = 1;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Visible = false;
            // 
            // btnBackPage
            // 
            this.btnBackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackPage.BackColor = System.Drawing.Color.White;
            this.btnBackPage.FlatAppearance.BorderSize = 0;
            this.btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackPage.Image = global::Purchasing_Management_System.Properties.Resources.arrow_small_left__1_;
            this.btnBackPage.Location = new System.Drawing.Point(914, 9);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(35, 23);
            this.btnBackPage.TabIndex = 0;
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Visible = false;
            // 
            // CategoryManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1076, 760);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CategoryManagementFrm";
            this.Load += new System.EventHandler(this.CategoryManagementFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelForDatagridViewCategory.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToolAdd;
        private System.Windows.Forms.ToolStripButton btnToolEdit;
        private System.Windows.Forms.ToolStripButton btnToolDelete;
        private System.Windows.Forms.ToolStripButton btnToolSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton btnTools;
        private System.Windows.Forms.ToolStripMenuItem toolExport;
        private System.Windows.Forms.ToolStripMenuItem toolImport;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ToolStripButton btnToolDeactivate;
        private System.Windows.Forms.Panel panelForDatagridViewCategory;
        private System.Windows.Forms.ComboBox cboFilterCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripButton btnToolActivate;
        private System.Windows.Forms.ComboBox cboCatClass;
        private System.Windows.Forms.ComboBox cboActiveCategory;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lblTotalRows;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblPageNumber;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnNextPage;
        public System.Windows.Forms.Button btnFirstPage;
        public System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTypeOfCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripButton btnRefresh;
    }
}