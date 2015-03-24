namespace ManipulatorControl
{
    partial class frmArmsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArmsControl));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblLAV = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblRAV = new System.Windows.Forms.ToolStripLabel();
            this.lblAlert = new System.Windows.Forms.ToolStripLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.tabPosAndMovs = new System.Windows.Forms.TabPage();
            this.gbPredefRightArm = new System.Windows.Forms.GroupBox();
            this.lbRightPredefMovs = new System.Windows.Forms.ListBox();
            this.lbRightPredefPos = new System.Windows.Forms.ListBox();
            this.cmsRightPredefPos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRightPredefPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.newRightPredefPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.setRightCurrentPredefPos = new System.Windows.Forms.ToolStripMenuItem();
            this.pgMain = new System.Windows.Forms.PropertyGrid();
            this.gbPredefLeftArm = new System.Windows.Forms.GroupBox();
            this.lbLeftPredefMovs = new System.Windows.Forms.ListBox();
            this.lbLeftPredefPos = new System.Windows.Forms.ListBox();
            this.cmsLeftPredefPos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLeftPredefPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.newLeftPredefPos = new System.Windows.Forms.ToolStripMenuItem();
            this.setLeftCurrentPredefPos = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblGeneralStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCnnStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLeftArmStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRightArmStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLeftComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRightComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbTorque = new System.Windows.Forms.CheckBox();
            this.tmBat = new System.Windows.Forms.Timer(this.components);
            this.chb_useLaHand = new System.Windows.Forms.CheckBox();
            this.chb_useRaHand = new System.Windows.Forms.CheckBox();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabPosAndMovs.SuspendLayout();
            this.gbPredefRightArm.SuspendLayout();
            this.cmsRightPredefPos.SuspendLayout();
            this.gbPredefLeftArm.SuspendLayout();
            this.cmsLeftPredefPos.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(4, 4);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(776, 429);
            this.txtConsole.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(792, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveAll,
            this.toolStripLabel1,
            this.lblLAV,
            this.toolStripLabel3,
            this.lblRAV,
            this.lblAlert});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(792, 25);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.Image")));
            this.btnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAll.Text = "toolStripButton1";
            this.btnSaveAll.ToolTipText = "Save All";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "LAv:";
            // 
            // lblLAV
            // 
            this.lblLAV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAV.Name = "lblLAV";
            this.lblLAV.Size = new System.Drawing.Size(30, 22);
            this.lblLAV.Text = "???";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel3.Text = "RAv:";
            // 
            // lblRAV
            // 
            this.lblRAV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAV.Name = "lblRAV";
            this.lblRAV.Size = new System.Drawing.Size(30, 22);
            this.lblRAV.Text = "???";
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(178, 25);
            this.lblAlert.Text = "LOW BATTERY [!!!]";
            this.lblAlert.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConsole);
            this.tabControl.Controls.Add(this.tabPosAndMovs);
            this.tabControl.Location = new System.Drawing.Point(0, 64);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 466);
            this.tabControl.TabIndex = 3;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.txtConsole);
            this.tabConsole.Location = new System.Drawing.Point(4, 25);
            this.tabConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConsole.Size = new System.Drawing.Size(784, 437);
            this.tabConsole.TabIndex = 1;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // tabPosAndMovs
            // 
            this.tabPosAndMovs.Controls.Add(this.gbPredefRightArm);
            this.tabPosAndMovs.Controls.Add(this.pgMain);
            this.tabPosAndMovs.Controls.Add(this.gbPredefLeftArm);
            this.tabPosAndMovs.Location = new System.Drawing.Point(4, 25);
            this.tabPosAndMovs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPosAndMovs.Name = "tabPosAndMovs";
            this.tabPosAndMovs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPosAndMovs.Size = new System.Drawing.Size(784, 437);
            this.tabPosAndMovs.TabIndex = 0;
            this.tabPosAndMovs.Text = "Pos and  Movs";
            this.tabPosAndMovs.UseVisualStyleBackColor = true;
            // 
            // gbPredefRightArm
            // 
            this.gbPredefRightArm.Controls.Add(this.lbRightPredefMovs);
            this.gbPredefRightArm.Controls.Add(this.lbRightPredefPos);
            this.gbPredefRightArm.Location = new System.Drawing.Point(188, 7);
            this.gbPredefRightArm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPredefRightArm.Name = "gbPredefRightArm";
            this.gbPredefRightArm.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPredefRightArm.Size = new System.Drawing.Size(180, 420);
            this.gbPredefRightArm.TabIndex = 0;
            this.gbPredefRightArm.TabStop = false;
            this.gbPredefRightArm.Text = "Right Arm";
            // 
            // lbRightPredefMovs
            // 
            this.lbRightPredefMovs.FormattingEnabled = true;
            this.lbRightPredefMovs.ItemHeight = 16;
            this.lbRightPredefMovs.Location = new System.Drawing.Point(8, 212);
            this.lbRightPredefMovs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRightPredefMovs.Name = "lbRightPredefMovs";
            this.lbRightPredefMovs.Size = new System.Drawing.Size(160, 196);
            this.lbRightPredefMovs.TabIndex = 1;
            // 
            // lbRightPredefPos
            // 
            this.lbRightPredefPos.ContextMenuStrip = this.cmsRightPredefPos;
            this.lbRightPredefPos.FormattingEnabled = true;
            this.lbRightPredefPos.ItemHeight = 16;
            this.lbRightPredefPos.Location = new System.Drawing.Point(8, 23);
            this.lbRightPredefPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRightPredefPos.Name = "lbRightPredefPos";
            this.lbRightPredefPos.Size = new System.Drawing.Size(160, 180);
            this.lbRightPredefPos.TabIndex = 1;
            this.lbRightPredefPos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRightPredefPos_MouseDoubleClick);
            // 
            // cmsRightPredefPos
            // 
            this.cmsRightPredefPos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRightPredefPosition,
            this.newRightPredefPosition,
            this.setRightCurrentPredefPos});
            this.cmsRightPredefPos.Name = "cmsRightPredefPos";
            this.cmsRightPredefPos.Size = new System.Drawing.Size(266, 70);
            // 
            // deleteRightPredefPosition
            // 
            this.deleteRightPredefPosition.Name = "deleteRightPredefPosition";
            this.deleteRightPredefPosition.Size = new System.Drawing.Size(265, 22);
            this.deleteRightPredefPosition.Text = "Delete PredefPosition";
            this.deleteRightPredefPosition.Click += new System.EventHandler(this.deleteRightPredefPosition_Click);
            // 
            // newRightPredefPosition
            // 
            this.newRightPredefPosition.Name = "newRightPredefPosition";
            this.newRightPredefPosition.Size = new System.Drawing.Size(265, 22);
            this.newRightPredefPosition.Text = "New PredefPosition";
            this.newRightPredefPosition.Click += new System.EventHandler(this.newRightPredefPosition_Click);
            // 
            // setRightCurrentPredefPos
            // 
            this.setRightCurrentPredefPos.Name = "setRightCurrentPredefPos";
            this.setRightCurrentPredefPos.Size = new System.Drawing.Size(265, 22);
            this.setRightCurrentPredefPos.Text = "SetCurrentPos as this PredefPosition";
            this.setRightCurrentPredefPos.Click += new System.EventHandler(this.setRightCurrentPredefPos_Click);
            // 
            // pgMain
            // 
            this.pgMain.Location = new System.Drawing.Point(488, 0);
            this.pgMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgMain.Name = "pgMain";
            this.pgMain.Size = new System.Drawing.Size(293, 434);
            this.pgMain.TabIndex = 4;
            this.pgMain.ToolbarVisible = false;
            // 
            // gbPredefLeftArm
            // 
            this.gbPredefLeftArm.Controls.Add(this.lbLeftPredefMovs);
            this.gbPredefLeftArm.Controls.Add(this.lbLeftPredefPos);
            this.gbPredefLeftArm.Location = new System.Drawing.Point(4, 7);
            this.gbPredefLeftArm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPredefLeftArm.Name = "gbPredefLeftArm";
            this.gbPredefLeftArm.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPredefLeftArm.Size = new System.Drawing.Size(176, 420);
            this.gbPredefLeftArm.TabIndex = 0;
            this.gbPredefLeftArm.TabStop = false;
            this.gbPredefLeftArm.Text = "Left Arm";
            // 
            // lbLeftPredefMovs
            // 
            this.lbLeftPredefMovs.FormattingEnabled = true;
            this.lbLeftPredefMovs.ItemHeight = 16;
            this.lbLeftPredefMovs.Location = new System.Drawing.Point(8, 212);
            this.lbLeftPredefMovs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLeftPredefMovs.Name = "lbLeftPredefMovs";
            this.lbLeftPredefMovs.Size = new System.Drawing.Size(159, 196);
            this.lbLeftPredefMovs.TabIndex = 2;
            // 
            // lbLeftPredefPos
            // 
            this.lbLeftPredefPos.ContextMenuStrip = this.cmsLeftPredefPos;
            this.lbLeftPredefPos.FormattingEnabled = true;
            this.lbLeftPredefPos.ItemHeight = 16;
            this.lbLeftPredefPos.Location = new System.Drawing.Point(8, 23);
            this.lbLeftPredefPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLeftPredefPos.Name = "lbLeftPredefPos";
            this.lbLeftPredefPos.Size = new System.Drawing.Size(159, 180);
            this.lbLeftPredefPos.TabIndex = 1;
            this.lbLeftPredefPos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLeftPredefPos_MouseDoubleClick);
            // 
            // cmsLeftPredefPos
            // 
            this.cmsLeftPredefPos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLeftPredefPosition,
            this.newLeftPredefPos,
            this.setLeftCurrentPredefPos});
            this.cmsLeftPredefPos.Name = "cmsLeftPredefPos";
            this.cmsLeftPredefPos.Size = new System.Drawing.Size(248, 70);
            // 
            // deleteLeftPredefPosition
            // 
            this.deleteLeftPredefPosition.Name = "deleteLeftPredefPosition";
            this.deleteLeftPredefPosition.Size = new System.Drawing.Size(247, 22);
            this.deleteLeftPredefPosition.Text = "Delete PredefPosition";
            this.deleteLeftPredefPosition.Click += new System.EventHandler(this.deleteLeftPredefPosition_Click);
            // 
            // newLeftPredefPos
            // 
            this.newLeftPredefPos.Name = "newLeftPredefPos";
            this.newLeftPredefPos.Size = new System.Drawing.Size(247, 22);
            this.newLeftPredefPos.Text = "New PredefPosition";
            this.newLeftPredefPos.Click += new System.EventHandler(this.newPredefPositionToolStripMenuItem_Click);
            // 
            // setLeftCurrentPredefPos
            // 
            this.setLeftCurrentPredefPos.Name = "setLeftCurrentPredefPos";
            this.setLeftCurrentPredefPos.Size = new System.Drawing.Size(247, 22);
            this.setLeftCurrentPredefPos.Text = "Set CurrentPos as this PredefPos ";
            this.setLeftCurrentPredefPos.Click += new System.EventHandler(this.setLeftCurrentPredefPos_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGeneralStatus,
            this.lblCnnStatus,
            this.lblLeftArmStatus,
            this.lblRightArmStatus,
            this.lblLeftComPort,
            this.lblRightComPort});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 529);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(792, 25);
            this.mainStatusStrip.TabIndex = 5;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblGeneralStatus
            // 
            this.lblGeneralStatus.Name = "lblGeneralStatus";
            this.lblGeneralStatus.Size = new System.Drawing.Size(146, 20);
            this.lblGeneralStatus.Text = "SYSTEM NOT READY";
            // 
            // lblCnnStatus
            // 
            this.lblCnnStatus.Name = "lblCnnStatus";
            this.lblCnnStatus.Size = new System.Drawing.Size(153, 20);
            this.lblCnnStatus.Text = "| BB: No Connected   |";
            // 
            // lblLeftArmStatus
            // 
            this.lblLeftArmStatus.Name = "lblLeftArmStatus";
            this.lblLeftArmStatus.Size = new System.Drawing.Size(119, 20);
            this.lblLeftArmStatus.Text = "LA: Not Ready   |";
            // 
            // lblRightArmStatus
            // 
            this.lblRightArmStatus.Name = "lblRightArmStatus";
            this.lblRightArmStatus.Size = new System.Drawing.Size(121, 20);
            this.lblRightArmStatus.Text = "RA: Not Ready   |";
            // 
            // lblLeftComPort
            // 
            this.lblLeftComPort.Name = "lblLeftComPort";
            this.lblLeftComPort.Size = new System.Drawing.Size(90, 20);
            this.lblLeftComPort.Text = "LA: COM1   |";
            // 
            // lblRightComPort
            // 
            this.lblRightComPort.Name = "lblRightComPort";
            this.lblRightComPort.Size = new System.Drawing.Size(92, 20);
            this.lblRightComPort.Text = "RA: COM2   |";
            // 
            // cbTorque
            // 
            this.cbTorque.AutoSize = true;
            this.cbTorque.Location = new System.Drawing.Point(659, 36);
            this.cbTorque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTorque.Name = "cbTorque";
            this.cbTorque.Size = new System.Drawing.Size(122, 21);
            this.cbTorque.TabIndex = 6;
            this.cbTorque.Text = "Torque On/Off";
            this.cbTorque.UseVisualStyleBackColor = true;
            this.cbTorque.CheckedChanged += new System.EventHandler(this.cbTorque_CheckedChanged);
            // 
            // tmBat
            // 
            this.tmBat.Enabled = true;
            this.tmBat.Interval = 10000;
            this.tmBat.Tick += new System.EventHandler(this.tmBat_Tick);
            // 
            // chb_useLaHand
            // 
            this.chb_useLaHand.AutoSize = true;
            this.chb_useLaHand.Enabled = false;
            this.chb_useLaHand.Location = new System.Drawing.Point(512, 36);
            this.chb_useLaHand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_useLaHand.Name = "chb_useLaHand";
            this.chb_useLaHand.Size = new System.Drawing.Size(109, 21);
            this.chb_useLaHand.TabIndex = 1;
            this.chb_useLaHand.Text = "Use LaHand";
            this.chb_useLaHand.UseVisualStyleBackColor = true;
            this.chb_useLaHand.CheckedChanged += new System.EventHandler(this.chb_useLaHand_CheckedChanged);
            // 
            // chb_useRaHand
            // 
            this.chb_useRaHand.AutoSize = true;
            this.chb_useRaHand.Location = new System.Drawing.Point(387, 36);
            this.chb_useRaHand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_useRaHand.Name = "chb_useRaHand";
            this.chb_useRaHand.Size = new System.Drawing.Size(111, 21);
            this.chb_useRaHand.TabIndex = 12;
            this.chb_useRaHand.Text = "Use RaHand";
            this.chb_useRaHand.UseVisualStyleBackColor = true;
            this.chb_useRaHand.CheckedChanged += new System.EventHandler(this.chb_useRaHand_CheckedChanged);
            // 
            // frmArmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.cbTorque);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.chb_useRaHand);
            this.Controls.Add(this.chb_useLaHand);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArmsControl";
            this.Text = "ARMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArmsControl_FormClosing);
            this.Load += new System.EventHandler(this.frmArmsControl_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.tabPosAndMovs.ResumeLayout(false);
            this.gbPredefRightArm.ResumeLayout(false);
            this.cmsRightPredefPos.ResumeLayout(false);
            this.gbPredefLeftArm.ResumeLayout(false);
            this.cmsLeftPredefPos.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton btnSaveAll;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPosAndMovs;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.PropertyGrid pgMain;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblGeneralStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCnnStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblLeftArmStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblRightArmStatus;
        private System.Windows.Forms.GroupBox gbPredefRightArm;
        private System.Windows.Forms.GroupBox gbPredefLeftArm;
        private System.Windows.Forms.ListBox lbRightPredefPos;
        private System.Windows.Forms.ListBox lbLeftPredefPos;
        private System.Windows.Forms.ListBox lbRightPredefMovs;
        private System.Windows.Forms.ToolStripStatusLabel lblLeftComPort;
        private System.Windows.Forms.ToolStripStatusLabel lblRightComPort;
        private System.Windows.Forms.ListBox lbLeftPredefMovs;
        private System.Windows.Forms.ToolTip mainToolTip;
		private System.Windows.Forms.CheckBox cbTorque;
        private System.Windows.Forms.ContextMenuStrip cmsLeftPredefPos;
        private System.Windows.Forms.ToolStripMenuItem deleteLeftPredefPosition;
        private System.Windows.Forms.ToolStripMenuItem newLeftPredefPos;
        private System.Windows.Forms.ToolStripMenuItem setLeftCurrentPredefPos;
        private System.Windows.Forms.ContextMenuStrip cmsRightPredefPos;
        private System.Windows.Forms.ToolStripMenuItem deleteRightPredefPosition;
        private System.Windows.Forms.ToolStripMenuItem newRightPredefPosition;
        private System.Windows.Forms.ToolStripMenuItem setRightCurrentPredefPos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblLAV;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblRAV;
        private System.Windows.Forms.ToolStripLabel lblAlert;
        private System.Windows.Forms.Timer tmBat;
        private System.Windows.Forms.CheckBox chb_useLaHand;
        private System.Windows.Forms.CheckBox chb_useRaHand;
    }
}

