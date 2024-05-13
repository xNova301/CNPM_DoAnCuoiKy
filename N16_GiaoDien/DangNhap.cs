using GiaoDien;
using N16_GiaoDien;
using System.Data;
using System.Data.SqlClient;

namespace Mau02
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        String connectString = @"Data Source=HoangMinh\SQLEXPRESS;Initial Catalog=QUAN_LY_CONG_VIEC;Integrated Security=True";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string tendangnhap = textBox1.Text;
            string matkhau = textBox2.Text;

            string query = $"SELECT NHAN_VIEN.MANV, MACV, HOTEN, SDT, EMAIL, CHUCVU, LUONG, LOAINV, USERID, BO_PHAN.TENBP, BO_PHAN.MABP, MK FROM NHAN_VIEN, LAM_VIEC, BO_PHAN WHERE USERID = '{tendangnhap}' AND NHAN_VIEN.MANV = LAM_VIEC.MANV AND LAM_VIEC.MABP = BO_PHAN.MABP";

            NhanVien? NHAN_VIEN = null;

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                // Console.WriteLine(command.ExecuteScalar());
                DataTable results = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    results.Load(reader);

                    foreach (DataRow row in results.Rows)
                    {
                        NHAN_VIEN = new NhanVien(
                            ((string)row[0]).Trim(), ((string)row[1]).Trim(), ((string)row[2]).Trim(),
                            ((string)row[3]).Trim(), ((string)row[4]).Trim(), ((string)row[5]).Trim(), Convert.ToInt32(row[6]),
                            ((string)row[7]).Trim(), ((string)row[8]).Trim(), ((string)row[9]).Trim(), ((string)row[10]).Trim(), ((string)row[11]).Trim());
                    }
                }
                conn.Close();
            }

            if (NHAN_VIEN == null)
            {
                return;
            }

            if (matkhau.Equals(NHAN_VIEN.mk))
            {

                Console.WriteLine("NHAN VIEN: " + NHAN_VIEN.chucVu);

                if (NHAN_VIEN.chucVu == "AN NINH")
                {
                    TrangChu_BP_AnNinh trangChu_BP_AnNinh = new TrangChu_BP_AnNinh(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_AnNinh.Show();
                }
                else if (NHAN_VIEN.chucVu == "HCNS")
                {
                    TrangChu_BP_HCNS trangChu_BP_HCNS = new TrangChu_BP_HCNS(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_HCNS.Show();
                }
                else if (NHAN_VIEN.chucVu == "KTBT")
                {
                    TrangChu_BP_KTBT trangChu_BP_KTBT = new TrangChu_BP_KTBT(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_KTBT.Show();
                }
                else if (NHAN_VIEN.chucVu == "TCKT")
                {
                    TrangChu_BP_TCKT trangChu_BP_TCKT = new TrangChu_BP_TCKT(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_TCKT.Show();
                }
                else if (NHAN_VIEN.chucVu == "VE SINH")
                {
                    TrangChu_BP_VeSinh trangChu_BP_VeSinh = new TrangChu_BP_VeSinh(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_VeSinh.Show();
                }
                else if (NHAN_VIEN.chucVu == "XAY DUNG")
                {
                    TrangChu_BP_XayDung trangChu_BP_XayDung = new TrangChu_BP_XayDung(NHAN_VIEN);
                    this.Hide();
                    trangChu_BP_XayDung.Show();
                }
                else if (NHAN_VIEN.chucVu == "CEO")
                {
                    TrangChu_CEO_CQL trangChu_CEO = new TrangChu_CEO_CQL(NHAN_VIEN);
                    this.Hide();
                    trangChu_CEO.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập/ Mật khẩu sai! Vui lòng nhập lại!");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
