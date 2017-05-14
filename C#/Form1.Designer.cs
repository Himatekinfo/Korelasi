namespace Korelasi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkDelValue = new System.Windows.Forms.LinkLabel();
            this.lnkAddValue = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXYValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblX2Value = new System.Windows.Forms.Label();
            this.lblXValue = new System.Windows.Forms.Label();
            this.lblY2Value = new System.Windows.Forms.Label();
            this.lblYValue = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYValue);
            this.groupBox2.Controls.Add(this.lblY2Value);
            this.groupBox2.Controls.Add(this.lblXValue);
            this.groupBox2.Controls.Add(this.lblX2Value);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblXYValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblNValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "r Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkDelValue);
            this.groupBox1.Controls.Add(this.lnkAddValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // lnkDelValue
            // 
            this.lnkDelValue.AutoSize = true;
            this.lnkDelValue.Location = new System.Drawing.Point(116, 137);
            this.lnkDelValue.Name = "lnkDelValue";
            this.lnkDelValue.Size = new System.Drawing.Size(68, 13);
            this.lnkDelValue.TabIndex = 3;
            this.lnkDelValue.TabStop = true;
            this.lnkDelValue.Text = "Delete Value";
            // 
            // lnkAddValue
            // 
            this.lnkAddValue.AutoSize = true;
            this.lnkAddValue.Location = new System.Drawing.Point(54, 137);
            this.lnkAddValue.Name = "lnkAddValue";
            this.lnkAddValue.Size = new System.Drawing.Size(56, 13);
            this.lnkAddValue.TabIndex = 2;
            this.lnkAddValue.TabStop = true;
            this.lnkAddValue.Text = "Add Value";
            this.lnkAddValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddValue_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(339, 112);
            this.dgvData.TabIndex = 0;
            // 
            // txtRValue
            // 
            this.txtRValue.Location = new System.Drawing.Point(63, 89);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(264, 20);
            this.txtRValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nValue :";
            // 
            // lblNValue
            // 
            this.lblNValue.AutoSize = true;
            this.lblNValue.Location = new System.Drawing.Point(69, 25);
            this.lblNValue.Name = "lblNValue";
            this.lblNValue.Size = new System.Drawing.Size(41, 13);
            this.lblNValue.TabIndex = 3;
            this.lblNValue.Text = "{value}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Σxy :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Σx :";
            // 
            // lblXYValue
            // 
            this.lblXYValue.AutoSize = true;
            this.lblXYValue.Location = new System.Drawing.Point(69, 47);
            this.lblXYValue.Name = "lblXYValue";
            this.lblXYValue.Size = new System.Drawing.Size(41, 13);
            this.lblXYValue.TabIndex = 6;
            this.lblXYValue.Text = "{value}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Σy :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Σx² :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Σy² :";
            // 
            // lblX2Value
            // 
            this.lblX2Value.AutoSize = true;
            this.lblX2Value.Location = new System.Drawing.Point(178, 47);
            this.lblX2Value.Name = "lblX2Value";
            this.lblX2Value.Size = new System.Drawing.Size(41, 13);
            this.lblX2Value.TabIndex = 11;
            this.lblX2Value.Text = "{value}";
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = true;
            this.lblXValue.Location = new System.Drawing.Point(178, 25);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(41, 13);
            this.lblXValue.TabIndex = 12;
            this.lblXValue.Text = "{value}";
            // 
            // lblY2Value
            // 
            this.lblY2Value.AutoSize = true;
            this.lblY2Value.Location = new System.Drawing.Point(286, 47);
            this.lblY2Value.Name = "lblY2Value";
            this.lblY2Value.Size = new System.Drawing.Size(41, 13);
            this.lblY2Value.TabIndex = 13;
            this.lblY2Value.Text = "{value}";
            // 
            // lblYValue
            // 
            this.lblYValue.AutoSize = true;
            this.lblYValue.Location = new System.Drawing.Point(286, 25);
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(41, 13);
            this.lblYValue.TabIndex = 14;
            this.lblYValue.Text = "{value}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Korelasi (r)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.LinkLabel lnkDelValue;
        private System.Windows.Forms.LinkLabel lnkAddValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYValue;
        private System.Windows.Forms.Label lblY2Value;
        private System.Windows.Forms.Label lblXValue;
        private System.Windows.Forms.Label lblX2Value;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblXYValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRValue;

    }
}

