namespace QuanLiBanDayDuAn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Form2 qlbg = new Form2();
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123456")
                {
                    qlbg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai Khoan cua ban khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Moi ban nhap thong tin", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
