namespace Mau02
{
    public class NhanVien
    {
        public String MANV;
        public String MACV;
        public String name;
        public String sdt;
        public String email;
        public String chucVu;
        public int salary;
        public String loaiNV;
        public String userID;
        public String maBP;
        public String boPhan;
        public String mk;

        public NhanVien(String MANV, String MACV, String name, String sdt, String email, String chucVu, int salary, String loaiNV, String userID, String maBP, String boPhan, String mk)
        {
            this.MANV = MANV;
            this.MACV = MACV;
            this.name = name;
            this.sdt = sdt;
            this.email = email;
            this.chucVu = chucVu;
            this.salary = salary;
            this.loaiNV = loaiNV;
            this.userID = userID;
            this.maBP = maBP;
            this.boPhan = boPhan;
            this.mk = mk;
        }

    }
}