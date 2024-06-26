﻿using Mau02;
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
    public partial class TrangChu_BP_XayDung : Form
    {
        NhanVien nhanVien;
        public TrangChu_BP_XayDung(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TTinChiTietNV ttchitietNV = new TTinChiTietNV(nhanVien);
            this.Hide();
            ttchitietNV.Show();
        }
    }
}
