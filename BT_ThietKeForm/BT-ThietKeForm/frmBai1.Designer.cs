namespace BT_ThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbChonMauXe = new System.Windows.Forms.GroupBox();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdDen = new System.Windows.Forms.RadioButton();
            this.rdXam = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTinhTIen = new System.Windows.Forms.Button();
            this.lbSoTIen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbChonMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 430);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbChonMauXe
            // 
            this.gbChonMauXe.Controls.Add(this.rdTrang);
            this.gbChonMauXe.Controls.Add(this.rdDen);
            this.gbChonMauXe.Controls.Add(this.rdXam);
            this.gbChonMauXe.Location = new System.Drawing.Point(473, 77);
            this.gbChonMauXe.Name = "gbChonMauXe";
            this.gbChonMauXe.Size = new System.Drawing.Size(200, 100);
            this.gbChonMauXe.TabIndex = 1;
            this.gbChonMauXe.TabStop = false;
            this.gbChonMauXe.Text = "Chọn màu xe";
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(6, 66);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(53, 17);
            this.rdTrang.TabIndex = 2;
            this.rdTrang.Text = "Trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdDen
            // 
            this.rdDen.AutoSize = true;
            this.rdDen.Location = new System.Drawing.Point(7, 43);
            this.rdDen.Name = "rdDen";
            this.rdDen.Size = new System.Drawing.Size(45, 17);
            this.rdDen.TabIndex = 1;
            this.rdDen.Text = "Đen";
            this.rdDen.UseVisualStyleBackColor = true;
            this.rdDen.CheckedChanged += new System.EventHandler(this.rdDen_CheckedChanged);
            // 
            // rdXam
            // 
            this.rdXam.AutoSize = true;
            this.rdXam.Checked = true;
            this.rdXam.Location = new System.Drawing.Point(7, 20);
            this.rdXam.Name = "rdXam";
            this.rdXam.Size = new System.Drawing.Size(46, 17);
            this.rdXam.TabIndex = 0;
            this.rdXam.TabStop = true;
            this.rdXam.Text = "Xám";
            this.rdXam.UseVisualStyleBackColor = true;
            this.rdXam.CheckedChanged += new System.EventHandler(this.rdXam_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(467, 212);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(65, 17);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá: ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(467, 248);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(72, 17);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Số lượng: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(530, 206);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(143, 23);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = "22000";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(530, 242);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(143, 23);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // btTinhTIen
            // 
            this.btTinhTIen.Location = new System.Drawing.Point(559, 286);
            this.btTinhTIen.Name = "btTinhTIen";
            this.btTinhTIen.Size = new System.Drawing.Size(75, 23);
            this.btTinhTIen.TabIndex = 7;
            this.btTinhTIen.Text = "Tính tiền";
            this.btTinhTIen.UseVisualStyleBackColor = true;
            this.btTinhTIen.Click += new System.EventHandler(this.btTinhTIen_Click);
            // 
            // lbSoTIen
            // 
            this.lbSoTIen.AutoSize = true;
            this.lbSoTIen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTIen.Location = new System.Drawing.Point(453, 324);
            this.lbSoTIen.Name = "lbSoTIen";
            this.lbSoTIen.Size = new System.Drawing.Size(164, 20);
            this.lbSoTIen.TabIndex = 8;
            this.lbSoTIen.Text = "Tổng tiền thanh toán: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(638, 324);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(18, 20);
            this.lbThanhTien.TabIndex = 10;
            this.lbThanhTien.Text = "0";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSoTIen);
            this.Controls.Add(this.btTinhTIen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.gbChonMauXe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbChonMauXe.ResumeLayout(false);
            this.gbChonMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbChonMauXe;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdDen;
        private System.Windows.Forms.RadioButton rdXam;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTinhTIen;
        private System.Windows.Forms.Label lbSoTIen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbThanhTien;
    }
}