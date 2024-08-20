namespace Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.grChonmau = new System.Windows.Forms.GroupBox();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grChonmau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(256, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(3, 49);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(3, 16);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // grChonmau
            // 
            this.grChonmau.Controls.Add(this.btnToMau);
            this.grChonmau.Controls.Add(this.rdXanh);
            this.grChonmau.Controls.Add(this.rdDo);
            this.grChonmau.Location = new System.Drawing.Point(256, 231);
            this.grChonmau.Name = "grChonmau";
            this.grChonmau.Size = new System.Drawing.Size(200, 100);
            this.grChonmau.TabIndex = 1;
            this.grChonmau.TabStop = false;
            this.grChonmau.Text = "Chọn màu";
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(3, 49);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(72, 17);
            this.rdXanh.TabIndex = 1;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Màu xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Checked = true;
            this.rdDo.Location = new System.Drawing.Point(3, 16);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(62, 17);
            this.rdDo.TabIndex = 0;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Màu đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(94, 29);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 2;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(462, 231);
            this.txtMau.Multiline = true;
            this.txtMau.Name = "txtMau";
            this.txtMau.ReadOnly = true;
            this.txtMau.Size = new System.Drawing.Size(161, 100);
            this.txtMau.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.grChonmau);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài tập 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grChonmau.ResumeLayout(false);
            this.grChonmau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox grChonmau;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.TextBox txtMau;
    }
}

