namespace Assignment_one
{
    partial class data_reader
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.length = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.start_time = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(724, 419);
            this.dataGridView2.TabIndex = 0;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(12, 473);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(103, 20);
            this.length.TabIndex = 8;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(633, 473);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(103, 20);
            this.date.TabIndex = 9;
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(149, 473);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(103, 20);
            this.start_time.TabIndex = 10;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(12, 22);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(103, 20);
            this.version.TabIndex = 11;
            // 
            // data_reader
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(748, 524);
            this.Controls.Add(this.version);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.length);
            this.Controls.Add(this.dataGridView2);
            this.Name = "data_reader";
            this.Text = "Data Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox start_time;
        private System.Windows.Forms.TextBox version;
    }
}

