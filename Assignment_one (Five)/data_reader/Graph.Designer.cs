namespace data_reader
{
    partial class Graph
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.CB_heart = new System.Windows.Forms.CheckBox();
            this.CB_speed = new System.Windows.Forms.CheckBox();
            this.CB_candence = new System.Windows.Forms.CheckBox();
            this.CB_Ascent = new System.Windows.Forms.CheckBox();
            this.CB_power = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(847, 576);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // CB_heart
            // 
            this.CB_heart.AutoSize = true;
            this.CB_heart.BackColor = System.Drawing.Color.Transparent;
            this.CB_heart.Checked = true;
            this.CB_heart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_heart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_heart.ForeColor = System.Drawing.Color.Black;
            this.CB_heart.Location = new System.Drawing.Point(866, 102);
            this.CB_heart.Name = "CB_heart";
            this.CB_heart.Size = new System.Drawing.Size(144, 29);
            this.CB_heart.TabIndex = 7;
            this.CB_heart.Text = "Heart Rate";
            this.CB_heart.UseVisualStyleBackColor = false;
            this.CB_heart.CheckedChanged += new System.EventHandler(this.CB_heart_CheckedChanged);
            // 
            // CB_speed
            // 
            this.CB_speed.AutoSize = true;
            this.CB_speed.Checked = true;
            this.CB_speed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CB_speed.Location = new System.Drawing.Point(866, 137);
            this.CB_speed.Name = "CB_speed";
            this.CB_speed.Size = new System.Drawing.Size(98, 29);
            this.CB_speed.TabIndex = 8;
            this.CB_speed.Text = "Speed";
            this.CB_speed.UseVisualStyleBackColor = true;
            this.CB_speed.CheckedChanged += new System.EventHandler(this.CB_speed_CheckedChanged);
            // 
            // CB_candence
            // 
            this.CB_candence.AutoSize = true;
            this.CB_candence.Checked = true;
            this.CB_candence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_candence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_candence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CB_candence.Location = new System.Drawing.Point(865, 172);
            this.CB_candence.Name = "CB_candence";
            this.CB_candence.Size = new System.Drawing.Size(124, 29);
            this.CB_candence.TabIndex = 9;
            this.CB_candence.Text = "Cadence";
            this.CB_candence.UseVisualStyleBackColor = true;
            this.CB_candence.CheckedChanged += new System.EventHandler(this.CB_candence_CheckedChanged);
            // 
            // CB_Ascent
            // 
            this.CB_Ascent.AutoSize = true;
            this.CB_Ascent.Checked = true;
            this.CB_Ascent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Ascent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ascent.ForeColor = System.Drawing.Color.Blue;
            this.CB_Ascent.Location = new System.Drawing.Point(866, 207);
            this.CB_Ascent.Name = "CB_Ascent";
            this.CB_Ascent.Size = new System.Drawing.Size(103, 29);
            this.CB_Ascent.TabIndex = 10;
            this.CB_Ascent.Text = "Ascent";
            this.CB_Ascent.UseVisualStyleBackColor = true;
            this.CB_Ascent.CheckedChanged += new System.EventHandler(this.CB_Ascent_CheckedChanged);
            // 
            // CB_power
            // 
            this.CB_power.AutoSize = true;
            this.CB_power.Checked = true;
            this.CB_power.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CB_power.Location = new System.Drawing.Point(866, 242);
            this.CB_power.Name = "CB_power";
            this.CB_power.Size = new System.Drawing.Size(96, 29);
            this.CB_power.TabIndex = 11;
            this.CB_power.Text = "Power";
            this.CB_power.UseVisualStyleBackColor = true;
            this.CB_power.CheckedChanged += new System.EventHandler(this.CB_power_CheckedChanged);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 594);
            this.Controls.Add(this.CB_power);
            this.Controls.Add(this.CB_Ascent);
            this.Controls.Add(this.CB_candence);
            this.Controls.Add(this.CB_speed);
            this.Controls.Add(this.CB_heart);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.CheckBox CB_heart;
        private System.Windows.Forms.CheckBox CB_speed;
        private System.Windows.Forms.CheckBox CB_candence;
        private System.Windows.Forms.CheckBox CB_Ascent;
        private System.Windows.Forms.CheckBox CB_power;
    }
}