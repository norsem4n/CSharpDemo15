namespace CKarnasProgram16
{
    partial class Form4
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
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblChartersSummary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLowFee = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLowestFeeDisplay = new System.Windows.Forms.Label();
            this.lblTotalFeeDisplay = new System.Windows.Forms.Label();
            this.lblAvgFeeDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataSource = typeof(CKarnasProgram16.CharterManager);
            // 
            // lblChartersSummary
            // 
            this.lblChartersSummary.AutoSize = true;
            this.lblChartersSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartersSummary.Location = new System.Drawing.Point(220, 22);
            this.lblChartersSummary.Name = "lblChartersSummary";
            this.lblChartersSummary.Size = new System.Drawing.Size(165, 24);
            this.lblChartersSummary.TabIndex = 0;
            this.lblChartersSummary.Text = "Charters Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developed by CGK";
            // 
            // lblLowFee
            // 
            this.lblLowFee.AutoSize = true;
            this.lblLowFee.Location = new System.Drawing.Point(76, 85);
            this.lblLowFee.Name = "lblLowFee";
            this.lblLowFee.Size = new System.Drawing.Size(179, 24);
            this.lblLowFee.TabIndex = 2;
            this.lblLowFee.Text = "Lowest Charter Fee:";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(63, 144);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(192, 24);
            this.lblTotalFee.TabIndex = 3;
            this.lblTotalFee.Text = "Total Chartered Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Charter Fee:";
            // 
            // lblLowestFeeDisplay
            // 
            this.lblLowestFeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowestFeeDisplay.Location = new System.Drawing.Point(274, 85);
            this.lblLowestFeeDisplay.Name = "lblLowestFeeDisplay";
            this.lblLowestFeeDisplay.Size = new System.Drawing.Size(179, 24);
            this.lblLowestFeeDisplay.TabIndex = 5;
            // 
            // lblTotalFeeDisplay
            // 
            this.lblTotalFeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFeeDisplay.Location = new System.Drawing.Point(274, 144);
            this.lblTotalFeeDisplay.Name = "lblTotalFeeDisplay";
            this.lblTotalFeeDisplay.Size = new System.Drawing.Size(179, 24);
            this.lblTotalFeeDisplay.TabIndex = 6;
            // 
            // lblAvgFeeDisplay
            // 
            this.lblAvgFeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgFeeDisplay.Location = new System.Drawing.Point(274, 202);
            this.lblAvgFeeDisplay.Name = "lblAvgFeeDisplay";
            this.lblAvgFeeDisplay.Size = new System.Drawing.Size(179, 24);
            this.lblAvgFeeDisplay.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.lblAvgFeeDisplay);
            this.Controls.Add(this.lblTotalFeeDisplay);
            this.Controls.Add(this.lblLowestFeeDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.lblLowFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChartersSummary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 16 - Summary Form";
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        private System.Windows.Forms.Label lblChartersSummary;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblLowFee;
        internal System.Windows.Forms.Label lblTotalFee;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblLowestFeeDisplay;
        internal System.Windows.Forms.Label lblTotalFeeDisplay;
        internal System.Windows.Forms.Label lblAvgFeeDisplay;
    }
}