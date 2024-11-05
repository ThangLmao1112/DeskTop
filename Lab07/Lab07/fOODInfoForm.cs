using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Lab07
{
    public partial class fOODInfoForm : Form
    {
        public fOODInfoForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void InitValues()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "server=PC827; database=RestaurantManagement; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connectionString);


            // Tạo một đối tượng SqlCommand để thực thi câu lệnh SQL
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID, Name FROM Category";

            // Tạo một đối tượng SqlDataAdapter để đọc dữ liệu từ SqlCommand và đổ vào DataSet
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            // Mở kết nối đến cơ sở dữ liệu
            conn.Open();

            // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable trong DataSet
            adapter.Fill(ds, "Category");

            // Gán nguồn dữ liệu cho ComboBox
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            // Đóng kết nối và giải phóng tài nguyên
            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();

        }
        private void fOODInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "server=PC827; database=RestaurantManagement; Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connectionString);


                // Tạo một đối tượng SqlCommand để thực thi câu lệnh SQL
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryId, @price, @notes";
                cmd.Connection = conn;

                // Thêm các tham số vào đối tượng Command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.VarChar, 3000);

                // Thiết lập tham số @id là tham số đầu ra
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Truyền giá trị vào thủ tục qua các tham số
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;


                // Mở kết nối đến cơ sở dữ liệu
                conn.Open();

                // Thực thi câu lệnh SQL và trả về số lượng hàng bị ảnh hưởng
                int numRowAffected = cmd.ExecuteNonQuery();

                // Kiểm tra kết quả
                if (numRowAffected > 0)
                {
                    // Lấy giá trị ID vừa được tạo ra
                    string foodID = cmd.Parameters["@id"].Value.ToString();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Successfully adding new food. Food ID = " + foodID, "Message");

                    // Đặt lại các control trên form
                    this.ResetText();
                }
                else
                {
                    // Hiển thị thông báo thất bại
                    MessageBox.Show("Adding food failed");
                }

                // Đóng kết nối
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                // Bắt lỗi SQL và hiển thị thông báo
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                // Bắt các lỗi khác và hiển thị thông báo
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                // Gán giá trị từ DataRowView vào các textbox tương ứng
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();


                // Reset selected index của combobox
                cbbCatName.SelectedIndex = -1;

                // Tìm và chọn nhóm món ăn tương ứng trong combobox
                for (int index = 0; index < cbbCatName.Items.Count; index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)

            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "server=PC827; database=RestaurantManagement; Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connectionString);


                // Tạo một đối tượng SqlCommand để thực thi câu lệnh SQL
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryId, @price, @notes";
                cmd.Connection = conn;

                // Thêm các tham số vào đối tượng Command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.VarChar, 3000);

                // Truyền giá trị vào thủ tục qua các tham số
                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                // Mở kết nối đến cơ sở dữ liệu
                conn.Open();

                // Thực thi câu lệnh SQL và trả về số lượng hàng bị ảnh hưởng
                int numRowAffected = cmd.ExecuteNonQuery();

                // Thông báo kết quả
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfully updating food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }

                // Đóng kết nối
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
