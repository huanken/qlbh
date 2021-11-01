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
    public partial class FrmGiaoHang : Form
    {
        public FrmGiaoHang()
        {
            InitializeComponent();
        }

        SQLConnection cnn = new SQLConnection();

        private void bang_giaohang()
        {
            DataTable dta = new DataTable();
            dta = cnn.Lay_DulieuBang("Select * From giaohang");
            GridView_GiaoHang.DataSource = dta;
        }

        private void Bang_Nhanvien()
        {
            DataTable dta = new DataTable();
            dta = cnn.Lay_DulieuBang("Select * From nhanvien order by ma_nv");
            cbb_mnv.DataSource = dta;
            cbb_mnv.DisplayMember = "ma_nv";
            cbb_mnv.ValueMember = "ma_nv";
        }

        private void Bang_Chitietdonban()
        {
            DataTable dta = new DataTable();
            dta = cnn.Lay_DulieuBang("Select * From hoadonban order by ngay_ban desc");
            cbb_mactdb.DataSource = dta;
            cbb_mactdb.DisplayMember = "ma_hd_ban";
            cbb_mactdb.ValueMember = "ma_hd_ban";
            cbb_mactdb.SelectedItem = 1;
        }

        private void HienThiDuLieu()
        {
            txt_mavd.DataBindings.Clear();
            txt_mavd.DataBindings.Add("Texts", GridView_GiaoHang.DataSource, "ma_van_don");

            dp_Time.DataBindings.Clear();
            dp_Time.DataBindings.Add("Value", GridView_GiaoHang.DataSource, "thoi_gian");

            txt_dc.DataBindings.Clear();
            txt_dc.DataBindings.Add("Texts", GridView_GiaoHang.DataSource, "dia_chi_kh");

            txt_sđtkh.DataBindings.Clear();
            txt_sđtkh.DataBindings.Add("Texts",GridView_GiaoHang.DataSource, "so_dt_kh");

            cbb_mnv.DataBindings.Clear();
            cbb_mnv.DataBindings.Add("Text",GridView_GiaoHang.DataSource, "ma_nv");

            cbb_mactdb.DataBindings.Clear();
            cbb_mactdb.DataBindings.Add("Text",GridView_GiaoHang.DataSource, "ma_hd_ban");

            cbo_TrangThai.DataBindings.Clear();
            cbo_TrangThai.DataBindings.Add("Texts", GridView_GiaoHang.DataSource, "trang_thai");

            this.btnTrangThai.DataBindings.Clear();
            this.btnTrangThai.DataBindings.Add("Text", GridView_GiaoHang.DataSource, "trang_thai");
            
        }

        private void GridView_GiaoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
            
        }

        private void ColorChange()
        {
            btnTrangThai.Invalidate();
            if (this.btnTrangThai.Text.Trim().Equals("Giao Thành Công"))
            {
                this.btnTrangThai.BackColor = Color.PaleGreen;
                return;
            }
            else if (this.btnTrangThai.Text.Trim().Equals("Giao Thất Bại") == true)
            {
                this.btnTrangThai.BackColor = Color.Red;
                return;
            }
            else if (this.btnTrangThai.Text.Trim().Equals("Đang Giao") == true)
            {
                this.btnTrangThai.BackColor = Color.Gold;
                return;
            }
            else
            {
                this.btnTrangThai.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            txt_mavd.Texts = "";
            txt_dc.Texts = "";
            txt_sđtkh.Texts = "";     
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            String StrKtra = "Select ma_van_don from giaohang where ma_van_don = '" + txt_mavd.Texts + "'";
            SqlCommand cmd = new SqlCommand(StrKtra, SQLConnection.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã Giao Hàng này đã tồn tại, Nhập lại mã khác", "thông báo");
                txt_mavd.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                string sqlLuu = "Insert Into giaohang(ma_van_don, thoi_gian, dia_chi_kh, so_dt_kh,trang_thai, ma_nv, ma_hd_ban ) Values('" + txt_mavd.Texts.Trim() + "', '" + dp_Time.Value + "', N'" + txt_dc.Texts.Trim() + "', '" + txt_sđtkh.Texts.Trim() + "',N'Nhận Đơn', '" + cbb_mnv.Text.Trim() + "', '" + cbb_mactdb.Text.Trim() + "' );";
                cnn.Thucthi(sqlLuu);
                bang_giaohang();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update giaohang Set thoi_gian= '" + dp_Time.Value + "' , dia_chi_kh= '" + txt_dc.Texts + "' ,so_dt_kh= '" +txt_sđtkh.Texts + "' , ma_nv= '" + cbb_mnv.Text + "' , ";
            sqlSua += "ma_hd_ban = '" + cbb_mactdb.Text.Trim() + "'Where ma_van_don = '" + txt_mavd.Texts.Trim() + "';";
            cnn.Thucthi(sqlSua);
            bang_giaohang();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                string sqlXoa = "Delete giaohang Where ma_van_don='" + txt_mavd.Texts.Trim() + "'; ";
                cnn.Thucthi(sqlXoa);
                bang_giaohang();
            } 
        }

        private void FrmGiaoHang_Load(object sender, EventArgs e)
        {
            Bang_Nhanvien();
            Bang_Chitietdonban();
            bang_giaohang();
            HienThiDuLieu();
            
            btn_Luu.Enabled = false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update giaohang Set trang_thai=N'" + cbo_TrangThai.Texts + "'" + " Where ma_van_don = '" + txt_mavd.Texts.Trim() + "';";
            cnn.Thucthi(sqlSua);
            bang_giaohang();
            HienThiDuLieu();
        }

        private void btnTrangThai_TextChanged(object sender, EventArgs e)
        {
            ColorChange();
            progressTT.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.btnTrangThai.Text.Trim().Equals("Giao Thành Công"))
            {
                if (progressTT.Value < progressTT.Maximum)
                {
                    progressTT.Value += 10;
                }
                progressTT.SliderColor = Color.PaleGreen;
                return;
            }
            else if (this.btnTrangThai.Text.Trim().Equals("Giao Thất Bại"))
            {
                if (progressTT.Value < progressTT.Maximum)
                {
                    progressTT.Value += 10;
                }
                progressTT.SliderColor = Color.Red;
                return;
            }
            else if (this.btnTrangThai.Text.Trim().Equals("Nhận Đơn"))
            {
                progressTT.Value = progressTT.Minimum;
                return;
            }
            else if (this.btnTrangThai.Text.Trim().Equals("Đang Giao"))
            {
                if (progressTT.Value < 50)
                {
                    progressTT.Value += 10;
                }
                progressTT.SliderColor = Color.Gold;
                return;
            }
            else
            {
                progressTT.Value = progressTT.Minimum;
            }
        }
    }
}
