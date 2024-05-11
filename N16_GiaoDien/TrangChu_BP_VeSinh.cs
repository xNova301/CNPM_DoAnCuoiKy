using Mau02;
using Microsoft.SqlServer.Server;
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
using Xceed.Words.NET;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N16_GiaoDien
{
    public partial class TrangChu_BP_VeSinh : Form
    {
        private string connectionString = "Data Source=LAPTOP-SCJ3M8HC;Initial Catalog=CNPM;Integrated Security=True";
        public TrangChu_BP_VeSinh()
        {
            InitializeComponent();
            LoadDataFromDatabase(); // Load dữ liệu từ cơ sở dữ liệu khi Form4 được tạo

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TTinChiTietNV ttchitietNV = new TTinChiTietNV();
            ttchitietNV.Show();
        }

        private void yêuCầuTừCEOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuCEO_CacBP dSYeuCauTuCEO_CacBP = new DSYeuCauTuCEO_CacBP();
            this.Hide();
            dSYeuCauTuCEO_CacBP.Show();
        }

        private void yêuCầuTừKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuCEO_HCNS dSYeuCauTuCEO_HCNS = new DSYeuCauTuCEO_HCNS();
            this.Hide();
            dSYeuCauTuCEO_HCNS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu_CEO_CQL trangChu_CEO_CQL = new TrangChu_CEO_CQL();
            this.Hide();
            trangChu_CEO_CQL.Show();
        }
        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QUAN_TRI_CONG_VIEC";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Hiển thị dữ liệu lên các TextBox
                    textBox1.Text = reader["MACV"].ToString();
                    textBox2.Text = reader["TENCV"].ToString();
                    DateTime Thoigianbatdau = (DateTime)reader["THOIGIANBATDAU"];
                    dateTimePicker1.Value = Thoigianbatdau;
                    DateTime Thoigianketthuc = (DateTime)reader["THOIGIANKETTHUC"];
                    dateTimePicker1.Value = Thoigianketthuc;
                }

                reader.Close();
                textBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBox1.Enabled = false;
                button8.Enabled = false;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QUAN_TRI_CONG_VIEC WHERE MACV = @MACV";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MACV", textBox1.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Hiển thị dữ liệu lên các TextBox
                    textBox1.Text = reader["MACV"].ToString();
                    textBox2.Text = reader["TENCV"].ToString();
                    DateTime Thoigianbatdau = (DateTime)reader["THOIGIANBATDAU"];
                    dateTimePicker1.Value = Thoigianbatdau;
                    DateTime Thoigianketthuc = (DateTime)reader["THOIGIANKETTHUC"];
                    dateTimePicker1.Value = Thoigianketthuc;
                    ;
                }
                else
                {
                    MessageBox.Show("ID không tồn tại trong cơ sở dữ liệu.");
                }

                reader.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Câu lệnh UPDATE để cập nhật dữ liệu mới cho ID tương ứng
                string updateQuery = @"UPDATE QUAN_TRI_CONG_VIEC
                               SET MACV = @MACV, TENCV = @TENCV, THOIGIANBATDAU = @THOIGIANBATDAU, THOIGIANKETTHUC = @THOIGIANKETTHUC
                               WHERE MACV = @MACV";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@MACV", textBox1.Text);
                updateCommand.Parameters.AddWithValue("@TENCV", textBox2.Text);
                updateCommand.Parameters.AddWithValue("@THOIGIANBATDAU", dateTimePicker1.Value);
                updateCommand.Parameters.AddWithValue("@THOIGIANKETTHUC", dateTimePicker2.Value);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công.");
                }

                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            button8.Enabled = true;
            button11.Enabled = false;

        }

        private void TrangChu_BP_VeSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ngăn chặn form đóng lại
                e.Cancel = true;

                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string macvToDelete = textBox1.Text;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn Yes hay No
            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes, tiến hành xóa dòng từ cơ sở dữ liệu
                DeleteRowFromDatabase(macvToDelete);

                // Xóa dữ liệu từ TextBox và DateTimePicker sau khi xóa thành công
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                this.Show();
            }
            else
            {
                // Nếu người dùng chọn No, không làm gì cả
                // Có thể thêm mã lệnh xử lý tại đây nếu cần
            }
        }

        private void DeleteRowFromDatabase(string macv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM QUAN_TRI_CONG_VIEC WHERE MACV = @MACV";

                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@MACV", macv);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được xóa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
            button8.Enabled = false;
            button11.Enabled = true;
        }

        private void ExportToWord(string data)
        {
            try
            {
                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                string fileName = $"{downloadsPath}\\Bo_Phan_Ve_Sinh.docx";

                // Tạo một tài liệu Word mới
                using (DocX document = DocX.Create(fileName)) // Đường dẫn và tên file xuất
                {
                    // Thêm dữ liệu vào tài liệu Word
                    document.InsertParagraph(data);

                    // Lưu tài liệu Word
                    document.Save();

                    MessageBox.Show("Dữ liệu đã được xuất thành công vào tài liệu Word.", "Xuất file thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất tài liệu Word: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataToWord()
        {
            // Lấy dữ liệu từ các điều khiển và kết hợp thành một chuỗi dữ liệu
            string data = $"MACV: {textBox1.Text}{Environment.NewLine}" +
                          $"TENCV: {textBox2.Text}{Environment.NewLine}" +
                          $"THOIGIANBATDAU: {dateTimePicker1.Value.ToString()}{Environment.NewLine}" +
                          $"THOIGIANKETTHUC: {dateTimePicker2.Value.ToString()}{Environment.NewLine}";

            // Gọi phương thức xuất dữ liệu ra tài liệu Word
            ExportToWord(data);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ExportDataToWord();
        }
    }
}

