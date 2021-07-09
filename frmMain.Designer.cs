namespace GameTrainer
{
    partial class frmMain
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
            this.grdLocs = new System.Windows.Forms.DataGridView();
            this.colMemOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWinName = new System.Windows.Forms.Label();
            this.txtWindow = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdLockWindow = new System.Windows.Forms.Button();
            this.cmeReadMem = new System.Windows.Forms.Button();
            this.lblMemLoc = new System.Windows.Forms.Label();
            this.txtMemOp = new System.Windows.Forms.TextBox();
            this.lblDtType = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUnlock = new System.Windows.Forms.Button();
            this.chkFreeze = new System.Windows.Forms.CheckBox();
            this.cmdRP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocs)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLocs
            // 
            this.grdLocs.AllowUserToAddRows = false;
            this.grdLocs.AllowUserToResizeColumns = false;
            this.grdLocs.AllowUserToResizeRows = false;
            this.grdLocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemOP,
            this.colDType,
            this.colVal});
            this.grdLocs.Location = new System.Drawing.Point(27, 322);
            this.grdLocs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdLocs.Name = "grdLocs";
            this.grdLocs.RowHeadersVisible = false;
            this.grdLocs.RowTemplate.Height = 40;
            this.grdLocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLocs.Size = new System.Drawing.Size(1797, 422);
            this.grdLocs.TabIndex = 0;
            // 
            // colMemOP
            // 
            this.colMemOP.Frozen = true;
            this.colMemOP.HeaderText = "Memory String";
            this.colMemOP.Name = "colMemOP";
            this.colMemOP.ReadOnly = true;
            // 
            // colDType
            // 
            this.colDType.Frozen = true;
            this.colDType.HeaderText = "Data Type";
            this.colDType.Name = "colDType";
            this.colDType.ReadOnly = true;
            // 
            // colVal
            // 
            this.colVal.HeaderText = "Value";
            this.colVal.Name = "colVal";
            // 
            // lblWinName
            // 
            this.lblWinName.AutoSize = true;
            this.lblWinName.Location = new System.Drawing.Point(19, 21);
            this.lblWinName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWinName.Name = "lblWinName";
            this.lblWinName.Size = new System.Drawing.Size(198, 32);
            this.lblWinName.TabIndex = 1;
            this.lblWinName.Text = "Window Name";
            // 
            // txtWindow
            // 
            this.txtWindow.Location = new System.Drawing.Point(240, 14);
            this.txtWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtWindow.Name = "txtWindow";
            this.txtWindow.Size = new System.Drawing.Size(1572, 38);
            this.txtWindow.TabIndex = 2;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(1624, 754);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(200, 55);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(27, 754);
            this.cmdLoad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(200, 55);
            this.cmdLoad.TabIndex = 4;
            this.cmdLoad.Text = "&Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdLockWindow
            // 
            this.cmdLockWindow.Location = new System.Drawing.Point(27, 81);
            this.cmdLockWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdLockWindow.Name = "cmdLockWindow";
            this.cmdLockWindow.Size = new System.Drawing.Size(237, 55);
            this.cmdLockWindow.TabIndex = 5;
            this.cmdLockWindow.Text = "Lock Window";
            this.cmdLockWindow.UseVisualStyleBackColor = true;
            this.cmdLockWindow.Click += new System.EventHandler(this.cmdLockWindow_Click);
            // 
            // cmeReadMem
            // 
            this.cmeReadMem.Location = new System.Drawing.Point(1168, 81);
            this.cmeReadMem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmeReadMem.Name = "cmeReadMem";
            this.cmeReadMem.Size = new System.Drawing.Size(435, 55);
            this.cmeReadMem.TabIndex = 6;
            this.cmeReadMem.Text = "&Read Memory Locations";
            this.cmeReadMem.UseVisualStyleBackColor = true;
            this.cmeReadMem.Click += new System.EventHandler(this.cmeReadMem_Click);
            // 
            // lblMemLoc
            // 
            this.lblMemLoc.AutoSize = true;
            this.lblMemLoc.Location = new System.Drawing.Point(19, 186);
            this.lblMemLoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMemLoc.Name = "lblMemLoc";
            this.lblMemLoc.Size = new System.Drawing.Size(234, 32);
            this.lblMemLoc.TabIndex = 8;
            this.lblMemLoc.Text = "Memory Operand";
            // 
            // txtMemOp
            // 
            this.txtMemOp.Location = new System.Drawing.Point(272, 179);
            this.txtMemOp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMemOp.Name = "txtMemOp";
            this.txtMemOp.Size = new System.Drawing.Size(1540, 38);
            this.txtMemOp.TabIndex = 9;
            // 
            // lblDtType
            // 
            this.lblDtType.AutoSize = true;
            this.lblDtType.Location = new System.Drawing.Point(35, 253);
            this.lblDtType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDtType.Name = "lblDtType";
            this.lblDtType.Size = new System.Drawing.Size(145, 32);
            this.lblDtType.TabIndex = 10;
            this.lblDtType.Text = "Data Type";
            this.lblDtType.Click += new System.EventHandler(this.lblDtType_Click);
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "int",
            "float",
            "double",
            "byte",
            "byte[]"});
            this.cmbTypes.Location = new System.Drawing.Point(272, 253);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(721, 39);
            this.cmbTypes.TabIndex = 11;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(1016, 248);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(200, 55);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(1235, 246);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(200, 55);
            this.cmdDelete.TabIndex = 13;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUnlock
            // 
            this.cmdUnlock.Location = new System.Drawing.Point(280, 81);
            this.cmdUnlock.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdUnlock.Name = "cmdUnlock";
            this.cmdUnlock.Size = new System.Drawing.Size(200, 55);
            this.cmdUnlock.TabIndex = 14;
            this.cmdUnlock.Text = "Unlock";
            this.cmdUnlock.UseVisualStyleBackColor = true;
            this.cmdUnlock.Click += new System.EventHandler(this.cmdUnlock_Click);
            // 
            // chkFreeze
            // 
            this.chkFreeze.AutoSize = true;
            this.chkFreeze.Location = new System.Drawing.Point(1621, 93);
            this.chkFreeze.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkFreeze.Name = "chkFreeze";
            this.chkFreeze.Size = new System.Drawing.Size(141, 36);
            this.chkFreeze.TabIndex = 15;
            this.chkFreeze.Text = "&Freeze";
            this.chkFreeze.UseVisualStyleBackColor = true;
            this.chkFreeze.CheckedChanged += new System.EventHandler(this.chkFreeze_CheckedChanged);
            // 
            // cmdRP
            // 
            this.cmdRP.Location = new System.Drawing.Point(845, 81);
            this.cmdRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRP.Name = "cmdRP";
            this.cmdRP.Size = new System.Drawing.Size(312, 55);
            this.cmdRP.TabIndex = 16;
            this.cmdRP.Text = "&Reset Pointer Cache";
            this.cmdRP.UseVisualStyleBackColor = true;
            this.cmdRP.Click += new System.EventHandler(this.cmdRP_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1851, 825);
            this.Controls.Add(this.cmdRP);
            this.Controls.Add(this.chkFreeze);
            this.Controls.Add(this.cmdUnlock);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.lblDtType);
            this.Controls.Add(this.txtMemOp);
            this.Controls.Add(this.lblMemLoc);
            this.Controls.Add(this.cmeReadMem);
            this.Controls.Add(this.cmdLockWindow);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtWindow);
            this.Controls.Add(this.lblWinName);
            this.Controls.Add(this.grdLocs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Generic Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdLocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLocs;
        private System.Windows.Forms.Label lblWinName;
        private System.Windows.Forms.TextBox txtWindow;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdLockWindow;
        private System.Windows.Forms.Button cmeReadMem;
        private System.Windows.Forms.Label lblMemLoc;
        private System.Windows.Forms.TextBox txtMemOp;
        private System.Windows.Forms.Label lblDtType;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUnlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVal;
        private System.Windows.Forms.CheckBox chkFreeze;
        private System.Windows.Forms.Button cmdRP;
    }
}

