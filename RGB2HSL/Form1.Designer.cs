namespace RGB2HSL
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.R_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B_numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.G_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelL = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // R_numericUpDown1
            // 
            this.R_numericUpDown1.Location = new System.Drawing.Point(116, 37);
            this.R_numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R_numericUpDown1.Name = "R_numericUpDown1";
            this.R_numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.R_numericUpDown1.TabIndex = 0;
            this.R_numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.G);
            this.panel1.Controls.Add(this.B_numericUpDown3);
            this.panel1.Controls.Add(this.G_numericUpDown2);
            this.panel1.Controls.Add(this.R);
            this.panel1.Controls.Add(this.R_numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(57, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 374);
            this.panel1.TabIndex = 1;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(63, 154);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(24, 18);
            this.B.TabIndex = 5;
            this.B.Text = "B:";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(63, 96);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(25, 18);
            this.G.TabIndex = 4;
            this.G.Text = "G:";
            // 
            // B_numericUpDown3
            // 
            this.B_numericUpDown3.Location = new System.Drawing.Point(116, 152);
            this.B_numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B_numericUpDown3.Name = "B_numericUpDown3";
            this.B_numericUpDown3.Size = new System.Drawing.Size(120, 29);
            this.B_numericUpDown3.TabIndex = 3;
            this.B_numericUpDown3.ValueChanged += new System.EventHandler(this.B_numericUpDown3_ValueChanged);
            // 
            // G_numericUpDown2
            // 
            this.G_numericUpDown2.Location = new System.Drawing.Point(116, 94);
            this.G_numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G_numericUpDown2.Name = "G_numericUpDown2";
            this.G_numericUpDown2.Size = new System.Drawing.Size(120, 29);
            this.G_numericUpDown2.TabIndex = 2;
            this.G_numericUpDown2.ValueChanged += new System.EventHandler(this.G_numericUpDown2_ValueChanged);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(63, 39);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(24, 18);
            this.R.TabIndex = 1;
            this.R.Text = "R:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelL);
            this.panel2.Controls.Add(this.labelS);
            this.panel2.Controls.Add(this.H);
            this.panel2.Controls.Add(this.textBoxL);
            this.panel2.Controls.Add(this.textBoxS);
            this.panel2.Controls.Add(this.textBoxH);
            this.panel2.Location = new System.Drawing.Point(586, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 374);
            this.panel2.TabIndex = 2;
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(92, 162);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(23, 18);
            this.labelL.TabIndex = 5;
            this.labelL.Text = "L:";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(92, 96);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(22, 18);
            this.labelS.TabIndex = 4;
            this.labelS.Text = "S:";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(92, 40);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(25, 18);
            this.H.TabIndex = 3;
            this.H.Text = "H:";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(152, 151);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(100, 29);
            this.textBoxL.TabIndex = 2;
            this.textBoxL.TextChanged += new System.EventHandler(this.textBoxL_TextChanged);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(152, 93);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 29);
            this.textBoxS.TabIndex = 1;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(152, 37);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 29);
            this.textBoxH.TabIndex = 0;
            this.textBoxH.TextChanged += new System.EventHandler(this.textBoxH_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(361, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 83);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 716);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown R_numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.NumericUpDown B_numericUpDown3;
        private System.Windows.Forms.NumericUpDown G_numericUpDown2;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

