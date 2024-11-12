using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDA
    {
        // Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Food> GetAll()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_GetAll;

            // Đọc dữ liệu và trả về danh sách các đối tượng Food
            SqlDataReader reader = command.ExecuteReader();
            List<Food> list = new List<Food>();

            while (reader.Read())
            {
                Food food = new Food
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Unit = reader["Unit"].ToString(),
                    FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]),
                    Price = Convert.ToInt32(reader["Price"]),
                    Notes = reader["Notes"].ToString()
                };
                list.Add(food);
            }

            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }

        // Phương thức thêm, xoá, sửa theo thủ tục Food_InsertUpdateDelete
        public int Insert_Update_Delete(Food food, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput
            };
            command.Parameters.Add(IDPara).Value = food.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            command.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = food.Unit;
            command.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();

            // Nếu thành công thì trả về ID đã thêm, nếu không thì trả về 0
            if (result > 0)
            {
                return (int)command.Parameters["@ID"].Value;
            }
            return 0;
        }
    }
}
    

