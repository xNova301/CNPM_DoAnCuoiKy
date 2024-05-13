using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Mau02;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace N16_GiaoDien
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int newPwd;

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string emailAddress = textBox1.Text;
            // Kiểm tra xem email có hợp lệ không (đây là một kiểm tra đơn giản)
            if (IsValidEmail(emailAddress))
            {
                // Gửi email hướng dẫn khôi phục mật khẩu
                try
                {
                    newPwd = random.Next(100000, 1000000);

                    var fromEmail = new MailAddress("hoangducminh0902@gmail.com");

                    var toEmail = new MailAddress(textBox1.ToString());

                    const string fromEmailPass = "cspuihzdgqhwqptq";

                    const string title = "Mật khẩu mới của phần mềm QuanTriCuDan";

                    string content = newPwd.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromEmail.Address, fromEmailPass),
                        Timeout = 200000
                    };

                    using (var message = new MailMessage(fromEmail, toEmail)
                    {
                        Subject = title,
                        Body = content
                    })
                    {
                        smtp.Send(message);
                    }
                    String connectString = @"Data Source=HoangMinh\SQLEXPRESS;Initial Catalog=QUAN_LY_CONG_VIEC;Integrated Security=True";

                    String newMK = newPwd.ToString();

                    String query = $"UPDATE NHAN_VIEN SET MK = '{newMK}' WHERE EMAIL = '{emailAddress}'";

                    using (SqlConnection conn = new SqlConnection(connectString))
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Đã gửi thành công mật khẩu mới qua email");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /*private void SendPasswordResetEmail(string toEmail)
        {
            // Thông tin tài khoản email gửi
            string fromEmail = textBox1.Text;
            string password = "yourEmailPassword";

            // Tạo đối tượng SmtpClient
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(fromEmail, password);

            // Tạo đối tượng MailMessage
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromEmail);
            message.To.Add(new MailAddress(toEmail));
            message.Subject = "Hướng dẫn khôi phục mật khẩu";
            message.Body = "Vui lòng thực hiện các bước để khôi phục mật khẩu của bạn...";

            // Gửi email
            try
            {
                client.Send(message);
                MessageBox.Show("Đã gửi hướng dẫn khôi phục mật khẩu đến địa chỉ email của bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }*/
    }
}
