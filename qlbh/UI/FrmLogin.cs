using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

       // SQLConnection cnn = new SQLConnection();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            if (String.IsNullOrEmpty(txtTaiKhoan.Texts))
            {
                MessageBox.Show("Vui lòng nhập tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtMatKhau.Texts))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SQLConnection.HuyKetNoi();
            SQLConnection.Ketnoi_DuLieu();
            string DN = txtTaiKhoan.Texts;
            string MK = txtMatKhau.Texts;
            string sql_login = "SELECT tai_khoan,mat_khau FROM LOGIN WHERE tai_khoan='" + DN + "' AND mat_khau='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, SQLConnection.cnn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                Form main = new FrmTrangChu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            DangNhap();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }

        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

    }
}
