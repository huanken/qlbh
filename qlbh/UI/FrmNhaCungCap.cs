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
            rjTextBox1.DataBindings.Clear();
            rjTextBox1.DataBindings.Add("Text", dataGridViewncc.DataSource, "ma_ncc");
            rjTextBox2.DataBindings.Clear();
            rjTextBox2.DataBindings.Add("Text", dataGridViewncc.DataSource, "ten_ncc");
            rjTextBox3.DataBindings.Clear();
            rjTextBox3.DataBindings.Add("Text", dataGridViewncc.DataSource, "dia_chi");
            rjTextBox4.DataBindings.Clear();
            rjTextBox4.DataBindings.Add("Text", dataGridViewncc.DataSource, "so_dt");
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjTextBox1.Text = "";
            rjTextBox2.Text = "";
            rjTextBox3.Text = "";
            rjTextBox4.Text = "";
            rjTextBox1.Focus();
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strktra = "Select ma_ncc from nhacungcap where ma_ncc='" + rjTextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(strktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã Nhà cung cấp này đã tồn tại, Nhập lại mã khác ", "Thông báo");
                rjTextBox1.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sqlLuu = "Insert Into nhacungcap Values('" + rjTextBox1.Text + "', '" + rjTextBox2.Text + "', " + rjTextBox3.Text + "','" + rjTextBox4.Text + " ); ";
                kn.Thucthi(sqlLuu);
                BangNhacungcap();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                string sql_Sua = "Update nhacungcap Set ten_ncc = '" + rjTextBox2.Text + "', dia_chi = '" + rjTextBox3.Text + "', so_dt = '" + rjTextBox4.Text + "' where ma_ncc = '" + rjTextBox1.Text + "'";
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
