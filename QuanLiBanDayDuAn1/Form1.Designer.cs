namespace QuanLiBanDayDuAn1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnDangnhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangnhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(lblMatKhau);
            groupBox1.Controls.Add(lblTaiKhoan);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(213, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(264, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 35);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(83, 219);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(102, 35);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(110, 156);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(290, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(110, 91);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(290, 27);
            txtTaiKhoan.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(25, 163);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(77, 20);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaiKhoan.ForeColor = Color.Black;
            lblTaiKhoan.Location = new Point(25, 91);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(78, 20);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(138, 23);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 526);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnThoat;
        private Button btnDangnhap;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
    }
}
