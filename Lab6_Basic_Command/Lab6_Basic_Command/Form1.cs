﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Lab6_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "server.; database RestaurantManagement; Integrated Security true; ";
            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // Thiết lập lệnh truy văn cho đối tượng Command
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();
            // Thực thì lệnh bằng phương thức ExcuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // Gọi hàm hiển thị dữ liệu lên màn hình
            this.DisplayCategory(sqlDataReader);
            // Đông kết nối
            sqlConnection.Close();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            // Xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();
            // Đọc một dòng dữ liệu
            while (reader.Read())
            {
                // Tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                // Thêm dòng mới vào ListView
                lvCategory.Items.Add(item);
                // Bổ sung các thông tin khác cho ListViewItem
                item.SubItems.Add(reader["Name"].ToString()); item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database Restaurant Management; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // Tạo đối tượng thực thi lệnh SqlCommand
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "INSERT INTO Category (Name, [Type])" + "VALUES (N'" + txtName.Text + "'," +txtType.Text + ")";
            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();
            // Thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            // Đóng kết nối sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                // Tải lại dữ liệu
                btnLoad.PerformClick();
                // Xóa các ô nhập
                txtName.Text = ""; txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            // Lấy dòng được chọn trong Listview
            ListViewItem item = lvCategory.SelectedItems[0];
            // Hiển thị dữ liệu lên Textbox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";
            // Hiển thị nút cập nhật và xóa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server.; database Restaurant Management; Integrated Security = true; "; 
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "',[Type]=" + txtType.Text + "Where ID=" + txtID.Text;
            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();
            // Thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            // Đông kết nối
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                // Cập nhật lại dữ liệu trên Listview
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text; item.SubItems[2].Text = txtType.Text;
                // Xóa các ô nhập
                txtID.Text = ""; txtName.Text = "";
                txtType.Text = "";
                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }
    }
}
