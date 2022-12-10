using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTC
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand SqlCommand;//dùng để truy vấn các câu lệnh insert, update, dele,...
        SqlDataReader dataReader; //dùng để đọc dữ liệu trong bảng 
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = SqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }    

                sqlConnection.Close();
            }

            return taiKhoans;
        }
    }
}
