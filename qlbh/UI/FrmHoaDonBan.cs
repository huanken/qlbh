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
    public partial class FrmHoaDonBan : Form
    {
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }
          SQLConnection kn = new SQLConnection();
          private void FrmHoaDonBan_Load(object sender, EventArgs e)
          {
              BangHoadonban();
              BangNhanVien();
              HienThiDuLieu();
              btnLuu.Enabled = false;
          }

          private void BangHoadonban()
          {
              DataTable dta = new DataTable();
              dta = kn.Lay_DulieuBang("Select * From hoadonban");
              dgvhoadonban.DataSource = dta;
              //HienThiDuLieu();
          }
          private void BangNhanVien()
          {
              DataTable dta = new DataTable();
              dta = kn.Lay_DulieuBang("Select * from nhanvien");
              cbomanv.DataSource = dta;

              cbomanv.DisplayMember = "ma_nv";
              cbomanv.ValueMember = "ma_nv";
          }
          private void HienThiDuLieu()
          {
              txtmahdon.DataBindings.Clear();
              txtmahdon.DataBindings.Add("Texts", dgvhoadonban.DataSource, "ma_hd_ban");
              dateNgayBan.DataBindings.Clear();
              dateNgayBan.DataBindings.Add("Value", dtg_hoadonban.DataSource, "ngay_ban");
              txttongtien.DataBindings.Clear();
              txttongtien.DataBindings.Add("Texts", dtg_hoadonban.DataSource, "tong_tien");
              cbomanv.DataBindings.Clear();
              cbomanv.DataBindings.Add("Texts", dtg_hoadonban.DataSource, "ma_nv");

          }

          private void btnTaomoi_Click(object sender, EventArgs e)
          {
                txtmahdon.Texts = "";
                txttongtien.Texts = "";
                cbomanv.Texts = "";
                btnLuu.Enabled = true;
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
              string strktra = "Select ma_hd_ban from hoadonban where ma_hd_ban='" + txtmahdon.Texts + "'";
              SqlCommand cmd = new SqlCommand(strktra, kn.cnn);
              SqlDataReader doc_d1 = cmd.ExecuteReader();
              if (doc_d1.Read() == true)
              {
                  MessageBox.Show("Mã Hoá đơn này đã tồn tại, Nhập lại mã khác ", "Thông báo");
                  txtmahdon.Focus();
                  doc_d1.Close();
                  doc_d1.Dispose();
              }
              else
              {
                  string sqlLuu = "Insert Into hoadonban Values('" + txtmahdon.Texts + "', " + " CONVERT(datetime,'"+ dateNgayBan.Value + "',103)" + ", '" + txttongtien.Texts + "', '" + cbomanv.Texts + "' ); ";
                  kn.Thucthi(sqlLuu);
                  BangHoadonban();
              }
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
              string sql_Sua = "Update hoadonban Set tong_tien = '" + txttongtien.Texts +  "', ma_nv = '" + cbomanv.Texts + "', ngay_ban =" + "CONVERT(datetime,'" + dateNgayBan.Value + "',103)" + " where ma_hd_ban = '" +txtmahdon.Texts + "'";
              kn.Thucthi(sql_Sua);
             BangHoadonban();
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
              string sqlXoa = "Delete hoadonban Where ma_hd_ban='" + txtmahdon.Texts + "'; ";
              kn.Thucthi(sqlXoa);
              BangHoadonban();
          }

          private void btnThoat_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          private void dtg_hoadonban_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              HienThiDuLieu();
          }
      }
    }
}
