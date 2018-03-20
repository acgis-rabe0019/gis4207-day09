namespace CoordConverterWinApp
{
    partial class MainForm
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
            this.lbIDd = new System.Windows.Forms.Label();
            this.tbxDeg = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxSec = new System.Windows.Forms.TextBox();
            this.cboQuandrant = new System.Windows.Forms.ComboBox();
            this.ldlDeg = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblQuandrant = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIDd
            // 
            this.lbIDd.AutoSize = true;
            this.lbIDd.Location = new System.Drawing.Point(98, 435);
            this.lbIDd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDd.Name = "lbIDd";
            this.lbIDd.Size = new System.Drawing.Size(80, 20);
            this.lbIDd.TabIndex = 0;
            this.lbIDd.Text = "Dec. Deg:";
            this.lbIDd.Click += new System.EventHandler(this.lbIDd_Click);
            // 
            // tbxDeg
            // 
            this.tbxDeg.Location = new System.Drawing.Point(195, 80);
            this.tbxDeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDeg.Name = "tbxDeg";
            this.tbxDeg.Size = new System.Drawing.Size(58, 26);
            this.tbxDeg.TabIndex = 1;
            this.tbxDeg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(194, 148);
            this.tbxMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(58, 26);
            this.tbxMin.TabIndex = 2;
            this.tbxMin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxSec
            // 
            this.tbxSec.Location = new System.Drawing.Point(194, 243);
            this.tbxSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSec.Name = "tbxSec";
            this.tbxSec.Size = new System.Drawing.Size(58, 26);
            this.tbxSec.TabIndex = 3;
            this.tbxSec.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cboQuandrant
            // 
            this.cboQuandrant.FormattingEnabled = true;
            this.cboQuandrant.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "W"});
            this.cboQuandrant.Location = new System.Drawing.Point(194, 303);
            this.cboQuandrant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboQuandrant.Name = "cboQuandrant";
            this.cboQuandrant.Size = new System.Drawing.Size(70, 28);
            this.cboQuandrant.TabIndex = 4;
            // 
            // ldlDeg
            // 
            this.ldlDeg.AutoSize = true;
            this.ldlDeg.Location = new System.Drawing.Point(139, 80);
            this.ldlDeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ldlDeg.Name = "ldlDeg";
            this.ldlDeg.Size = new System.Drawing.Size(39, 20);
            this.ldlDeg.TabIndex = 5;
            this.ldlDeg.Text = "Deg";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(138, 152);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 20);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Min";
            this.lblMin.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(138, 243);
            this.lblSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(37, 20);
            this.lblSec.TabIndex = 7;
            this.lblSec.Text = "Sec";
            this.lblSec.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblQuandrant
            // 
            this.lblQuandrant.AutoSize = true;
            this.lblQuandrant.Location = new System.Drawing.Point(89, 303);
            this.lblQuandrant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuandrant.Name = "lblQuandrant";
            this.lblQuandrant.Size = new System.Drawing.Size(85, 20);
            this.lblQuandrant.TabIndex = 8;
            this.lblQuandrant.Text = "Quandrant";
            this.lblQuandrant.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(72, 508);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 34);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 508);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 591);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblQuandrant);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.ldlDeg);
            this.Controls.Add(this.cboQuandrant);
            this.Controls.Add(this.tbxSec);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.tbxDeg);
            this.Controls.Add(this.lbIDd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "DMS Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDd;
        private System.Windows.Forms.TextBox tbxDeg;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxSec;
        private System.Windows.Forms.ComboBox cboQuandrant;
        private System.Windows.Forms.Label ldlDeg;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblQuandrant;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

