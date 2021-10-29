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
        }
        public void BANG_NCC()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select ma_ncc from nhacungcap");
            cbo_NCC.DataSource = dta;
            cbo_NCC.DisplayMember = "ma_ncc";
            cbo_NCC.ValueMember = "ma_ncc";
        }
        public void BANG_NHANVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select ma_nv from nhanvien");
            cbo_manv.DataSource = dta;
            cbo_manv.DisplayMember = "ma_nv";
            cbo_manv.ValueMember = "ma_nv";
        }
        public void BANG_PHIEUNHAP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from phieunhap");
            dgv_phieunhap.DataSource = dta;
            HIENTHI_DULIEU();
        }
        public void HIENTHI_DULIEU()
        {
            txtBox_MaPN.DataBindings.Clear();
            txtBox_MaPN.DataBindings.Add("Texts", dgv_phieunhap.DataSource, "ma_pn");

            date_nhap.DataBindings.Clear();
            date_nhap.DataBindings.Add("Value", dgv_phieunhap.DataSource, "ngay_nhap");

            cbo_manv.DataBindings.Clear();
            cbo_manv.DataBindings.Add("Texts", dgv_phieunhap.DataSource, "ma_nv");

            txtBox_Trangthai.DataBindings.Clear();
            txtBox_Trangthai.DataBindings.Add("Text", dgv_phieunhap.DataSource, "trang_thai");

            txtBox_Tongtien.DataBindings.Clear();
            txtBox_Tongtien.DataBindings.Add("Text", dgv_phieunhap.DataSource, "tong_tien");

            cbo_NCC.DataBindings.Clear();
            cbo_NCC.DataBindings.Add("Texts", dgv_phieunhap.DataSource, "ma_ncc");

        }
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            BANG_NHANVIEN();
            BANG_NCC();
            BANG_PHIEUNHAP();
            btn_Luu.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txtBox_MaPN.Texts = "";
            date_nhap.Value = DateTime.Today;
            txtBox_Trangthai.Texts = "";
            txtBox_Tongtien.Texts = "";
            txtBox_MaPN.Focus();
            btn_Luu.Enabled = true;
            BANG_PHIEUNHAP();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            String StrKtra = "Select ma_pn from phieunhap where ma_pn = '" + txtBox_MaPN.Texts + "'";
            SqlCommand cmd = new SqlCommand(StrKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã phiếu nhập này đã tồn tại, Nhập lại mã khác", "thông báo");
                txtBox_MaPN.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                String sql_luu = "insert into phieunhap values('" + txtBox_MaPN.Texts.Trim() + "','" + date_nhap.Value + "','" + cbo_manv.Texts.Trim() + "','" + txtBox_Trangthai.Texts + "',";
                sql_luu += "'" + txtBox_Tongtien.Texts.Trim() + "','" + cbo_NCC.Texts.Trim() + "');";
                kn.Thucthi(sql_luu);
                BANG_PHIEUNHAP();
            }
            

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sql_sua = "update phieunhap set ngay_nhap = '" + date_nhap.Value + "', ma_nv = '" + cbo_manv.Texts.Trim() + "', trang_thai = '" + txtBox_Trangthai.Texts + "',";
                                       sql_sua += "tong_tien = '" + txtBox_Tongtien.Texts + "', ma_ncc = '" + cbo_NCC.Texts.Trim() + "' where ma_pn = '" + txtBox_MaPN.Texts.Trim() + "'";
            kn.Thucthi(sql_sua);
            BANG_PHIEUNHAP();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "delete phieunhap where ma_pn = '" + txtBox_MaPN.Texts + "'";
            kn.Thucthi(sql_xoa);
            BANG_PHIEUNHAP();
        }
    }
}
