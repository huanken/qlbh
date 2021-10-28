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
            dta = cnn.Lay_DulieuBang("Select * From nhanvien");
            cbb_mnv.DataSource = dta;
            cbb_mnv.DisplayMember = "ma_nv";
            cbb_mnv.ValueMember = "ma_nv";
        }

        private void Bang_Chitietdonban()
        {
            DataTable dta = new DataTable();
            dta = cnn.Lay_DulieuBang("Select * From chitietdonban");
            cbb_mactdb.DataSource = dta;
            cbb_mactdb.DisplayMember = "ma_ctdb";
            cbb_mactdb.ValueMember = "ma_ctdb";
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
            cbb_mnv.DataBindings.Add("Texts",GridView_GiaoHang.DataSource, "ma_nv");

            cbb_mactdb.DataBindings.Clear();
            cbb_mactdb.DataBindings.Add("Texts",GridView_GiaoHang.DataSource, "ma_ctdb");

        }

        private void GridView_GiaoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
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
            SqlCommand cmd = new SqlCommand(StrKtra, cnn.cnn);
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
                string sqlLuu = "Insert Into giaohang Values('" + txt_mavd.Texts.Trim() + "', '" + dp_Time.Value + "', '" + txt_dc.Texts.Trim() + "', '" + txt_sđtkh.Texts.Trim() + "','" + cbb_mnv.Texts.Trim() + "', '" + cbb_mactdb.Texts.Trim() + "' );";
                cnn.Thucthi(sqlLuu);
                bang_giaohang();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update giaohang Set thoi_gian= '" + dp_Time.Value + "' , dia_chi_kh= '" + txt_dc.Texts + "' ,so_dt_kh= '" +txt_sđtkh.Texts + "' , ma_nv= '" + cbb_mnv.Texts + "' , ";
            sqlSua += "ma_ctdb = '" + cbb_mactdb.Texts.Trim() + "'Where ma_van_don = '" + txt_mavd.Texts.Trim() + "';";
            cnn.Thucthi(sqlSua);
            bang_giaohang();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "Delete giaohang Where ma_van_don='" + txt_mavd.Texts.Trim() + "'; ";
            cnn.Thucthi(sqlXoa);
            bang_giaohang();
        }

        private void FrmGiaoHang_Load(object sender, EventArgs e)
        {
            Bang_Nhanvien();
            Bang_Chitietdonban();
            bang_giaohang();
            HienThiDuLieu();
            btn_Luu.Enabled = false;
        }
    }
}
