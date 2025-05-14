using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataAccess
    {
        private static SqlConnection GetConnection()
        {
            // Sửa chuỗi kết nối để thay đổi máy chủ và cơ sở dữ liệu
            return new SqlConnection("Data Source=LAPTOP-EU1AELLQ\\ELWYN;Initial Catalog=QLTV;Integrated Security=True");
        }

        //sử dụng biến tĩnh (static) để lưu kết nối đang mở
        private static SqlConnection cnn;

        //phương thức connect
        public static void OpenConnection()
        {
            cnn = GetConnection(); // Tạo mới SqlConnection
            cnn.Open(); // Mở kết nối tới SQL Server
        }
        //phương thức disconncet
        public static void CloseConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close(); // Đóng kết nối nếu đang mở
            }
        }
        //Hàm chạy lệnh Sql lấy dữ liệu Data Query
        public static DataTable ThucThiQuery(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //ExecuteNonQuery -> dùng cho các truy vấn không trả về kết quả (thêm, xóa, sửa) -> trả về số dòng bị ảnh hưởng
        public static string ThucThiNonQuery(string sql)
        {
            try
            {
                OpenConnection(); // 1. Mở kết nối tới cơ sở dữ liệu
                SqlCommand cmd = cnn.CreateCommand(); // 2. Tạo lệnh SQL từ đối tượng SqlConnection
                cmd.CommandText = sql; // 3. Gán câu lệnh SQL cần thực thi
                cmd.ExecuteNonQuery(); // 4. Thực thi câu lệnh (không trả về dữ liệu)
                CloseConnection(); // 5. Đóng kết nối sau khi thực thi
                return "Success"; // 6. Trả về thành công
            }
            catch (Exception e)
            {
                return e.ToString(); // Trả về chuỗi mô tả lỗi nếu thực thi thất bại
            }
        }

        //Phương thức kiểm tra xem một truy vấn SQL có trả về dòng dữ liệu nào hay không
        public static bool ExcuteReader_bool(string sql)
        {
            OpenConnection(); //Mở kết nối đến cơ sở dữ liệu.
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader(); //Thực thi câu lệnh SQL và trả về kết quả dưới dạng SqlDataReader, cho phép đọc từng dòng kết quả giống như con trỏ.
            if (dr.Read()) //Gọi Read() để kiểm tra xem có dòng nào được trả về không:
            {
                dr.Close(); //Đảm bảo gọi dr.Close() để giải phóng tài nguyên.
                return true; //Nếu có dòng đầu tiên
            }
            else
            {
                dr.Close();
                return false;
            }
        }

        //MyExecuteScalar -> Dùng cho truy vấn trả về một giá trị, ví dụ: SELECT COUNT(*)
        public static string ExecuteScalar_string(string sql)
        {
            OpenConnection(); //Mở kết nối đến cơ sở dữ liệu.
            SqlCommand cmd = cnn.CreateCommand(); //Tạo một đối tượng thuộc SqlCommand để thực thi truy vấn
            cmd.CommandText = sql; //Gán chuỗi truy vấn SQL vào CommandText.
            return cmd.ExecuteScalar().ToString(); //.ToString() để chuyển đổi kết quả -> chuỗi
        }
    }
}

