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
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        SQLConnection kn = new SQLConnection();
        private void BangTaiKhoan()
        {
            dataGridView_TaiKhoan.DataSource = SQLConnection.ExecuteDataTable(@"SELECT
                                                                                tai_khoan AS [Tài khoản],
                                                                                mat_khau AS [Mật Khẩu],
                                                                                quyen_truy_cap AS [Quyền Truy Cập]
                                                                                    FROM login");
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Texts", dataGridView_TaiKhoan.DataSource, "Tài khoản");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Texts", dataGridView_TaiKhoan.DataSource, "Mật Khẩu");
            txtQuyen.DataBindings.Clear();
            txtQuyen.DataBindings.Add("Texts", dataGridView_TaiKhoan.DataSource, "Quyền truy cập");
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            BangTaiKhoan();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Texts = "";
            txtMatKhau.Texts = "";
            txtQuyen.Texts = "";
            txtTaiKhoan.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLConnection.Ketnoi_DuLieu();
            string strktra = "Select tai_khoan from login where tai_khoan='" + txtTaiKhoan.Texts + "'";
            SqlCommand cmd = new SqlCommand(strktra, SQLConnection.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Tài khoản này đã tồn tại, nhập lại tài khoản khác ", "Thông báo");
                txtTaiKhoan.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sqlLuu = "Insert Into login Values('" + txtTaiKhoan.Texts + "', N'" + txtMatKhau.Texts + "', N'" + txtQuyen.Texts +"' ); ";
                kn.Thucthi(sqlLuu);
                BangTaiKhoan();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update login Set mat_khau = N'" + txtMatKhau.Texts + "', quyen_truy_cap = N'" + txtQuyen.Texts + "' where tai_khoan = '" + txtTaiKhoan.Texts + "'";
            kn.Thucthi(sql_Sua);
            BangTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                string sqlXoa = "Delete login Where tai_khoan='" + txtTaiKhoan.Texts + "'; ";
                kn.Thucthi(sqlXoa);
                BangTaiKhoan();
            }
        }
    }
}
