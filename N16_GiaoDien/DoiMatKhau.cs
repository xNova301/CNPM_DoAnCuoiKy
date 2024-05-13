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
using Mau02;

namespace N16_GiaoDien
{
    public partial class DoiMatKhau : Form
    {
        NhanVien nhanVien;
        public DoiMatKhau(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String connectString = @"Data Source=HoangMinh\SQLEXPRESS;Initial Catalog=QUAN_LY_CONG_VIEC;Integrated Security=True";

            String newMK = textBox3.Text;

            String confMK = textBox4.Text;

            if (newMK == confMK)
            {
                String query = $"UPDATE NHAN_VIEN SET MK = '{newMK}' WHERE USERID = '{nhanVien.userID}'";

                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();

                    nhanVien.mk = newMK;
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            TTinChiTietNV tinChiTietNV = new TTinChiTietNV(nhanVien);
            this.Hide();
            tinChiTietNV.Show();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            textBox2.Text = nhanVien.mk;
            textBox2.PasswordChar = '*';

        }
    }
}
