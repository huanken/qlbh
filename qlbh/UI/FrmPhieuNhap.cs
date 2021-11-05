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
            txtBox_MaPN.Text = SQLConnection.CreateUniqueID("PN", DateTime.Now);
           // dgv_phieunhap.Rows.Add();

            //cbo_manv.DropDown += new EventHandler(new FrmHoaDonBan().cbomanv_DropDown);
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
            txtBox_congtienhang.ReadOnly = true;
            txtBox_CK.ReadOnly = true;
        }
        private void date_nhap_ValueChanged(object sender, EventArgs e)
        {
            txtBox_MaPN.Text = SQLConnection.CreateUniqueID("PN", date_nhap.Value);
        }

        private void cbo_manv_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo_manv = sender as ComboBox;

            cbo_manv.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_nv FROM nhanvien");
            cbo_manv.ValueMember = "ma_nv";
            cbo_manv.SelectedIndex = -1;
        }

        private void cbo_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_TenNV.Text = SQLConnection.GetFieldValues("SELECT ten_nv FROM nhanvien WHERE ma_nv = '" + cbo_manv.Text + "'");
        }

        private void cbo_NCC_DropDown(object sender, EventArgs e)
        {
            cbo_NCC.DisplayMember = "Nhà cung cấp";
            cbo_NCC.ValueMember = "Sản phẩm";
            cbo_NCC.SelectedIndex = -1;
            // cbomasp.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_sp FROM sanpham") ;
            cbo_NCC.DataSource = SQLConnection.ExecuteDataTable("SELECT cast(ma_ncc as int) as [Nhà cung cấp] FROM nhacungcap order by [Nhà cung cấp]");
            
        }

        private void cbo_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_TenNCC.Text = SQLConnection.GetFieldValues("SELECT ten_ncc FROM nhacungcap WHERE ma_ncc = '" + cbo_NCC.Text + "'");
        }
        private void cbo_masp_DropDown(object sender, EventArgs e)
        {
            cbo_masp.DisplayMember = "Sản phẩm";
            cbo_masp.ValueMember = "Sản phẩm";
            cbo_masp.SelectedIndex = -1;
            // cbomasp.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_sp FROM sanpham") ;
            cbo_masp.DataSource = SQLConnection.ExecuteDataTable("SELECT cast(ma_sp as int) as [Sản phẩm] FROM sanpham order by [Sản phẩm]");
            txtBox_Gianhap.Text = "";
        }
        private void cbo_masp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbo_masp.Text))
            {
                txtBox_Soluong.Enabled = false;
            }
            else
            {
                txtBox_Soluong.Enabled = true;
            }
            
            txtBox_Tensp.Text = SQLConnection.GetFieldValues("SELECT ten_san_pham FROM sanpham WHERE ma_sp = N'" + cbo_masp.Text + "'");
            double db = Double.TryParse(SQLConnection.GetFieldValues(@"SELECT don_gia_ban FROM sanpham WHERE ma_sp = N'" + cbo_masp.Text + "'"), out db) ? db : 0;
            txtBox_Gianhap.Text = String.Format("{0:n}", db);
        }

        private void txtBox_Gianhap_Soluong_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }
        internal void calculatetongtien(TextBox a, DataGridView dgv)
        {
            double tongtien = 0;

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                tongtien += Convert.ToDouble(dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value);
            }

            txtBox_congtienhang.Text = String.Format("{0:n}", tongtien);
            txtBox_CK.Text = String.Format("{0:n}", tongtien * 0.15);
            txtBox_Tongtien.Text = String.Format("{0:n}", tongtien - tongtien * 0.15);
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

            dgv_phieunhap.Rows.Add();

            dgv_phieunhap.Rows[lastRow].Cells[0].Value = cbo_masp.Text;
            dgv_phieunhap.Rows[lastRow].Cells[1].Value = txtBox_Tensp.Text;
            dgv_phieunhap.Rows[lastRow].Cells[2].Value = txtBox_Soluong.Text;
            dgv_phieunhap.Rows[lastRow].Cells[3].Value = txtBox_Gianhap.Text;
            dgv_phieunhap.Rows[lastRow].Cells[4].Value = txtBox_Thanhtien.Text;
            calculatetongtien(txtBox_Tongtien, dgv_phieunhap);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //Check mã phiếu nhập
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

            DialogResult result = MessageBox.Show("Đồng ý lưu phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                //Phiếu nhập
                try
                {
                    cmd.CommandText = @"INSERT INTO phieunhap(ma_pn, ngay_nhap, trang_thai, tong_tien, ma_ncc, ma_nv) 
                                            VALUES(@ma_pn, @ngay_nhap, @trang_thai, @tong_tien, @ma_ncc, @ma_nv)";
                    cmd.Parameters.AddWithValue("@ma_pn", txtBox_MaPN.Text);
                    cmd.Parameters.AddWithValue("@ngay_nhap", date_nhap.Value);
                    cmd.Parameters.AddWithValue("@trang_thai", txtBox_Trangthai.Text == "" ? "Chưa thanh toán" : "Đã thanh toán");
                    cmd.Parameters.AddWithValue("@tong_tien", Convert.ToDouble(txtBox_congtienhang.Text));
                    cmd.Parameters.AddWithValue("@ma_ncc", cbo_NCC.Text);
                    cmd.Parameters.AddWithValue("@ma_nv", cbo_manv.Text);
                    

                    SQLConnection.ExecuteCommand(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Chi tiết phiếu nhập
                try
                {
                    for (int i = 0; i < dgv_phieunhap.Rows.Count - 1; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"INSERT INTO chitietphieunhap (ma_ctpn, so_luong, thanh_tien, ghi_chu, ma_pn, ma_sp) 
                                            VALUES(@ma_ctpn, @so_luong, @thanh_tien, @ghi_chu, @ma_pn, @ma_sp)";
                        cmd.Parameters.AddWithValue("@ma_ctpn", "CTPN" + i + txtBox_MaPN.Text);
                        cmd.Parameters.AddWithValue("@so_luong", Convert.ToInt32(dgv_phieunhap.Rows[i].Cells[2].Value.ToString()));
                        cmd.Parameters.AddWithValue("@thanh_tien", Convert.ToDouble(dgv_phieunhap.Rows[i].Cells[4].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ghi_chu", txtBox_Ghichu.Text == "" ?"Nhận trực tiếp":"Chuyển khoản"); 
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

            calculatetongtien(txtBox_Tongtien, dgv_phieunhap);
        }
        private void Reload()
        {
            date_nhap.Value = DateTime.Now;
            cbo_manv.SelectedIndex = -1;
            cbo_NCC.SelectedIndex = -1;
            cbo_masp.SelectedIndex = -1;
            txtBox_Soluong.Text = "0";
            txtBox_CK.Text = "";
            txtBox_congtienhang.Text = "";
            dgv_phieunhap.Rows.Clear();
            //dgv_phieunhap.Rows.Add();

            dgv_phieunhap.Refresh();
            txtBox_Tongtien.Text = "0.00";
            txtBox_Ghichu.Text = "";
            btn_Luu.Enabled = false;
        }

    }
}
