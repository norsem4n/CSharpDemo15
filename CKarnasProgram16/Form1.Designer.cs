namespace CKarnasProgram16
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersForYachtSIzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartersSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetForNextCharterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboYachtType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.lblYachtSizes = new System.Windows.Forms.Label();
            this.lblYachtTypes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblHoursChartered = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.gboxCharterInfo = new System.Windows.Forms.GroupBox();
            this.lboxYachtSize = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.gboxCharterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.numberOfChartersForYachtSIzeToolStripMenuItem,
            this.chartersSummaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // numberOfChartersForYachtSIzeToolStripMenuItem
            // 
            this.numberOfChartersForYachtSIzeToolStripMenuItem.Name = "numberOfChartersForYachtSIzeToolStripMenuItem";
            this.numberOfChartersForYachtSIzeToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.numberOfChartersForYachtSIzeToolStripMenuItem.Text = "Number of Charters for Yacht SIze";
            this.numberOfChartersForYachtSIzeToolStripMenuItem.Click += new System.EventHandler(this.numberOfChartersForYachtSIzeToolStripMenuItem_Click);
            // 
            // chartersSummaryToolStripMenuItem
            // 
            this.chartersSummaryToolStripMenuItem.Name = "chartersSummaryToolStripMenuItem";
            this.chartersSummaryToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.chartersSummaryToolStripMenuItem.Text = "Charters Summary";
            this.chartersSummaryToolStripMenuItem.Click += new System.EventHandler(this.chartersSummaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(314, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetForNextCharterToolStripMenuItem,
            this.toolStripSeparator2,
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetForNextCharterToolStripMenuItem
            // 
            this.resetForNextCharterToolStripMenuItem.Name = "resetForNextCharterToolStripMenuItem";
            this.resetForNextCharterToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.resetForNextCharterToolStripMenuItem.Text = "Reset for Next Charter";
            this.resetForNextCharterToolStripMenuItem.Click += new System.EventHandler(this.resetForNextCharterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // cboYachtType
            // 
            this.cboYachtType.ContextMenuStrip = this.contextMenuStrip1;
            this.cboYachtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYachtType.FormattingEnabled = true;
            this.cboYachtType.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Mega Yacht",
            "Motor Yacht",
            "Sedan Bridge",
            "Skylounge",
            "Sportfish",
            "Tri-Deck"});
            this.cboYachtType.Location = new System.Drawing.Point(309, 123);
            this.cboYachtType.Name = "cboYachtType";
            this.cboYachtType.Size = new System.Drawing.Size(188, 32);
            this.cboYachtType.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYachtTypeToolStripMenuItem1,
            this.removeYachtTypeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // addYachtTypeToolStripMenuItem1
            // 
            this.addYachtTypeToolStripMenuItem1.Name = "addYachtTypeToolStripMenuItem1";
            this.addYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addYachtTypeToolStripMenuItem1.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharter.Location = new System.Drawing.Point(206, 226);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(195, 47);
            this.btnAddCharter.TabIndex = 5;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // lblYachtSizes
            // 
            this.lblYachtSizes.AutoSize = true;
            this.lblYachtSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYachtSizes.Location = new System.Drawing.Point(154, 173);
            this.lblYachtSizes.Name = "lblYachtSizes";
            this.lblYachtSizes.Size = new System.Drawing.Size(103, 24);
            this.lblYachtSizes.TabIndex = 11;
            this.lblYachtSizes.Text = "Yacht Size:";
            // 
            // lblYachtTypes
            // 
            this.lblYachtTypes.AutoSize = true;
            this.lblYachtTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYachtTypes.Location = new System.Drawing.Point(147, 126);
            this.lblYachtTypes.Name = "lblYachtTypes";
            this.lblYachtTypes.Size = new System.Drawing.Size(110, 24);
            this.lblYachtTypes.TabIndex = 10;
            this.lblYachtTypes.Text = "Yacht Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yacht Charters";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(105, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(152, 24);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer Name:";
            // 
            // lblHoursChartered
            // 
            this.lblHoursChartered.AutoSize = true;
            this.lblHoursChartered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursChartered.Location = new System.Drawing.Point(125, 78);
            this.lblHoursChartered.Name = "lblHoursChartered";
            this.lblHoursChartered.Size = new System.Drawing.Size(132, 24);
            this.lblHoursChartered.TabIndex = 9;
            this.lblHoursChartered.Text = "Charter Hours:";
            // 
            // nudHours
            // 
            this.nudHours.DecimalPlaces = 1;
            this.nudHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHours.Location = new System.Drawing.Point(309, 76);
            this.nudHours.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudHours.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(112, 29);
            this.nudHours.TabIndex = 2;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHours.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(309, 32);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(262, 29);
            this.txtCustomer.TabIndex = 1;
            // 
            // gboxCharterInfo
            // 
            this.gboxCharterInfo.Controls.Add(this.lboxYachtSize);
            this.gboxCharterInfo.Controls.Add(this.txtCustomer);
            this.gboxCharterInfo.Controls.Add(this.nudHours);
            this.gboxCharterInfo.Controls.Add(this.lblHoursChartered);
            this.gboxCharterInfo.Controls.Add(this.lblCustomer);
            this.gboxCharterInfo.Controls.Add(this.lblYachtTypes);
            this.gboxCharterInfo.Controls.Add(this.lblYachtSizes);
            this.gboxCharterInfo.Controls.Add(this.btnAddCharter);
            this.gboxCharterInfo.Controls.Add(this.cboYachtType);
            this.gboxCharterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCharterInfo.Location = new System.Drawing.Point(14, 52);
            this.gboxCharterInfo.Name = "gboxCharterInfo";
            this.gboxCharterInfo.Size = new System.Drawing.Size(622, 303);
            this.gboxCharterInfo.TabIndex = 12;
            this.gboxCharterInfo.TabStop = false;
            this.gboxCharterInfo.Text = "Charter Info";
            // 
            // lboxYachtSize
            // 
            this.lboxYachtSize.ContextMenuStrip = this.contextMenuStrip1;
            this.lboxYachtSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lboxYachtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxYachtSize.FormattingEnabled = true;
            this.lboxYachtSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.lboxYachtSize.Location = new System.Drawing.Point(309, 170);
            this.lboxYachtSize.Name = "lboxYachtSize";
            this.lboxYachtSize.Size = new System.Drawing.Size(143, 32);
            this.lboxYachtSize.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 393);
            this.Controls.Add(this.gboxCharterInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 16 - Yacht Charter";
            this.Load += new System.EventHandler(this.Module8Ex2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.gboxCharterInfo.ResumeLayout(false);
            this.gboxCharterInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfChartersForYachtSIzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartersSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetForNextCharterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.Label lblYachtSizes;
        private System.Windows.Forms.Label lblYachtTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblHoursChartered;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gboxCharterInfo;
        private System.Windows.Forms.ComboBox lboxYachtSize;
        internal System.Windows.Forms.ComboBox cboYachtType;
    }
}

