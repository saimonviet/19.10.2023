using GiaoDien_qlpks.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class quanlyphong : Form
    {
        public quanlyphong()
        {
            InitializeComponent();
        }
        void loadphong( string selectedPhong)
        {
            if (string.IsNullOrEmpty(selectedPhong)) { return; }
            string query = "";
            if (selectedPhong == "Danh sách phòng trống")
                {
                     query = "SELECT SOPHONG FROM [dbo].[Table_IDPHONG] WHERE TRANGTHAI = 1 ";
                }

            if (selectedPhong == "Danh sách phòng đã đặt")
            {
                     query = "SELECT SOPHONG FROM [dbo].[Table_IDPHONG] WHERE TRANGTHAI = 0 ";
            }
            DataProvider provider = new DataProvider();
                dtgvdanhsachphong.DataSource = provider.ExecuteQuery(query);

        }

        private void tabkiemtra_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhong = cbxem.SelectedItem.ToString();
            loadphong(selectedPhong);
        }
    }
}
