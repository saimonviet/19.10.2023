using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_qlpks
{
    public partial class Dichvu : Form
    {
        public Dichvu()
        {
            InitializeComponent();
            loaddichvulist();
        }
        void loaddichvulist()
        {
            string query = "SELECT * FROM [dbo].[Table_SANPHAM]";
            DataProvider provider = new DataProvider();
            dtgvdichvu.DataSource = provider.ExecuteQuery(query);
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {

        }

        private void btcapnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                string query = $"UPDATE [dbo].[Table_SANPHAM] SET DONGIA = '{dongia.Text}' WHERE TENSANPHAM = '{tensanpham.Text}'";
                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);
                loaddichvulist();
                tensanpham.Text = "";
                dongia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin !");
            }
        }


        private void xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có dữ liệu hay không
            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                // Lấy giá trị từ TextBox
                string tensp = tensanpham.Text;
                string gia = dongia.Text;

                // Tạo câu truy vấn SQL DELETE
                string query = $"DELETE FROM [dbo].[Table_SANPHAM] WHERE TENSANPHAM = '{tensp}' AND DONGIA = '{gia}'";
                // Sử dụng class DataProvider để thực hiện truy vấn
                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);
                // Cập nhật DataGridView
                loaddichvulist();

                // Xóa dữ liệu từ TextBox sau khi thêm vào DataGridView
                tensanpham.Text = "";
                dongia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgvdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ số hàng hợp lệ được chọn
            {
                DataGridViewRow row = dtgvdichvu.Rows[e.RowIndex]; // Lấy dữ liệu từ dòng đã chọn
                tensanpham.Text = row.Cells["TENSANPHAM"].Value.ToString();
                dongia.Text = row.Cells["DONGIA"].Value.ToString();
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có dữ liệu hay không
            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                // Lấy giá trị từ TextBox
                string tensp = tensanpham.Text;
                string gia = dongia.Text;

                // Tạo câu truy vấn SQL INSERT
                string query = $"INSERT INTO [dbo].[Table_SANPHAM] (TENSANPHAM, DONGIA) VALUES ('{tensp}', '{gia}')";

                // Sử dụng class DataProvider để thực hiện truy vấn
                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);

                // Cập nhật DataGridView
                loaddichvulist();

                // Xóa dữ liệu từ TextBox sau khi thêm vào DataGridView
                tensanpham.Text = "";
                dongia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
