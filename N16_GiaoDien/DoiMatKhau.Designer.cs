namespace N16_GiaoDien
{
    partial class DoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(1, 42, 74);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(8, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 341);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cập nhật";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(1, 73, 124);
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 42, 74);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(492, 286);
            button5.Name = "button5";
            button5.Size = new Size(106, 30);
            button5.TabIndex = 36;
            button5.Text = "LƯU";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 10.2F);
            textBox4.Location = new Point(200, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(398, 30);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.Location = new Point(200, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(398, 30);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(200, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 30);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 197);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 0;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 115);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 33);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu cũ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(1, 42, 74);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(240, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 70);
            panel2.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(339, 43);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu mới";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(1, 42, 74);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DoiMatKhau";
            Text = "Đổi mật khẩu";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button5;
    }
}