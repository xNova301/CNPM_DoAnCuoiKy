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
    public partial class TrangChu_BP_HCNS : Form
    {
        public TrangChu_BP_HCNS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void yêuCầuTừCEOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuCEO_HCNS dSYeuCauTuCEO_HCNS = new DSYeuCauTuCEO_HCNS();
            this.Hide();
            dSYeuCauTuCEO_HCNS.Show();
        }

        private void yêuCầuTừKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSYeuCauTuKH_HCNS dSYeuCauTuKH_HCNS = new DSYeuCauTuKH_HCNS();
            this.Hide();
            dSYeuCauTuKH_HCNS.Show();
        }

        private void phátTriểnDịchVụMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PtrienDichVu_HCNS ptrienDichVu_HCNS = new PtrienDichVu_HCNS();
            this.Hide();
            ptrienDichVu_HCNS.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu_HCNS baoCaoDoanhThu_HCNS = new BaoCaoDoanhThu_HCNS();
            this.Hide();
            baoCaoDoanhThu_HCNS.Show();
        }
    }
}
