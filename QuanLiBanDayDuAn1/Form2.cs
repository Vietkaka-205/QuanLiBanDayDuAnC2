using GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanDayDuAn1
{
    public partial class Form2 : Form
    {
        private DuAn1Context Vietdbcontext = new DuAn1Context();
        private DataTable dt = new DataTable();
        private int indexDangChon = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Đặt indexDangChon là chỉ số của hàng được chọn
                indexDangChon = e.RowIndex;

                var dongHienTai = dgvSanPham.Rows[indexDangChon];
                var MaSP = dongHienTai.Cells[0].Value;
                var TenSP = dongHienTai.Cells[1].Value;
                var SoLuong = dongHienTai.Cells[2].Value;
                var ChatLieu = dongHienTai.Cells[3].Value;
                var KichCo = dongHienTai.Cells[4].Value;
                var MauSac = dongHienTai.Cells[5].Value;
                var GiaBan = dongHienTai.Cells[6].Value;

                // Hiển thị thông tin sản phẩm lên các ô nhập liệu
                txtMaSP.Text = MaSP.ToString();
                txtTenSP.Text = TenSP.ToString();
                txtSoLuong.Text = SoLuong.ToString();
                cbbChatLieu.Text = ChatLieu.ToString();
                cbbKichCo.Text = KichCo.ToString();
                cbbMauSac.Text = MauSac.ToString();
                txtGiaBan.Text = GiaBan.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sanpham newSanpham = new Sanpham
            {
                TenSp = txtTenSP.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                ChatLieu = cbbChatLieu.Text,
                KichCo = int.Parse(cbbKichCo.Text),
                MauSac = cbbMauSac.Text,
                GiaBan = decimal.Parse(txtGiaBan.Text),
            };

            Vietdbcontext.Sanphams.Add(newSanpham);
            Vietdbcontext.SaveChanges();

            DataRow dr = dt.NewRow();
            dr["MaSP"] = newSanpham.MaSp; // Đảm bảo MaSp được tự động tạo (auto-increment) trong SQL Server
            dr["TenSp"] = newSanpham.TenSp;
            dr["SoLuong"] = newSanpham.SoLuong;
            dr["ChatLieu"] = newSanpham.ChatLieu;
            dr["KichCo"] = newSanpham.KichCo;
            dr["MauSac"] = newSanpham.MauSac;
            dr["GiaBan"] = newSanpham.GiaBan;
            dt.Rows.Add(dr);

            dgvSanPham.DataSource = dt;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            var SanPham = Vietdbcontext.Sanphams.ToList();
            foreach (var SP in SanPham)
            {
                DataRow dr = dt.NewRow();
                dr["MaSP"] = SP.MaSp;
                dr["TenSP"] = SP.TenSp;
                dr["SoLuong"] = SP.SoLuong;
                dr["ChatLieu"] = SP.ChatLieu;
                dr["KichCo"] = SP.KichCo;
                dr["MauSac"] = SP.MauSac;
                dr["GiaBan"] = SP.GiaBan;
                dr["Anh"] = SP.Anh;
                dt.Rows.Add(dr);
            }
            dgvSanPham.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("MaSP", typeof(int));
            dt.Columns.Add("TenSp", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ChatLieu", typeof(string));
            dt.Columns.Add("KichCo", typeof(int));
            dt.Columns.Add("MauSac", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("Anh", typeof(string));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (indexDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }

            // Lấy mã sản phẩm của sản phẩm được chọn
            int maSanPhamDuocChon = (int)dgvSanPham.Rows[indexDangChon].Cells[0].Value;

            // Tìm sản phẩm trong cơ sở dữ liệu
            var sanPhamCanSua = Vietdbcontext.Sanphams.FirstOrDefault(p => p.MaSp == maSanPhamDuocChon);
            if (sanPhamCanSua != null)
            {
                // Cập nhật các thuộc tính của sản phẩm với giá trị mới từ các trường nhập liệu
                sanPhamCanSua.TenSp = txtTenSP.Text;
                sanPhamCanSua.SoLuong = int.Parse(txtSoLuong.Text);
                sanPhamCanSua.ChatLieu = cbbChatLieu.Text;
                sanPhamCanSua.KichCo = int.Parse(cbbKichCo.Text);
                sanPhamCanSua.MauSac = cbbMauSac.Text;
                sanPhamCanSua.GiaBan = decimal.Parse(txtGiaBan.Text);

                // Lưu các thay đổi vào cơ sở dữ liệu
                Vietdbcontext.SaveChanges();

                // Cập nhật hàng tương ứng trong DataTable
                DataRow dr = dt.Rows[indexDangChon];
                dr["TenSp"] = sanPhamCanSua.TenSp;
                dr["SoLuong"] = sanPhamCanSua.SoLuong;
                dr["ChatLieu"] = sanPhamCanSua.ChatLieu;
                dr["KichCo"] = sanPhamCanSua.KichCo;
                dr["MauSac"] = sanPhamCanSua.MauSac;
                dr["GiaBan"] = sanPhamCanSua.GiaBan;

                // Làm mới DataGridView
                dgvSanPham.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (indexDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }

            // Lấy mã sản phẩm của sản phẩm được chọn
            int maSanPhamDuocChon = (int)dgvSanPham.Rows[indexDangChon].Cells[0].Value;

            // Tìm sản phẩm trong cơ sở dữ liệu
            var sanPhamCanXoa = Vietdbcontext.Sanphams.FirstOrDefault(p => p.MaSp == maSanPhamDuocChon);
            if (sanPhamCanXoa != null)
            {
                // Xóa sản phẩm khỏi cơ sở dữ liệu
                Vietdbcontext.Sanphams.Remove(sanPhamCanXoa);
                Vietdbcontext.SaveChanges();

                // Xóa hàng tương ứng trong DataTable
                dt.Rows.RemoveAt(indexDangChon);

                // Làm mới DataGridView
                dgvSanPham.DataSource = dt;

                // Reset indexDangChon
                indexDangChon = -1;

                // Xóa các trường nhập liệu
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtSoLuong.Clear();
                cbbChatLieu.SelectedIndex = -1;
                cbbKichCo.SelectedIndex = -1;
                cbbMauSac.SelectedIndex = -1;
                txtGiaBan.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần xóa");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            var ketQuaTimKiem = Vietdbcontext.Sanphams
                .Where(sp => sp.TenSp.Contains(tuKhoa) ||
                             sp.ChatLieu.Contains(tuKhoa) ||
                             sp.KichCo.ToString().Contains(tuKhoa) ||
                             sp.MauSac.Contains(tuKhoa))
                .ToList();

            // Xóa các dòng cũ trong DataTable
            dt.Rows.Clear();

            // Thêm các dòng tìm được vào DataTable
            foreach (var SP in ketQuaTimKiem)
            {
                DataRow dr = dt.NewRow();
                dr["MaSP"] = SP.MaSp;
                dr["TenSp"] = SP.TenSp;
                dr["SoLuong"] = SP.SoLuong;
                dr["ChatLieu"] = SP.ChatLieu;
                dr["KichCo"] = SP.KichCo;
                dr["MauSac"] = SP.MauSac;
                dr["GiaBan"] = SP.GiaBan;
                dr["Anh"] = SP.Anh;
                dt.Rows.Add(dr);
            }

            // Làm mới DataGridView
            dgvSanPham.DataSource = dt;
        }
    }
}
