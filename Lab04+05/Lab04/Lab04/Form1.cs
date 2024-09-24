using Lab04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;


namespace Lab04
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        #region Phương thức bổ trợ 
        //Lấy thông tin từ controls thông tin SV
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MSSV = this.mtbxMSSV.Text;
            sv.HoTen = this.txtHovaTen.Text;
            sv.NgaySinh = this.dtbNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cbbLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;

            return sv;
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');

            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtbxMSSV.Text = sv.MSSV;
            this.txtHovaTen.Text = sv.HoTen;
            this.dtbNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbbLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

        }
        private void LuuSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                LuuSV(sv);
            }
        }
        #endregion

        #region Các sự kiện
        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            LoadListView();

        }
     

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Luu(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtbxMSSV.Text = "";
            this.txtHovaTen.Text = "";
            this.dtbNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
        }
        #endregion

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {

                    string path = file.FileName;
                    Image img = Image.FromFile(path);
                    pbHinh.Image = img;
                    txtHinh.Text = path;
                }
            }
        }

        private List<SinhVien> LoadJSON(string Path)
        {
            List<SinhVien> List = new List<SinhVien>();
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); 
            var array = (JObject)JsonConvert.DeserializeObject(json);
            var students = array["sinhvien"].Children();
            foreach (var item in students) 
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                DateTime ngaysinh = item["ngaysinh"].Value<DateTime>();
                string diachi = item["diachi"].Value<string>();
                string lop = item["lop"].Value<string>();
                string hinh = item["hinh"].Value<string>();
                bool gioitinh = item["gioitinh"].Value<bool>();
                string mail = item["mail"].Value<string>();
                SinhVien info = new SinhVien(mssv, hoten,  ngaysinh, diachi, lop, hinh, gioitinh, mail);
                List.Add(info);
            }
            return List;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string Str = ""; 
            string Path = "D:\\Lab04\\Lab04\\Lab04\\TTSV.json"; 
            List<SinhVien> List = LoadJSON(Path);
            for (int i = 0; i < List.Count; i++) 
            {
                SinhVien info = List[i];
                string s = "nữ";
                if (info.GioiTinh)
                {
                    s = "nam";
                }
                Str += string.Format("Sinh viên {0} có MSSV: {1}, Họ tên: {2}, Ngày sinh: {3}, Địa chỉ: {4}, Lớp: {5}, Giới tính: {6}, Mail: {7}\r\n", (i + 1), info.MSSV, info.HoTen, info.NgaySinh, info.DiaChi, info.Lop, s, info.Mail);
            }
            MessageBox.Show(Str);
        }
    }
}
