using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2212458
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

 

        private void cbTiengAnhA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTienTHB_Click(object sender, EventArgs e)
        {

        }

        private void cbTinHocB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTinHocA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void Reset()
        {
            this.cbbMaHocVien.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdbNam.Checked = true;
            this.cbTinHocA.Checked = false;
            this.cbTinHocB.Checked = false;
            this.cbTiengAnhA.Checked = false;
            this.cbTiengAnhB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (cbTinHocA.Checked)
                s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (cbTinHocB.Checked)
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (cbTiengAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (cbTiengAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";
        }
        private void frmDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
