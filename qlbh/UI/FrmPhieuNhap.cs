using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace qlbh.UI
{
    public partial class FrmPhieuNhap : Form
    {
        SQLConnection kn = new SQLConnection();
        public FrmPhieuNhap()
        {
            InitializeComponent();
            txtBox_MaPN.Text = SQLConnection.CreateUniqueID("ma_pn", DateTime.Now);
            dgv_phieunhap.Rows.Add();

            //cbo_manv.DropDown += new EventHandler(new FrmHoaDonBan().cbo_manv_DropDown);
            //cbo_NCC.DropDown += new EventHandler(new FrmHoaDonBan().cbbID_TT_DropDown);
            //txtBox_Soluong.Leave += new EventHandler(new FrmHoaDonBan().txtSoLuong_Leave);
        }
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            txtBox_Soluong.Enabled = false;

            txtBox_MaPN.ReadOnly = true;
            txtBox_TenNV.ReadOnly = true;
            txtBox_TenNCC.ReadOnly = true;
            txtBox_Tensp.ReadOnly = true;
            txtBox_Gianhap.ReadOnly = true;
            txtBox_Thanhtien.ReadOnly = true;
            txtBox_Tongtien.ReadOnly = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Check thông tin sản phẩm
            if (String.IsNullOrEmpty(cbo_masp.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_masp.Focus();
                return;
            }

            btn_Luu.Enabled = true;

            int lastRow = dgv_phieunhap.Rows.Count - 1;

            dgv_phieunhap.Rows[lastRow].Cells[0].Value = cbo_masp.Text;
            dgv_phieunhap.Rows[lastRow].Cells[1].Value = txtBox_Soluong.Text;
            dgv_phieunhap.Rows[lastRow].Cells[2].Value = txtBox_Gianhap.Text;
            dgv_phieunhap.Rows[lastRow].Cells[3].Value = txtBox_Thanhtien.Text;

            dgv_phieunhap.Rows.Add();

            //new FrmHoaDonBan().calculateTongTien(txtBox_Tongtien, dgv_phieunhap);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //Check mã hóa đơn
            if (!String.IsNullOrEmpty(SQLConnection.GetFieldValues("SELECT ma_pn FROM phieunhap WHERE ma_pn = '" + txtBox_MaPN.Text + "'")))
            {
                MessageBox.Show("Phiếu nhập " + txtBox_MaPN.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin nhân viên
            if (String.IsNullOrEmpty(cbo_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Đồng ý lưu hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                //Phiếu nhập
                try
                {
                    cmd.CommandText = @"INSERT INTO phieunhap(ma_pn, ngay_nhap, trang_thai, tong_tien, ma_ncc, ma_nv, ghi_chu) 
                                            VALUES(@ma_pn, @ngay_nhap, @trang_thai, @tong_tien, @ma_ncc, @ma_nv, @ghi_chu)";
                    cmd.Parameters.AddWithValue("@ma_pn", txtBox_MaPN.Text);
                    cmd.Parameters.AddWithValue("@ngay_nhap", date_nhap.Value.Date);
                    cmd.Parameters.AddWithValue("@trang_thai", txtBox_Trangthai.Text == "" ? "Chưa thanh toán" : "Đã thanh toán");
                    cmd.Parameters.AddWithValue("@tong_tien", Convert.ToDouble(txtBox_Tongtien.Text));
                    cmd.Parameters.AddWithValue("@ma_ncc", cbo_NCC.Text);
                    cmd.Parameters.AddWithValue("@ma_nv", cbo_manv.Text);
                    cmd.Parameters.AddWithValue("@ghi_chu", txt_Ghichu.Text);

                    SQLConnection.ExecuteCommand(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Chi tiết hóa đơn
                try
                {
                    for (int i = 0; i < dgv_phieunhap.Rows.Count - 1; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"INSERT INTO chitietphieunhap(ma_ctpn, so_luong, thanh_tien, ma_pn, ma_sp) 
                                            VALUES(@ma_ctpn, @so_luong, @thanh_tien, @ma_pn, @ma_sp)";
                        cmd.Parameters.AddWithValue("@ma_ctpn", "No" + i + "." + txtBox_MaPN.Text);
                        cmd.Parameters.AddWithValue("@so_luong", Convert.ToInt32(dgv_phieunhap.Rows[i].Cells[1].Value.ToString()));
                        cmd.Parameters.AddWithValue("@thanh_tien", Convert.ToDouble(dgv_phieunhap.Rows[i].Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ma_sp", dgv_phieunhap.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@ma_pn", txtBox_MaPN.Text);

                        SQLConnection.ExecuteCommand(cmd);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_phieunhap.SelectedRows)
            {
                dgv_phieunhap.Rows.RemoveAt(row.Index);
            }

            //new FrmHoaDonBan().calculateTongTien(txtBox_Tongtien, dgv_phieunhap);
        }

        private void Reload()
        {
            date_nhap.Value = DateTime.Now;
            cbo_manv.SelectedIndex = -1;
            cbo_NCC.SelectedIndex = -1;
            cbo_masp.SelectedIndex = -1;
            txtBox_Soluong.Text = "0";
            dgv_phieunhap.Rows.Clear();
            dgv_phieunhap.Rows.Add();
            dgv_phieunhap.Refresh();
            txtBox_Tongtien.Text = "0.00";
            txtBox_Ghichu.Text = "";
            btn_Luu.Enabled = false;
        }

        private void date_nhap_ValueChanged(object sender, EventArgs e)
        {
            txtBox_MaPN.Text = SQLConnection.CreateUniqueID("ma_pn", date_nhap.Value);
        }

        private void cbo_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_TenNV.Text = SQLConnection.GetFieldValues("SELECT ten_nv FROM nhanvien WHERE ma_nv = '" + cbo_manv.Text + "'");
        }

        private void cbo_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_TenNCC.Text = SQLConnection.GetFieldValues("SELECT ten_ncc FROM nhacungcap WHERE ma_ncc = '" + cbo_NCC.Text + "'");
        }

        private void cbo_masp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(cbo_NCC.Text))
            {
                txtBox_Soluong.Enabled = false;
            }
            else
            {
                txtBox_Soluong.Enabled = true;
            }

            txt_Tensp.Text = SQLConnection.GetFieldValues("SELECT ten_san_pham FROM sanpham WHERE ma_sp = N'" + cbo_masp.Text + "'");
            double db = Double.TryParse(SQLConnection.GetFieldValues(@"SELECT don_gia_ban FROM sanpham WHERE ma_sp = N'" + cbo_masp.Text + "'"), out db) ? db : 0;
            txtBox_Gianhap.Text = String.Format("{0:n}", db);
        }

        private void cbo_masp_DropDown(object sender, EventArgs e)
        {
            cbo_masp.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_sp FROM sanpham");
            cbo_masp.ValueMember = "ma_sp";
            cbo_masp.SelectedIndex = -1;
            txtBox_Gianhap.Text = "";
        }

        private void txtBox_Thanhtien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Tính thành tiền
                double thanhTien = Convert.ToDouble(txtBox_Gianhap.Text) * Convert.ToInt16(txtBox_Soluong.Text);
                txtBox_Thanhtien.Text = String.Format("{0:n}", thanhTien);
            }
            catch (Exception ex)
            {
                txtBox_Thanhtien.Text = "0.00";
            }
        }
    }
}
