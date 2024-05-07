using GiaoDien;
using N16_GiaoDien;

namespace Mau02
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

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

            if (tendangnhap == "bpan")
            {
                TrangChu_BP_AnNinh trangChu_BP_AnNinh = new TrangChu_BP_AnNinh();
                this.Hide();
                trangChu_BP_AnNinh.Show();
            } else if (tendangnhap == "bphcns")
            {
                TrangChu_BP_HCNS trangChu_BP_HCNS = new TrangChu_BP_HCNS();
                this.Hide();
                trangChu_BP_HCNS.Show();
            }
            else if (tendangnhap == "bpktbt")
            {
                TrangChu_BP_KTBT trangChu_BP_KTBT = new TrangChu_BP_KTBT();
                this.Hide();
                trangChu_BP_KTBT.Show();
            }
            else if (tendangnhap == "bptckt")
            {
                TrangChu_BP_TCKT trangChu_BP_TCKT = new TrangChu_BP_TCKT();
                this.Hide();
                trangChu_BP_TCKT.Show();
            }
            else if (tendangnhap == "bpvs")
            {
                TrangChu_BP_VeSinh trangChu_BP_VeSinh = new TrangChu_BP_VeSinh();
                this.Hide();
                trangChu_BP_VeSinh.Show();
            }
            else if (tendangnhap == "bpxd")
            {
                TrangChu_BP_XayDung trangChu_BP_XayDung = new TrangChu_BP_XayDung();
                this.Hide();
                trangChu_BP_XayDung.Show();
            }
            else if (tendangnhap == "ceocql")
            {
                TrangChu_CEO_CQL trangChu_CEO = new TrangChu_CEO_CQL();
                this.Hide();
                trangChu_CEO.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập/ Mật khẩu sai! Vui lòng nhập lại!");
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
    }
}
