using Mau02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N16_GiaoDien
{
    public partial class TrangChu_BP_VeSinh : Form
    {
        public TrangChu_BP_VeSinh()
        {
            InitializeComponent();
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
            this.Hide();
            ttchitietNV.Show();
        }
    }
}
