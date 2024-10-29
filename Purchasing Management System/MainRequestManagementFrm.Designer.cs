using System.Drawing;

namespace Purchasing_Management_System
{
    partial class MainRequestManagementFrm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCloses = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVenName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.paneltask1 = new System.Windows.Forms.Panel();
            this.txtVenNameKH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVenNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVenClass = new System.Windows.Forms.TextBox();
            this.panelTask3 = new System.Windows.Forms.Panel();
            this.txtVenEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVenMobile = new System.Windows.Forms.TextBox();
            this.panelTask2 = new System.Windows.Forms.Panel();
            this.cboIsTax = new System.Windows.Forms.ComboBox();
            this.txtTaxNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelTask = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.paneltask1.SuspendLayout();
            this.panelTask3.SuspendLayout();
            this.panelTask2.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBack,
            this.toolStripSeparator2,
            this.btnSave,
            this.btnSaveCloses,
            this.btnNew,
            this.btnEdit,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 5, 1, 5);
            this.toolStrip1.Size = new System.Drawing.Size(1640, 37);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBack
            // 
            this.btnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoBack.Image = global::Purchasing_Management_System.Properties.Resources.turn_back;
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(29, 24);
            this.btnGoBack.Text = "toolStripButton1";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Purchasing_Management_System.Properties.Resources.disk;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 24);
            this.btnSave.Text = " Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveCloses
            // 
            this.btnSaveCloses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCloses.Image = global::Purchasing_Management_System.Properties.Resources.floppy_disk_circle_arrow_right;
            this.btnSaveCloses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCloses.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSaveCloses.Name = "btnSaveCloses";
            this.btnSaveCloses.Size = new System.Drawing.Size(108, 24);
            this.btnSaveCloses.Text = " Save Close";
            this.btnSaveCloses.Click += new System.EventHandler(this.btnSaveCloses_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Purchasing_Management_System.Properties.Resources.plus__2_;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(67, 24);
            this.btnNew.Text = " New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Purchasing_Management_System.Properties.Resources.pencil;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 24);
            this.btnEdit.Text = "  Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // txtVenName
            // 
            this.txtVenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenName.Location = new System.Drawing.Point(203, 193);
            this.txtVenName.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenName.Name = "txtVenName";
            this.txtVenName.Size = new System.Drawing.Size(310, 27);
            this.txtVenName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor ID";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnDetails);
            this.panelTop.Controls.Add(this.btnSummary);
            this.panelTop.Controls.Add(this.label15);
            this.panelTop.Controls.Add(this.lblSaveStatus);
            this.panelTop.Controls.Add(this.lblVendorName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 37);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1640, 143);
            this.panelTop.TabIndex = 7;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Location = new System.Drawing.Point(112, 105);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Transparent;
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Location = new System.Drawing.Point(31, 105);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Acquisition Request Number";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.ForeColor = System.Drawing.Color.Black;
            this.lblSaveStatus.Location = new System.Drawing.Point(1529, 28);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblSaveStatus.Size = new System.Drawing.Size(59, 16);
            this.lblSaveStatus.TabIndex = 1;
            this.lblSaveStatus.Text = "Status";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVendorName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.Location = new System.Drawing.Point(25, 13);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(269, 31);
            this.lblVendorName.TabIndex = 0;
            this.lblVendorName.Text = "New Acquisiiton Request";
            // 
            // paneltask1
            // 
            this.paneltask1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltask1.BackColor = System.Drawing.Color.White;
            this.paneltask1.Controls.Add(this.txtVenNameKH);
            this.paneltask1.Controls.Add(this.label14);
            this.paneltask1.Controls.Add(this.txtVenNo);
            this.paneltask1.Controls.Add(this.label5);
            this.paneltask1.Controls.Add(this.txtVenId);
            this.paneltask1.Controls.Add(this.label8);
            this.paneltask1.Controls.Add(this.label1);
            this.paneltask1.Controls.Add(this.panel3);
            this.paneltask1.Controls.Add(this.txtVenClass);
            this.paneltask1.Controls.Add(this.label2);
            this.paneltask1.Controls.Add(this.label3);
            this.paneltask1.Controls.Add(this.txtVenName);
            this.paneltask1.Location = new System.Drawing.Point(3, 3);
            this.paneltask1.Name = "paneltask1";
            this.paneltask1.Size = new System.Drawing.Size(544, 377);
            this.paneltask1.TabIndex = 12;
            // 
            // txtVenNameKH
            // 
            this.txtVenNameKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenNameKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenNameKH.Location = new System.Drawing.Point(203, 250);
            this.txtVenNameKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenNameKH.Name = "txtVenNameKH";
            this.txtVenNameKH.Size = new System.Drawing.Size(310, 27);
            this.txtVenNameKH.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 253);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Vendor Name (KH)";
            // 
            // txtVenNo
            // 
            this.txtVenNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenNo.Enabled = false;
            this.txtVenNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenNo.Location = new System.Drawing.Point(203, 134);
            this.txtVenNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenNo.Name = "txtVenNo";
            this.txtVenNo.Size = new System.Drawing.Size(310, 27);
            this.txtVenNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vendor No.";
            // 
            // txtVenId
            // 
            this.txtVenId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenId.Enabled = false;
            this.txtVenId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenId.Location = new System.Drawing.Point(203, 78);
            this.txtVenId.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenId.Name = "txtVenId";
            this.txtVenId.Size = new System.Drawing.Size(310, 27);
            this.txtVenId.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "General";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(19, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 1);
            this.panel3.TabIndex = 13;
            // 
            // txtVenClass
            // 
            this.txtVenClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenClass.Location = new System.Drawing.Point(203, 308);
            this.txtVenClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenClass.Name = "txtVenClass";
            this.txtVenClass.Size = new System.Drawing.Size(310, 27);
            this.txtVenClass.TabIndex = 5;
            // 
            // panelTask3
            // 
            this.panelTask3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask3.BackColor = System.Drawing.Color.White;
            this.panelTask3.Controls.Add(this.txtVenEmail);
            this.panelTask3.Controls.Add(this.label9);
            this.panelTask3.Controls.Add(this.label10);
            this.panelTask3.Controls.Add(this.panel5);
            this.panelTask3.Controls.Add(this.label11);
            this.panelTask3.Controls.Add(this.txtVenMobile);
            this.panelTask3.Location = new System.Drawing.Point(1097, 3);
            this.panelTask3.Name = "panelTask3";
            this.panelTask3.Size = new System.Drawing.Size(474, 198);
            this.panelTask3.TabIndex = 14;
            // 
            // txtVenEmail
            // 
            this.txtVenEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenEmail.Location = new System.Drawing.Point(181, 78);
            this.txtVenEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenEmail.Name = "txtVenEmail";
            this.txtVenEmail.Size = new System.Drawing.Size(258, 27);
            this.txtVenEmail.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Contact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(19, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 1);
            this.panel5.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mobile Number";
            // 
            // txtVenMobile
            // 
            this.txtVenMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenMobile.Location = new System.Drawing.Point(181, 134);
            this.txtVenMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenMobile.Name = "txtVenMobile";
            this.txtVenMobile.Size = new System.Drawing.Size(258, 27);
            this.txtVenMobile.TabIndex = 3;
            // 
            // panelTask2
            // 
            this.panelTask2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask2.BackColor = System.Drawing.Color.White;
            this.panelTask2.Controls.Add(this.cboIsTax);
            this.panelTask2.Controls.Add(this.txtTaxNo);
            this.panelTask2.Controls.Add(this.label7);
            this.panelTask2.Controls.Add(this.label12);
            this.panelTask2.Controls.Add(this.label13);
            this.panelTask2.Controls.Add(this.panel9);
            this.panelTask2.Location = new System.Drawing.Point(562, 3);
            this.panelTask2.Name = "panelTask2";
            this.panelTask2.Size = new System.Drawing.Size(520, 198);
            this.panelTask2.TabIndex = 15;
            // 
            // cboIsTax
            // 
            this.cboIsTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsTax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIsTax.FormattingEnabled = true;
            this.cboIsTax.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboIsTax.Location = new System.Drawing.Point(208, 81);
            this.cboIsTax.Name = "cboIsTax";
            this.cboIsTax.Size = new System.Drawing.Size(277, 28);
            this.cboIsTax.TabIndex = 23;
            this.cboIsTax.SelectedIndexChanged += new System.EventHandler(this.cboIsTax_SelectedIndexChanged);
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxNo.Location = new System.Drawing.Point(208, 138);
            this.txtTaxNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(277, 27);
            this.txtTaxNo.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tax Registration No.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Taxable";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Taxable";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(19, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(486, 1);
            this.panel9.TabIndex = 13;
            // 
            // panelTask
            // 
            this.panelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask.Controls.Add(this.panelTask2);
            this.panelTask.Controls.Add(this.paneltask1);
            this.panelTask.Controls.Add(this.panelTask3);
            this.panelTask.Location = new System.Drawing.Point(18, 200);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1605, 465);
            this.panelTask.TabIndex = 16;
            // 
            // MainRequestManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1645, 685);
            this.ControlBox = false;
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainRequestManagementFrm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "VendorManagementFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorManagementFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.paneltask1.ResumeLayout(false);
            this.paneltask1.PerformLayout();
            this.panelTask3.ResumeLayout(false);
            this.panelTask3.PerformLayout();
            this.panelTask2.ResumeLayout(false);
            this.panelTask2.PerformLayout();
            this.panelTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel paneltask1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelTask3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnGoBack;
        public System.Windows.Forms.TextBox txtVenName;
        public System.Windows.Forms.TextBox txtVenMobile;
        public System.Windows.Forms.TextBox txtVenId;
        public System.Windows.Forms.TextBox txtVenEmail;
        public System.Windows.Forms.TextBox txtVenClass;
        public System.Windows.Forms.ToolStripButton btnNew;
        public System.Windows.Forms.ToolStripButton btnEdit;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnSaveCloses;
        public System.Windows.Forms.Label lblVendorName;
        public System.Windows.Forms.Label lblSaveStatus;
        public System.Windows.Forms.TextBox txtVenNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTask2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox txtTaxNo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtVenNameKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cboIsTax;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Panel panelTask;
    }
}