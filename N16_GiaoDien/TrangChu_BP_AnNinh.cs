using Mau02;
using N16_GiaoDien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class TrangChu_BP_AnNinh : Form
    {
        public TrangChu_BP_AnNinh()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrangChu_BP_AnNinh_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
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

        private void bãiĐổXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiDoXe_AnNinh baiDoXe_Anninh = new BaiDoXe_AnNinh();
            this.Hide();
            baiDoXe_Anninh.Show();
        }

        private void yêuCầuTừCEOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuCEO_CacBP dSYeuCauTuCEO_CacBP = new DSYeuCauTuCEO_CacBP();
            this.Hide();
            dSYeuCauTuCEO_CacBP.Show();
        }

        private void yêuCầuTừKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuHCNS_CacBP dSYeuCauTuHCNS_CacBP = new DSYeuCauTuHCNS_CacBP();
            this.Hide();
            dSYeuCauTuHCNS_CacBP.Show();
        }

        private void phátTriểnDịchVụMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cưDânRavàoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuDanRaVao_AnNinh cuDanRaVao_AnNinh = new CuDanRaVao_AnNinh();
            this.Hide();
            cuDanRaVao_AnNinh.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
