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
            this.txtRequestDesc = new System.Windows.Forms.TextBox();
            this.lablel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.cboRequestStatus = new System.Windows.Forms.ComboBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblRequestNo = new System.Windows.Forms.Label();
            this.paneltask1 = new System.Windows.Forms.Panel();
            this.btnShowAllEndorsedByUserName = new System.Windows.Forms.Button();
            this.btnShowAllApprovedByUserName = new System.Windows.Forms.Button();
            this.btnShowAllRequestedByUserName = new System.Windows.Forms.Button();
            this.dtCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cboRequestType = new System.Windows.Forms.ComboBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEndorsedBy = new System.Windows.Forms.TextBox();
            this.panelTask3 = new System.Windows.Forms.Panel();
            this.txtTotalBaseAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.txtTlAmtBeforeDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.panelTask2 = new System.Windows.Forms.Panel();
            this.cboShippingSite = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endorsed By";
            // 
            // txtRequestDesc
            // 
            this.txtRequestDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDesc.Location = new System.Drawing.Point(203, 193);
            this.txtRequestDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestDesc.Name = "txtRequestDesc";
            this.txtRequestDesc.Size = new System.Drawing.Size(310, 27);
            this.txtRequestDesc.TabIndex = 3;
            // 
            // lablel
            // 
            this.lablel.AutoSize = true;
            this.lablel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablel.Location = new System.Drawing.Point(41, 195);
            this.lablel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lablel.Name = "lablel";
            this.lablel.Size = new System.Drawing.Size(85, 20);
            this.lablel.TabIndex = 2;
            this.lablel.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARF Type";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblState);
            this.panelTop.Controls.Add(this.cboRequestStatus);
            this.panelTop.Controls.Add(this.btnDetails);
            this.panelTop.Controls.Add(this.btnSummary);
            this.panelTop.Controls.Add(this.label15);
            this.panelTop.Controls.Add(this.lblSaveStatus);
            this.panelTop.Controls.Add(this.lblRequestNo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 37);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1640, 143);
            this.panelTop.TabIndex = 7;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(1485, 67);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblState.Size = new System.Drawing.Size(53, 16);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRequestStatus
            // 
            this.cboRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRequestStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRequestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRequestStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestStatus.FormattingEnabled = true;
            this.cboRequestStatus.Items.AddRange(new object[] {
            "Open",
            "Release",
            "Completed",
            "Cancelled"});
            this.cboRequestStatus.Location = new System.Drawing.Point(1485, 31);
            this.cboRequestStatus.Name = "cboRequestStatus";
            this.cboRequestStatus.Size = new System.Drawing.Size(138, 31);
            this.cboRequestStatus.TabIndex = 5;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
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
            this.btnSummary.ForeColor = System.Drawing.Color.Black;
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
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.ForeColor = System.Drawing.Color.Black;
            this.lblSaveStatus.Location = new System.Drawing.Point(238, 48);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblSaveStatus.Size = new System.Drawing.Size(59, 16);
            this.lblSaveStatus.TabIndex = 1;
            this.lblSaveStatus.Text = "Status";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequestNo
            // 
            this.lblRequestNo.AutoSize = true;
            this.lblRequestNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRequestNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestNo.Location = new System.Drawing.Point(25, 13);
            this.lblRequestNo.Name = "lblRequestNo";
            this.lblRequestNo.Size = new System.Drawing.Size(269, 31);
            this.lblRequestNo.TabIndex = 0;
            this.lblRequestNo.Text = "New Acquisiiton Request";
            // 
            // paneltask1
            // 
            this.paneltask1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltask1.BackColor = System.Drawing.Color.White;
            this.paneltask1.Controls.Add(this.btnShowAllEndorsedByUserName);
            this.paneltask1.Controls.Add(this.btnShowAllApprovedByUserName);
            this.paneltask1.Controls.Add(this.btnShowAllRequestedByUserName);
            this.paneltask1.Controls.Add(this.dtCreatedDate);
            this.paneltask1.Controls.Add(this.cboRequestType);
            this.paneltask1.Controls.Add(this.txtReason);
            this.paneltask1.Controls.Add(this.label4);
            this.paneltask1.Controls.Add(this.txtApprovedBy);
            this.paneltask1.Controls.Add(this.label2);
            this.paneltask1.Controls.Add(this.txtRequestedBy);
            this.paneltask1.Controls.Add(this.label14);
            this.paneltask1.Controls.Add(this.label5);
            this.paneltask1.Controls.Add(this.label8);
            this.paneltask1.Controls.Add(this.label1);
            this.paneltask1.Controls.Add(this.panel3);
            this.paneltask1.Controls.Add(this.txtEndorsedBy);
            this.paneltask1.Controls.Add(this.lablel);
            this.paneltask1.Controls.Add(this.label3);
            this.paneltask1.Controls.Add(this.txtRequestDesc);
            this.paneltask1.Location = new System.Drawing.Point(3, 3);
            this.paneltask1.Name = "paneltask1";
            this.paneltask1.Size = new System.Drawing.Size(544, 499);
            this.paneltask1.TabIndex = 12;
            // 
            // btnShowAllEndorsedByUserName
            // 
            this.btnShowAllEndorsedByUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllEndorsedByUserName.FlatAppearance.BorderSize = 0;
            this.btnShowAllEndorsedByUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllEndorsedByUserName.Image = global::Purchasing_Management_System.Properties.Resources.search1;
            this.btnShowAllEndorsedByUserName.Location = new System.Drawing.Point(487, 310);
            this.btnShowAllEndorsedByUserName.Name = "btnShowAllEndorsedByUserName";
            this.btnShowAllEndorsedByUserName.Size = new System.Drawing.Size(20, 23);
            this.btnShowAllEndorsedByUserName.TabIndex = 29;
            this.btnShowAllEndorsedByUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllEndorsedByUserName.UseVisualStyleBackColor = true;
            this.btnShowAllEndorsedByUserName.Click += new System.EventHandler(this.btnShowAllEndorsedByUserName_Click);
            // 
            // btnShowAllApprovedByUserName
            // 
            this.btnShowAllApprovedByUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllApprovedByUserName.FlatAppearance.BorderSize = 0;
            this.btnShowAllApprovedByUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllApprovedByUserName.Image = global::Purchasing_Management_System.Properties.Resources.search1;
            this.btnShowAllApprovedByUserName.Location = new System.Drawing.Point(487, 367);
            this.btnShowAllApprovedByUserName.Name = "btnShowAllApprovedByUserName";
            this.btnShowAllApprovedByUserName.Size = new System.Drawing.Size(20, 23);
            this.btnShowAllApprovedByUserName.TabIndex = 28;
            this.btnShowAllApprovedByUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllApprovedByUserName.UseVisualStyleBackColor = true;
            this.btnShowAllApprovedByUserName.Click += new System.EventHandler(this.btnShowAllApprovedByUserName_Click);
            // 
            // btnShowAllRequestedByUserName
            // 
            this.btnShowAllRequestedByUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllRequestedByUserName.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllRequestedByUserName.FlatAppearance.BorderSize = 0;
            this.btnShowAllRequestedByUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllRequestedByUserName.Image = global::Purchasing_Management_System.Properties.Resources.search1;
            this.btnShowAllRequestedByUserName.Location = new System.Drawing.Point(487, 252);
            this.btnShowAllRequestedByUserName.Name = "btnShowAllRequestedByUserName";
            this.btnShowAllRequestedByUserName.Size = new System.Drawing.Size(20, 23);
            this.btnShowAllRequestedByUserName.TabIndex = 27;
            this.btnShowAllRequestedByUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllRequestedByUserName.UseVisualStyleBackColor = false;
            this.btnShowAllRequestedByUserName.Click += new System.EventHandler(this.btnShowAllRequestedByUserName_Click);
            // 
            // dtCreatedDate
            // 
            this.dtCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCreatedDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedDate.Location = new System.Drawing.Point(203, 139);
            this.dtCreatedDate.Name = "dtCreatedDate";
            this.dtCreatedDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtCreatedDate.Size = new System.Drawing.Size(310, 22);
            this.dtCreatedDate.TabIndex = 26;
            // 
            // cboRequestType
            // 
            this.cboRequestType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestType.FormattingEnabled = true;
            this.cboRequestType.Location = new System.Drawing.Point(203, 82);
            this.cboRequestType.Name = "cboRequestType";
            this.cboRequestType.Size = new System.Drawing.Size(310, 28);
            this.cboRequestType.TabIndex = 25;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(203, 422);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(310, 27);
            this.txtReason.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reason";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApprovedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedBy.Location = new System.Drawing.Point(203, 365);
            this.txtApprovedBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(310, 27);
            this.txtApprovedBy.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Approved By";
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestedBy.Location = new System.Drawing.Point(203, 250);
            this.txtRequestedBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.Size = new System.Drawing.Size(310, 27);
            this.txtRequestedBy.TabIndex = 20;
            this.txtRequestedBy.TextChanged += new System.EventHandler(this.txtRequestedBy_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 253);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Requested By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Acquisition Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Acquisition Information";
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
            // txtEndorsedBy
            // 
            this.txtEndorsedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndorsedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndorsedBy.Location = new System.Drawing.Point(203, 308);
            this.txtEndorsedBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndorsedBy.Name = "txtEndorsedBy";
            this.txtEndorsedBy.Size = new System.Drawing.Size(310, 27);
            this.txtEndorsedBy.TabIndex = 5;
            // 
            // panelTask3
            // 
            this.panelTask3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask3.BackColor = System.Drawing.Color.White;
            this.panelTask3.Controls.Add(this.txtTotalBaseAmount);
            this.panelTask3.Controls.Add(this.label13);
            this.panelTask3.Controls.Add(this.label);
            this.panelTask3.Controls.Add(this.txtTotalAmount);
            this.panelTask3.Controls.Add(this.label6);
            this.panelTask3.Controls.Add(this.txtTotalTax);
            this.panelTask3.Controls.Add(this.txtTlAmtBeforeDiscount);
            this.panelTask3.Controls.Add(this.label9);
            this.panelTask3.Controls.Add(this.label10);
            this.panelTask3.Controls.Add(this.panel5);
            this.panelTask3.Controls.Add(this.label11);
            this.panelTask3.Controls.Add(this.txtTotalDiscount);
            this.panelTask3.Location = new System.Drawing.Point(1088, 3);
            this.panelTask3.Name = "panelTask3";
            this.panelTask3.Size = new System.Drawing.Size(514, 388);
            this.panelTask3.TabIndex = 14;
            // 
            // txtTotalBaseAmount
            // 
            this.txtTotalBaseAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBaseAmount.Location = new System.Drawing.Point(190, 193);
            this.txtTotalBaseAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBaseAmount.Name = "txtTotalBaseAmount";
            this.txtTotalBaseAmount.ReadOnly = true;
            this.txtTotalBaseAmount.Size = new System.Drawing.Size(290, 27);
            this.txtTotalBaseAmount.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total Base Amount";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(39, 320);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 20);
            this.label.TabIndex = 17;
            this.label.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(190, 315);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(290, 27);
            this.txtTotalAmount.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Tax Amount";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTax.Location = new System.Drawing.Point(190, 254);
            this.txtTotalTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(290, 27);
            this.txtTotalTax.TabIndex = 16;
            // 
            // txtTlAmtBeforeDiscount
            // 
            this.txtTlAmtBeforeDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlAmtBeforeDiscount.Location = new System.Drawing.Point(190, 78);
            this.txtTlAmtBeforeDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTlAmtBeforeDiscount.Name = "txtTlAmtBeforeDiscount";
            this.txtTlAmtBeforeDiscount.ReadOnly = true;
            this.txtTlAmtBeforeDiscount.Size = new System.Drawing.Size(290, 27);
            this.txtTlAmtBeforeDiscount.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Amount \r\n(Before Discount)";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(19, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 1);
            this.panel5.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Discount";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(190, 134);
            this.txtTotalDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(290, 27);
            this.txtTotalDiscount.TabIndex = 3;
            // 
            // panelTask2
            // 
            this.panelTask2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask2.BackColor = System.Drawing.Color.White;
            this.panelTask2.Controls.Add(this.cboShippingSite);
            this.panelTask2.Controls.Add(this.txtAddress);
            this.panelTask2.Controls.Add(this.label7);
            this.panelTask2.Controls.Add(this.label12);
            this.panelTask2.Controls.Add(this.lable);
            this.panelTask2.Controls.Add(this.panel9);
            this.panelTask2.Location = new System.Drawing.Point(557, 3);
            this.panelTask2.Name = "panelTask2";
            this.panelTask2.Size = new System.Drawing.Size(520, 316);
            this.panelTask2.TabIndex = 15;
            // 
            // cboShippingSite
            // 
            this.cboShippingSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippingSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShippingSite.FormattingEnabled = true;
            this.cboShippingSite.Location = new System.Drawing.Point(208, 81);
            this.cboShippingSite.Name = "cboShippingSite";
            this.cboShippingSite.Size = new System.Drawing.Size(277, 28);
            this.cboShippingSite.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(208, 138);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 141);
            this.txtAddress.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Shipping Information";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(41, 85);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(97, 20);
            this.lable.TabIndex = 0;
            this.lable.Text = "Shipping Site";
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
            this.panelTask.Size = new System.Drawing.Size(1605, 662);
            this.panelTask.TabIndex = 16;
            // 
            // MainRequestManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1645, 865);
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
        private System.Windows.Forms.Label lablel;
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
        public System.Windows.Forms.TextBox txtRequestDesc;
        public System.Windows.Forms.TextBox txtTotalDiscount;
        public System.Windows.Forms.TextBox txtTlAmtBeforeDiscount;
        public System.Windows.Forms.TextBox txtEndorsedBy;
        public System.Windows.Forms.ToolStripButton btnNew;
        public System.Windows.Forms.ToolStripButton btnEdit;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnSaveCloses;
        public System.Windows.Forms.Label lblRequestNo;
        public System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTask2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtRequestedBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cboShippingSite;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Panel panelTask;
        public System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboRequestType;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.ComboBox cboRequestStatus;
        public System.Windows.Forms.Label lblState;
        public System.Windows.Forms.DateTimePicker dtCreatedDate;
        public System.Windows.Forms.TextBox txtTotalBaseAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnShowAllRequestedByUserName;
        private System.Windows.Forms.Button btnShowAllEndorsedByUserName;
        private System.Windows.Forms.Button btnShowAllApprovedByUserName;
    }
}