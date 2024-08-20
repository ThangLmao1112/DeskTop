namespace BT_ThietKeForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btChonHang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btBoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTinhTIen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSoTIen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột ",
            "Bàn phím",
            "Máy in",
            "Usb Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(9, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 171);
            this.listBox1.TabIndex = 1;
            // 
            // btChonHang
            // 
            this.btChonHang.Location = new System.Drawing.Point(217, 195);
            this.btChonHang.Name = "btChonHang";
            this.btChonHang.Size = new System.Drawing.Size(113, 23);
            this.btChonHang.TabIndex = 2;
            this.btChonHang.Text = "Chọn hàng >";
            this.btChonHang.UseVisualStyleBackColor = true;
            this.btChonHang.Click += new System.EventHandler(this.btChonHang_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSoTIen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btTinhTIen);
            this.panel3.Controls.Add(this.btBoHang);
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(405, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 426);
            this.panel3.TabIndex = 3;
            // 
            // btBoHang
            // 
            this.btBoHang.Location = new System.Drawing.Point(40, 195);
            this.btBoHang.Name = "btBoHang";
            this.btBoHang.Size = new System.Drawing.Size(113, 23);
            this.btBoHang.TabIndex = 2;
            this.btBoHang.Text = "< Bỏ hàng";
            this.btBoHang.UseVisualStyleBackColor = true;
            this.btBoHang.Click += new System.EventHandler(this.btBoHang_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(187, 122);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 171);
            this.listBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng khách đã mua";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btTinhTIen
            // 
            this.btTinhTIen.Location = new System.Drawing.Point(239, 322);
            this.btTinhTIen.Name = "btTinhTIen";
            this.btTinhTIen.Size = new System.Drawing.Size(75, 23);
            this.btTinhTIen.TabIndex = 3;
            this.btTinhTIen.Text = "Tính tiền";
            this.btTinhTIen.UseVisualStyleBackColor = true;
            this.btTinhTIen.Click += new System.EventHandler(this.btTinhTIen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền thanh toán: ";
            // 
            // lbSoTIen
            // 
            this.lbSoTIen.AutoSize = true;
            this.lbSoTIen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTIen.ForeColor = System.Drawing.Color.Blue;
            this.lbSoTIen.Location = new System.Drawing.Point(197, 392);
            this.lbSoTIen.Name = "lbSoTIen";
            this.lbSoTIen.Size = new System.Drawing.Size(18, 20);
            this.lbSoTIen.TabIndex = 5;
            this.lbSoTIen.Text = "0";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChonHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btBoHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSoTIen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTinhTIen;
    }
}