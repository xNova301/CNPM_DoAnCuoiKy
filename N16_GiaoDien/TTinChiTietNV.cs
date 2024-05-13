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
using GiaoDien;
using Mau02;

namespace N16_GiaoDien
{
    public partial class TTinChiTietNV : Form
    {
        NhanVien nhanVien;
        public TTinChiTietNV(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void formLoad(object sender, EventArgs e)
        {
            textBox1.Text = nhanVien.MANV;
            textBox2.Text = nhanVien.name;
            textBox3.Text = nhanVien.sdt;
            textBox4.Text = nhanVien.email;
            textBox6.Text = nhanVien.chucVu;
            textBox7.Text = nhanVien.boPhan;
            textBox8.Text = nhanVien.maBP;
            comboBox1.Text = nhanVien.loaiNV;
            numericUpDown1.Value = nhanVien.salary;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(nhanVien);
            this.Hide();

            doiMatKhau.Show();
        }

        // Chỉnh sửa
        private void button2_Click(object sender, EventArgs e)
        {
            nhanVien.name = textBox2.Text;
            nhanVien.sdt = textBox3.Text;
            nhanVien.email = textBox4.Text;
            nhanVien.chucVu = textBox6.Text;
            nhanVien.salary = (int)numericUpDown1.Value;
            String USERID = nhanVien.MANV + "." + nhanVien.name.ToUpper() + "." + nhanVien.sdt;
            String connectString = @"Data Source=HoangMinh\SQLEXPRESS;Initial Catalog=QUAN_LY_CONG_VIEC;Integrated Security=True";

            string query = $"UPDATE NHAN_VIEN SET HOTEN = N'{nhanVien.name}', SDT = '{nhanVien.sdt}', EMAIL = '{nhanVien.email}', CHUCVU = '{nhanVien.chucVu}', USERID = '{USERID}', LUONG = '{nhanVien.salary}', LOAINV = N'{nhanVien.loaiNV}' WHERE MANV = '{nhanVien.MANV}'";

            Console.WriteLine(query);
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            this.Hide();
            if (nhanVien.chucVu == "AN NINH")
            {
                TrangChu_BP_AnNinh trangChu_BP_AnNinh = new TrangChu_BP_AnNinh(nhanVien);
                this.Hide();
                trangChu_BP_AnNinh.Show();
            }
            else if (nhanVien.chucVu == "HCNS")
            {
                TrangChu_BP_HCNS trangChu_BP_HCNS = new TrangChu_BP_HCNS(nhanVien);
                this.Hide();
                trangChu_BP_HCNS.Show();
            }
            else if (nhanVien.chucVu == "KTBT")
            {
                TrangChu_BP_KTBT trangChu_BP_KTBT = new TrangChu_BP_KTBT(nhanVien);
                this.Hide();
                trangChu_BP_KTBT.Show();
            }
            else if (nhanVien.chucVu == "TCKT")
            {
                TrangChu_BP_TCKT trangChu_BP_TCKT = new TrangChu_BP_TCKT(nhanVien);
                this.Hide();
                trangChu_BP_TCKT.Show();
            }
            else if (nhanVien.chucVu == "VE SINH")
            {
                TrangChu_BP_VeSinh trangChu_BP_VeSinh = new TrangChu_BP_VeSinh(nhanVien);
                this.Hide();
                trangChu_BP_VeSinh.Show();
            }
            else if (nhanVien.chucVu == "XAY DUNG")
            {
                TrangChu_BP_XayDung trangChu_BP_XayDung = new TrangChu_BP_XayDung(nhanVien);
                this.Hide();
                trangChu_BP_XayDung.Show();
            }
            else if (nhanVien.chucVu == "CEO")
            {
                TrangChu_CEO_CQL trangChu_CEO = new TrangChu_CEO_CQL(nhanVien);
                this.Hide();
                trangChu_CEO.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            numericUpDown1.Enabled = true;
            comboBox1.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;

        }
    }
}
