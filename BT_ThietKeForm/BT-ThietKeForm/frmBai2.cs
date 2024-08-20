using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);

        }

        private void btBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btTinhTIen_Click(object sender, EventArgs e)
        {
            int sotTien = 0;
            foreach (string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        sotTien += 100000;
                        break;
                    case "Bàn phím":
                        sotTien += 150000;
                        break;
                    case "Máy in":
                        sotTien += 2000000;
                        break;
                    case "Usb Kingmax":
                        sotTien += 200000;
                        break;
                    default:
                        break;
                }
                lbSoTIen.Text = sotTien + " đồng";
            }    
        }
    }
}
