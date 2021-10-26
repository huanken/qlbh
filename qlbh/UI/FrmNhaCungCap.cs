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
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }
        SQLConnection kn = new SQLConnection();
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            BangNhacungcap();
            btnLuu.Enabled = false;
        }

        private void BangNhacungcap()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhacungcap");
            dataGridViewncc.DataSource = dta;
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            txtmancc.DataBindings.Clear();
            txtmancc.DataBindings.Add("Text", dataGridViewncc.DataSource, "ma_ncc");
            txttenncc.DataBindings.Clear();
            txttenncc.DataBindings.Add("Text", dataGridViewncc.DataSource, "ten_ncc");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dataGridViewncc.DataSource, "dia_chi");
            txtsodt.DataBindings.Clear();
            txtsodt.DataBindings.Add("Text", dataGridViewncc.DataSource, "so_dt");
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsodt.Text = "";
            txtmancc.Focus();
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strktra = "Select ma_ncc from nhacungcap where ma_ncc='" + txtmancc.Text + "'";
            SqlCommand cmd = new SqlCommand(strktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã Nhà cung cấp này đã tồn tại, Nhập lại mã khác ", "Thông báo");
                txtmancc.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sqlLuu = "Insert Into nhacungcap Values('" + txtmancc.Text + "', '" + txttenncc.Text + "', " + txtdiachi.Text + "','" + txtsodt.Text + " ); ";
                kn.Thucthi(sqlLuu);
                BangNhacungcap();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                string sql_Sua = "Update nhacungcap Set ten_ncc = '" + txttenncc.Text + "', dia_chi = '" + txtdiachi.Text + "', so_dt = '" + txtsodt.Text + "' where ma_ncc = '" + txtmancc.Text + "'";
                kn.Thucthi(sql_Sua);
                BangNhacungcap();
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
