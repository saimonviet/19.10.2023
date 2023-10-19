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
        }


        private void xoa_Click(object sender, EventArgs e)
        {

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
                // "Tên_Cột" là tên của cột mà bạn muốn lấy dữ liệu từ đó
            }
        }
    }
}
