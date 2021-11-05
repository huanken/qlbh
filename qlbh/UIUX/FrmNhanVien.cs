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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        SQLConnection cnn = new SQLConnection();

        private void bang_Nhanvien()
        {
            GridView_NV.DataSource = SQLConnection.ExecuteDataTable(@"SELECT
                                                                                ma_nv AS [Mã nhân viên],
                                                                                ten_nv AS [Tên nhân viên],
                                                                                so_dt AS [Số ĐT],
                                                                                dia_chi AS [Địa chỉ],
                                                                                email AS [Email],
                                                                                gioitinh AS [Giới tính]
                                                                                    FROM nhanvien");
        }

        private void HienThiDuLieu()
        {
            txt_MNV.DataBindings.Clear();
            txt_MNV.DataBindings.Add("Texts", GridView_NV.DataSource, "Mã nhân viên");

            txt_TenNV.DataBindings.Clear();
            txt_TenNV.DataBindings.Add("Texts", GridView_NV.DataSource, "Tên nhân viên");

            txt_SĐT.DataBindings.Clear();
            txt_SĐT.DataBindings.Add("Texts", GridView_NV.DataSource, "Số ĐT");

            txt_ĐChi.DataBindings.Clear();
            txt_ĐChi.DataBindings.Add("Texts", GridView_NV.DataSource, "Địa chỉ");

            txt_Email.DataBindings.Clear();
            txt_Email.DataBindings.Add("Texts", GridView_NV.DataSource, "Email");

            txt_giơitinh.DataBindings.Clear();
            txt_giơitinh.DataBindings.Add("Texts", GridView_NV.DataSource, "Giới tính");

            
        }

        private void GridView_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            bang_Nhanvien();
            HienThiDuLieu();
            btn_Save.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_MNV.Texts = "";
            txt_TenNV.Texts = "";
            txt_SĐT.Texts = "";
            txt_ĐChi.Texts = "";
            txt_Email.Texts = "";
            txt_giơitinh.Texts = "";
            btn_Save.Enabled = true;
        }

        

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update nhanvien Set ten_nv= N'" + txt_TenNV.Texts + "' , so_dt= '" + txt_SĐT.Texts + "' ,dia_chi= N'" + txt_ĐChi.Texts + "' , email= '" + txt_Email.Texts + "' , ";
            sqlSua += " gioitinh = '" + txt_giơitinh.Texts.Trim() + "'Where ma_nv = '" + txt_MNV.Texts.Trim() + "';";
            cnn.Thucthi(sqlSua);
            bang_Nhanvien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                string sqlXoa = "Delete nhanvien Where ma_nv='" + txt_MNV.Texts.Trim() + "'; ";
                cnn.Thucthi(sqlXoa);
                bang_Nhanvien();
            }  
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SQLConnection.Ketnoi_DuLieu();
            String StrKtra = "Select ma_nv from nhanvien where ma_nv = '" + txt_MNV.Texts + "'";
            SqlCommand cmd = new SqlCommand(StrKtra, SQLConnection.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã Nhân Viên này đã tồn tại, Nhập lại mã khác", "thông báo");
                txt_MNV.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                string sqlLuu = "Insert Into nhanvien Values('" + txt_MNV.Texts.Trim() + "',  N'" + txt_TenNV.Texts.Trim() + "', '" + txt_giơitinh.Texts.Trim() + "','" +txt_SĐT.Texts.Trim() + "', N'" + txt_ĐChi.Texts.Trim() + "', '"+ txt_Email.Texts.Trim() + "' );";
                cnn.Thucthi(sqlLuu);
                bang_Nhanvien();
            }
        }
    }
}
