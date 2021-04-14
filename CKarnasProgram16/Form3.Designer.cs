namespace CKarnasProgram16
{
    partial class Form3
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
            this.charterManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YachtTypes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // charterManagerDataGridView
            // 
            this.charterManagerDataGridView.AllowUserToAddRows = false;
            this.charterManagerDataGridView.AllowUserToDeleteRows = false;
            this.charterManagerDataGridView.AutoGenerateColumns = false;
            this.charterManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charterManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.YachtTypes,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.charterHoursDataGridViewTextBoxColumn,
            this.charterFeeDataGridViewTextBoxColumn});
            this.charterManagerDataGridView.DataSource = this.charterManagerBindingSource;
            this.charterManagerDataGridView.Location = new System.Drawing.Point(15, 41);
            this.charterManagerDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.charterManagerDataGridView.Name = "charterManagerDataGridView";
            this.charterManagerDataGridView.ReadOnly = true;
            this.charterManagerDataGridView.Size = new System.Drawing.Size(721, 372);
            this.charterManagerDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Charters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed by CGK";
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataMember = "CharterList";
            this.charterManagerBindingSource.DataSource = typeof(CKarnasProgram16.CharterManager);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // YachtTypes
            // 
            this.YachtTypes.DataPropertyName = "YachtTypes";
            this.YachtTypes.HeaderText = "YachtTypes";
            this.YachtTypes.Name = "YachtTypes";
            this.YachtTypes.ReadOnly = true;
            this.YachtTypes.Width = 150;
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "Yacht Size";
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            this.yachtSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtSizeDataGridViewTextBoxColumn.Width = 70;
            // 
            // charterHoursDataGridViewTextBoxColumn
            // 
            this.charterHoursDataGridViewTextBoxColumn.DataPropertyName = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.HeaderText = "Charter Hours";
            this.charterHoursDataGridViewTextBoxColumn.Name = "charterHoursDataGridViewTextBoxColumn";
            this.charterHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterHoursDataGridViewTextBoxColumn.Width = 75;
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "Charter Fee";
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterFeeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charterManagerDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 16 - All Charters Form";
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        internal System.Windows.Forms.DataGridView charterManagerDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YachtTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
    }
}