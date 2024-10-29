namespace Purchasing_Management_System
{
    partial class UserManagementFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboBU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.radSubAdmin = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelForDatagrideView = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboActiveUser = new System.Windows.Forms.ComboBox();
            this.cboFilterBU = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelForDatagrideView.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 313);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.panel1.Size = new System.Drawing.Size(1076, 317);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cboBU);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.radUser);
            this.panel2.Controls.Add(this.radSubAdmin);
            this.panel2.Controls.Add(this.radAdmin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPosition);
            this.panel2.Location = new System.Drawing.Point(554, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 287);
            this.panel2.TabIndex = 17;
            // 
            // cboBU
            // 
            this.cboBU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBU.FormattingEnabled = true;
            this.cboBU.Location = new System.Drawing.Point(150, 63);
            this.cboBU.Name = "cboBU";
            this.cboBU.Size = new System.Drawing.Size(314, 28);
            this.cboBU.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Business Unit";
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUser.Location = new System.Drawing.Point(361, 171);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(58, 24);
            this.radUser.TabIndex = 16;
            this.radUser.TabStop = true;
            this.radUser.Text = "User";
            this.radUser.UseVisualStyleBackColor = true;
            this.radUser.CheckedChanged += new System.EventHandler(this.radUser_CheckedChanged);
            // 
            // radSubAdmin
            // 
            this.radSubAdmin.AutoSize = true;
            this.radSubAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radSubAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSubAdmin.Location = new System.Drawing.Point(242, 171);
            this.radSubAdmin.Name = "radSubAdmin";
            this.radSubAdmin.Size = new System.Drawing.Size(102, 24);
            this.radSubAdmin.TabIndex = 15;
            this.radSubAdmin.TabStop = true;
            this.radSubAdmin.Text = "Sub Admin";
            this.radSubAdmin.UseVisualStyleBackColor = true;
            this.radSubAdmin.CheckedChanged += new System.EventHandler(this.radSubAdmin_CheckedChanged);
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.Location = new System.Drawing.Point(150, 171);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(73, 24);
            this.radAdmin.TabIndex = 14;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            this.radAdmin.CheckedChanged += new System.EventHandler(this.radAdmin_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Position And Role";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(19, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 1);
            this.panel3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(150, 132);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(314, 27);
            this.txtPosition.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtUserID);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.txtName);
            this.panel8.Controls.Add(this.txtConfirm);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.txtPw);
            this.panel8.Location = new System.Drawing.Point(12, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(531, 287);
            this.panel8.TabIndex = 16;
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
            this.panel9.Size = new System.Drawing.Size(497, 1);
            this.panel9.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(176, 66);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(303, 27);
            this.txtUserID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(176, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(176, 223);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(303, 27);
            this.txtConfirm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm";
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.Location = new System.Drawing.Point(176, 171);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(303, 27);
            this.txtPw.TabIndex = 5;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panelForDatagrideView);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1076, 406);
            this.panel4.TabIndex = 6;
            // 
            // panelForDatagrideView
            // 
            this.panelForDatagrideView.Controls.Add(this.dataGridView1);
            this.panelForDatagrideView.Location = new System.Drawing.Point(12, 47);
            this.panelForDatagrideView.Name = "panelForDatagrideView";
            this.panelForDatagrideView.Size = new System.Drawing.Size(1052, 313);
            this.panelForDatagrideView.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblTotalRows);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblPageNumber);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.btnNextPage);
            this.panel6.Controls.Add(this.btnFirstPage);
            this.panel6.Controls.Add(this.btnBackPage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 362);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1076, 44);
            this.panel6.TabIndex = 9;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Rows:";
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(955, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Page";
            this.label9.Visible = false;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.cboActiveUser);
            this.panel5.Controls.Add(this.cboFilterBU);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1076, 41);
            this.panel5.TabIndex = 8;
            // 
            // cboActiveUser
            // 
            this.cboActiveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboActiveUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActiveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActiveUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActiveUser.FormattingEnabled = true;
            this.cboActiveUser.Items.AddRange(new object[] {
            "Active User",
            "Inactive User"});
            this.cboActiveUser.Location = new System.Drawing.Point(211, 7);
            this.cboActiveUser.Name = "cboActiveUser";
            this.cboActiveUser.Size = new System.Drawing.Size(191, 28);
            this.cboActiveUser.TabIndex = 7;
            this.cboActiveUser.SelectedIndexChanged += new System.EventHandler(this.cboActiveUser_SelectedIndexChanged);
            // 
            // cboFilterBU
            // 
            this.cboFilterBU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFilterBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterBU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterBU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterBU.FormattingEnabled = true;
            this.cboFilterBU.Items.AddRange(new object[] {
            "All BU"});
            this.cboFilterBU.Location = new System.Drawing.Point(14, 7);
            this.cboFilterBU.Name = "cboFilterBU";
            this.cboFilterBU.Size = new System.Drawing.Size(191, 28);
            this.cboFilterBU.TabIndex = 6;
            this.cboFilterBU.SelectedIndexChanged += new System.EventHandler(this.cboFilterBU_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 74.8663F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "User ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 109.225F;
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 95.2685F;
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 134.8346F;
            this.Column4.HeaderText = "Position";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 95.2685F;
            this.Column5.HeaderText = "Role";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 95.2685F;
            this.Column7.HeaderText = "BU";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.FillWeight = 95.2685F;
            this.Column6.HeaderText = "Deactivated";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // UserManagementFrm
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
            this.Name = "UserManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserManagementFrm";
            this.Load += new System.EventHandler(this.UserManagementFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelForDatagrideView.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
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
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.RadioButton radSubAdmin;
        private System.Windows.Forms.ToolStripButton btnToolDeactivate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboActiveUser;
        private System.Windows.Forms.ComboBox cboFilterBU;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lblTotalRows;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblPageNumber;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnNextPage;
        public System.Windows.Forms.Button btnFirstPage;
        public System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Panel panelForDatagrideView;
        private System.Windows.Forms.ToolStripButton btnToolActivate;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}