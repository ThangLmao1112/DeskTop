namespace Vidu2
{
    partial class frmGiaoVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaSo = new Label();
            lblDanhSachMonHoc = new Label();
            lblGiaoVienDay = new Label();
            lblDiaChiMail = new Label();
            lblSoDienThoai = new Label();
            lblGioiTinh = new Label();
            lblNgoaiNgu = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            cboMaSo = new ComboBox();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            chklbNgoaiNgu = new CheckedListBox();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtMail = new TextBox();
            mtxtSoDienThoai = new MaskedTextBox();
            label1 = new Label();
            lbDanhSachMH = new ListBox();
            lbMonHocDay = new ListBox();
            btnLuu = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnChon = new Button();
            btnXoa = new Button();
            label2 = new Label();
            linklbLienHe = new LinkLabel();
            SuspendLayout();
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaSo.Location = new Point(53, 52);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(49, 19);
            lblMaSo.TabIndex = 0;
            lblMaSo.Text = "Mã số";
            // 
            // lblDanhSachMonHoc
            // 
            lblDanhSachMonHoc.AutoSize = true;
            lblDanhSachMonHoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSachMonHoc.Location = new Point(168, 284);
            lblDanhSachMonHoc.Name = "lblDanhSachMonHoc";
            lblDanhSachMonHoc.Size = new Size(143, 19);
            lblDanhSachMonHoc.TabIndex = 1;
            lblDanhSachMonHoc.Text = "Danh Sách Môn Học";
            lblDanhSachMonHoc.Click += lblDanhSachMonHoc_Click;
            // 
            // lblGiaoVienDay
            // 
            lblGiaoVienDay.AutoSize = true;
            lblGiaoVienDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGiaoVienDay.Location = new Point(457, 284);
            lblGiaoVienDay.Name = "lblGiaoVienDay";
            lblGiaoVienDay.Size = new Size(162, 19);
            lblGiaoVienDay.TabIndex = 2;
            lblGiaoVienDay.Text = "Môn học giáo viên dạy";
            // 
            // lblDiaChiMail
            // 
            lblDiaChiMail.AutoSize = true;
            lblDiaChiMail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiaChiMail.Location = new Point(451, 142);
            lblDiaChiMail.Name = "lblDiaChiMail";
            lblDiaChiMail.Size = new Size(87, 19);
            lblDiaChiMail.TabIndex = 3;
            lblDiaChiMail.Text = "Địa chỉ mail";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoDienThoai.Location = new Point(451, 96);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(97, 19);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGioiTinh.Location = new Point(451, 47);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 19);
            lblGioiTinh.TabIndex = 5;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgoaiNgu
            // 
            lblNgoaiNgu.AutoSize = true;
            lblNgoaiNgu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgoaiNgu.Location = new Point(53, 196);
            lblNgoaiNgu.Name = "lblNgoaiNgu";
            lblNgoaiNgu.Size = new Size(80, 19);
            lblNgoaiNgu.TabIndex = 6;
            lblNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(53, 148);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(75, 19);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.Click += lblNgaySinh_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHoTen.Location = new Point(53, 99);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 19);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ tên";
            // 
            // cboMaSo
            // 
            cboMaSo.Font = new Font("Segoe UI", 10F);
            cboMaSo.FormattingEnabled = true;
            cboMaSo.Items.AddRange(new object[] { "001" });
            cboMaSo.Location = new Point(168, 52);
            cboMaSo.Name = "cboMaSo";
            cboMaSo.Size = new Size(121, 25);
            cboMaSo.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(168, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(247, 25);
            txtHoTen.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Location = new Point(168, 142);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(247, 25);
            dtpNgaySinh.TabIndex = 11;
            // 
            // chklbNgoaiNgu
            // 
            chklbNgoaiNgu.Font = new Font("Segoe UI", 10F);
            chklbNgoaiNgu.FormattingEnabled = true;
            chklbNgoaiNgu.Items.AddRange(new object[] { "Tiếng Anh", "Tiếng Pháp ", "Tiếng Nhật", "Tiếng Nga" });
            chklbNgoaiNgu.Location = new Point(168, 187);
            chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            chklbNgoaiNgu.Size = new Size(120, 94);
            chklbNgoaiNgu.TabIndex = 12;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Font = new Font("Segoe UI", 10F);
            rdNam.Location = new Point(539, 44);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(56, 23);
            rdNam.TabIndex = 13;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Segoe UI", 10F);
            rdNu.Location = new Point(644, 43);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(45, 23);
            rdNu.TabIndex = 14;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            rdNu.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F);
            txtMail.Location = new Point(554, 141);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(175, 25);
            txtMail.TabIndex = 15;
            // 
            // mtxtSoDienThoai
            // 
            mtxtSoDienThoai.Font = new Font("Segoe UI", 10F);
            mtxtSoDienThoai.Location = new Point(554, 95);
            mtxtSoDienThoai.Mask = "(999) 000-0000";
            mtxtSoDienThoai.Name = "mtxtSoDienThoai";
            mtxtSoDienThoai.Size = new Size(118, 25);
            mtxtSoDienThoai.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(168, 3);
            label1.Name = "label1";
            label1.Size = new Size(473, 37);
            label1.TabIndex = 17;
            label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            // 
            // lbDanhSachMH
            // 
            lbDanhSachMH.FormattingEnabled = true;
            lbDanhSachMH.ItemHeight = 15;
            lbDanhSachMH.Items.AddRange(new object[] { "Tin học cơ sở", "Lập trình cấu trúc C/C++", "Cơ sở dữ liệu ", "Tiếng Anh B1", "Tiếng Anh B2", "Lập trình hướng đối tượng", "Mạng máy tính ", "Công nghệ phần mềm ", "Phân tích TKHDT" });
            lbDanhSachMH.Location = new Point(168, 318);
            lbDanhSachMH.Name = "lbDanhSachMH";
            lbDanhSachMH.Size = new Size(158, 169);
            lbDanhSachMH.TabIndex = 18;
            // 
            // lbMonHocDay
            // 
            lbMonHocDay.FormattingEnabled = true;
            lbMonHocDay.ItemHeight = 15;
            lbMonHocDay.Location = new Point(457, 318);
            lbMonHocDay.Name = "lbMonHocDay";
            lbMonHocDay.Size = new Size(162, 169);
            lbMonHocDay.TabIndex = 19;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 15F);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(192, 537);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(93, 43);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(348, 537);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 43);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(509, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 43);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(357, 342);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(75, 46);
            btnChon.TabIndex = 23;
            btnChon.Text = ">>";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(357, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 46);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "<<";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(627, 583);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 25;
            label2.Text = "Website";
            // 
            // linklbLienHe
            // 
            linklbLienHe.AutoSize = true;
            linklbLienHe.Font = new Font("Segoe UI", 10F);
            linklbLienHe.Location = new Point(696, 583);
            linklbLienHe.Name = "linklbLienHe";
            linklbLienHe.Size = new Size(53, 19);
            linklbLienHe.TabIndex = 26;
            linklbLienHe.TabStop = true;
            linklbLienHe.Text = "Liên hệ";
            // 
            // frmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 607);
            Controls.Add(linklbLienHe);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(btnChon);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnLuu);
            Controls.Add(lbMonHocDay);
            Controls.Add(lbDanhSachMH);
            Controls.Add(label1);
            Controls.Add(mtxtSoDienThoai);
            Controls.Add(txtMail);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(chklbNgoaiNgu);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(cboMaSo);
            Controls.Add(lblHoTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblNgoaiNgu);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblDiaChiMail);
            Controls.Add(lblGiaoVienDay);
            Controls.Add(lblDanhSachMonHoc);
            Controls.Add(lblMaSo);
            Name = "frmGiaoVien";
            Text = "Giáo viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSo;
        private Label lblDanhSachMonHoc;
        private Label lblGiaoVienDay;
        private Label lblDiaChiMail;
        private Label lblSoDienThoai;
        private Label lblGioiTinh;
        private Label lblNgoaiNgu;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private ComboBox cboMaSo;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private CheckedListBox chklbNgoaiNgu;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtMail;
        private MaskedTextBox mtxtSoDienThoai;
        private Label label1;
        private ListBox lbDanhSachMH;
        private ListBox lbMonHocDay;
        private Button btnLuu;
        private Button btnCancel;
        private Button btnExit;
        private Button btnChon;
        private Button btnXoa;
        private Label label2;
        private LinkLabel linklbLienHe;
    }
}
