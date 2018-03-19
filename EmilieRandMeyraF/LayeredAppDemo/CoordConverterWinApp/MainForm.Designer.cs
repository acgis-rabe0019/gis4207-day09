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
            this.lblDd = new System.Windows.Forms.Label();
            this.tbxDeg = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxSec = new System.Windows.Forms.TextBox();
            this.cboQuandrant = new System.Windows.Forms.ComboBox();
            this.lblDeg = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblQuandrant = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDd
            // 
            this.lblDd.AutoSize = true;
            this.lblDd.Location = new System.Drawing.Point(150, 664);
            this.lblDd.Name = "lblDd";
            this.lblDd.Size = new System.Drawing.Size(140, 32);
            this.lblDd.TabIndex = 0;
            this.lblDd.Text = "Dec. Deg:";
            // 
            // tbxDeg
            // 
            this.tbxDeg.Location = new System.Drawing.Point(346, 124);
            this.tbxDeg.Name = "tbxDeg";
            this.tbxDeg.Size = new System.Drawing.Size(100, 38);
            this.tbxDeg.TabIndex = 1;
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(345, 230);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(100, 38);
            this.tbxMin.TabIndex = 2;
            // 
            // tbxSec
            // 
            this.tbxSec.Location = new System.Drawing.Point(344, 334);
            this.tbxSec.Name = "tbxSec";
            this.tbxSec.Size = new System.Drawing.Size(100, 38);
            this.tbxSec.TabIndex = 3;
            // 
            // cboQuandrant
            // 
            this.cboQuandrant.FormattingEnabled = true;
            this.cboQuandrant.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "W"});
            this.cboQuandrant.Location = new System.Drawing.Point(345, 438);
            this.cboQuandrant.Name = "cboQuandrant";
            this.cboQuandrant.Size = new System.Drawing.Size(121, 39);
            this.cboQuandrant.TabIndex = 4;
            this.cboQuandrant.SelectedIndexChanged += new System.EventHandler(this.cboQuandrant_SelectedIndexChanged);
            // 
            // lblDeg
            // 
            this.lblDeg.AutoSize = true;
            this.lblDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeg.Location = new System.Drawing.Point(247, 124);
            this.lblDeg.Name = "lblDeg";
            this.lblDeg.Size = new System.Drawing.Size(67, 32);
            this.lblDeg.TabIndex = 5;
            this.lblDeg.Text = "Deg";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(246, 235);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(61, 32);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Min";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(245, 334);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(64, 32);
            this.lblSec.TabIndex = 7;
            this.lblSec.Text = "Sec";
            // 
            // lblQuandrant
            // 
            this.lblQuandrant.AutoSize = true;
            this.lblQuandrant.Location = new System.Drawing.Point(159, 438);
            this.lblQuandrant.Name = "lblQuandrant";
            this.lblQuandrant.Size = new System.Drawing.Size(150, 32);
            this.lblQuandrant.TabIndex = 8;
            this.lblQuandrant.Text = "Quandrant";
            this.lblQuandrant.Click += new System.EventHandler(this.lblQuandrant_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(112, 788);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(178, 52);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(505, 788);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 51);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(828, 916);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblQuandrant);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblDeg);
            this.Controls.Add(this.cboQuandrant);
            this.Controls.Add(this.tbxSec);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.tbxDeg);
            this.Controls.Add(this.lblDd);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "MainForm";
            this.Text = "DMS Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDd;
        private System.Windows.Forms.TextBox tbxDeg;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxSec;
        private System.Windows.Forms.ComboBox cboQuandrant;
        private System.Windows.Forms.Label lblDeg;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblQuandrant;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

