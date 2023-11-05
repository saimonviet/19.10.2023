namespace GiaoDien_qlpks
{
    partial class quanlyphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tabquanly = new TabControl();
            tabkiemtra = new TabPage();
            btcapnhap = new Button();
            panel3 = new Panel();
            vesinhphong = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            trangthai = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            loaiphong = new TextBox();
            label2 = new Label();
            cbchonphong = new ComboBox();
            label1 = new Label();
            tabdanhsach = new TabPage();
            dtgvdanhsachphong = new DataGridView();
            cbxem = new ComboBox();
            label6 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tabquanly.SuspendLayout();
            tabkiemtra.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachphong).BeginInit();
            SuspendLayout();
            // 
            // tabquanly
            // 
            tabquanly.Controls.Add(tabkiemtra);
            tabquanly.Controls.Add(tabdanhsach);
            tabquanly.Location = new Point(5, 4);
            tabquanly.Name = "tabquanly";
            tabquanly.SelectedIndex = 0;
            tabquanly.Size = new Size(718, 460);
            tabquanly.TabIndex = 0;
            // 
            // tabkiemtra
            // 
            tabkiemtra.BackColor = Color.MistyRose;
            tabkiemtra.Controls.Add(btcapnhap);
            tabkiemtra.Controls.Add(panel3);
            tabkiemtra.Controls.Add(panel2);
            tabkiemtra.Controls.Add(panel1);
            tabkiemtra.Controls.Add(cbchonphong);
            tabkiemtra.Controls.Add(label1);
            tabkiemtra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tabkiemtra.Location = new Point(4, 32);
            tabkiemtra.Name = "tabkiemtra";
            tabkiemtra.Padding = new Padding(3);
            tabkiemtra.Size = new Size(710, 424);
            tabkiemtra.TabIndex = 0;
            tabkiemtra.Text = "Kiểm tra phòng";
            tabkiemtra.Click += tabkiemtra_Click;
            // 
            // btcapnhap
            // 
            btcapnhap.BackColor = Color.IndianRed;
            btcapnhap.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btcapnhap.Location = new Point(310, 349);
            btcapnhap.Name = "btcapnhap";
            btcapnhap.Size = new Size(117, 45);
            btcapnhap.TabIndex = 7;
            btcapnhap.Text = "Cập nhập";
            btcapnhap.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(vesinhphong);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(704, 64);
            panel3.TabIndex = 5;
            // 
            // vesinhphong
            // 
            vesinhphong.Location = new Point(241, 12);
            vesinhphong.Name = "vesinhphong";
            vesinhphong.Size = new Size(454, 31);
            vesinhphong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Location = new Point(9, 18);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 0;
            label4.Text = "Vệ sinh phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(trangthai);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 64);
            panel2.TabIndex = 4;
            // 
            // trangthai
            // 
            trangthai.Location = new Point(241, 15);
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(454, 31);
            trangthai.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Location = new Point(9, 15);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Trạng thái";
            // 
            // panel1
            // 
            panel1.Controls.Add(loaiphong);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 64);
            panel1.TabIndex = 3;
            // 
            // loaiphong
            // 
            loaiphong.Location = new Point(241, 12);
            loaiphong.Name = "loaiphong";
            loaiphong.Size = new Size(454, 31);
            loaiphong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 0;
            label2.Text = "Loại phòng";
            // 
            // cbchonphong
            // 
            cbchonphong.FormattingEnabled = true;
            cbchonphong.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130" });
            cbchonphong.Location = new Point(241, 23);
            cbchonphong.Name = "cbchonphong";
            cbchonphong.Size = new Size(457, 31);
            cbchonphong.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn phòng";
            label1.Click += label1_Click;
            // 
            // tabdanhsach
            // 
            tabdanhsach.BackColor = Color.MistyRose;
            tabdanhsach.Controls.Add(dtgvdanhsachphong);
            tabdanhsach.Controls.Add(cbxem);
            tabdanhsach.Controls.Add(label6);
            tabdanhsach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabdanhsach.Location = new Point(4, 24);
            tabdanhsach.Name = "tabdanhsach";
            tabdanhsach.Padding = new Padding(3);
            tabdanhsach.Size = new Size(710, 432);
            tabdanhsach.TabIndex = 1;
            tabdanhsach.Text = "Danh sách phòng";
            // 
            // dtgvdanhsachphong
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvdanhsachphong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvdanhsachphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtgvdanhsachphong.DefaultCellStyle = dataGridViewCellStyle8;
            dtgvdanhsachphong.Location = new Point(3, 43);
            dtgvdanhsachphong.Name = "dtgvdanhsachphong";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgvdanhsachphong.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgvdanhsachphong.RowTemplate.Height = 25;
            dtgvdanhsachphong.Size = new Size(704, 378);
            dtgvdanhsachphong.TabIndex = 3;
            // 
            // cbxem
            // 
            cbxem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbxem.FormattingEnabled = true;
            cbxem.Items.AddRange(new object[] { "Danh sách phòng đã đặt", "Danh sách phòng trống" });
            cbxem.Location = new Point(287, 6);
            cbxem.Name = "cbxem";
            cbxem.Size = new Size(237, 31);
            cbxem.TabIndex = 1;
            cbxem.SelectedIndexChanged += cbxem_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(230, 9);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 0;
            label6.Text = "Xem";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // quanlyphong
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 465);
            Controls.Add(tabquanly);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "quanlyphong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý phòng";
            tabquanly.ResumeLayout(false);
            tabkiemtra.ResumeLayout(false);
            tabkiemtra.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabdanhsach.ResumeLayout(false);
            tabdanhsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachphong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabquanly;
        private TabPage tabkiemtra;
        private TabPage tabdanhsach;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox cbchonphong;
        private TextBox loaiphong;
        private Panel panel3;
        private TextBox vesinhphong;
        private Label label4;
        private Panel panel2;
        private TextBox trangthai;
        private Label label3;
        private Button btcapnhap;
        private Label label6;
        private ComboBox cbxem;
        private DataGridView dtgvdanhsachphong;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}