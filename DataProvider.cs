using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien_qlpks.DAO
{
    public class DataProvider
    {
            private string connectionSTR = @"Data Source=LAPTOP-JKMABAVK\TESTSQL;Initial Catalog=QUANLYPHONGKHACHSAN;Integrated Security=True;TrustServerCertificate=true;";
            public DataTable ExecuteQuery(string query)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
                return data;    
            }
            public SqlDataReader ExecuteReader(string query)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            public bool CheckLogin(string tendangnhap, string matkhaucu)
                {
                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM [dbo].[Table_USER] WHERE USERNAME = @TenDangNhap AND PASSWORD = @MatKhauCu";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TenDangNhap", tendangnhap);
                        command.Parameters.AddWithValue("@MatKhauCu", matkhaucu);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
           public object ExecuteScalar(string query)
            {
                object result = -1;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            result = command.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
                        }
                    }
                }

                return result;
            }
    }

}
