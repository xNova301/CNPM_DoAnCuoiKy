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
    public partial class TrangChu_CEO_CQL : Form
    {
        public TrangChu_CEO_CQL()
        {
            InitializeComponent();
        }

        private void TrangChu_CEO_CQL_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TTinChiTietNV ttchitietNV = new TTinChiTietNV();
            this.Hide();
            ttchitietNV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QTCD_TrangChu_HCNS qTCD_TrangChu_HCNS = new QTCD_TrangChu_HCNS();
            this.Hide();
            qTCD_TrangChu_HCNS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
