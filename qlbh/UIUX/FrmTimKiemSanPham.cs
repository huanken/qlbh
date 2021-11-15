using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh.UI
{
    public partial class FrmTimKiemSanPham : Form
    {
        public FrmTimKiemSanPham()
        {
            InitializeComponent();
        }

        SQLConnection cnn = new SQLConnection();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            DataTable dta = new DataTable();
            string sqltk;
            if (optMaSP.Checked == true)
            {
                if (txtTimKiem.Texts == "")
                {
                    MessageBox.Show("Hãy nhập giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from SANPHAM where ma_sp like '" + txtTimKiem.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optTenSP.Checked == true)
            {
                if (txtTimKiem.Texts == "")
                {
                    MessageBox.Show("Hãy nhập giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from SANPHAM where ten_san_pham like '%" + txtTimKiem.Texts + "%'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optDanhMuc.Checked == true)
            {
                if (cbbTimKiem.Texts == "")
                {
                    MessageBox.Show("Hãy chọn giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from SANPHAM where ma_dm_sp like '" + cbbTimKiem.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            GridView_SP.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void FrmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            cbbTimKiem.SelectedIndex = -1;
            cbbTimKiem.Texts = "";
            txtTimKiem.Enabled = false;
            cbbTimKiem.Enabled = false;
            string sqltk;
            sqltk = "Select * from dmsanpham order by ma_dm_sp";
            DataTable dta = cnn.Lay_DulieuBang(sqltk);
            cbbTimKiem.DataSource = dta;
            cbbTimKiem.DisplayMember = "ma_dm_sp";
            HIENTHI_DULIEU();
        }

        public void HIENTHI_DULIEU()
        {
            if(GridView_SP.DataSource != null)
            {
                try
                {
                    picSP.DataBindings.Clear();
                    this.picSP.WaitOnLoad = false;
                    this.picSP.DataBindings.Add(new System.Windows.Forms.Binding(
                        "ImageLocation", GridView_SP.DataSource, "hinhanh", true));
                }
                catch (Exception)
                {

                }
            }
        }

        private void optMaSP_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            cbbTimKiem.Enabled = false;
            txtTimKiem.Focus();
            cbbTimKiem.SelectedIndex = -1;
            cbbTimKiem.Texts = "";
        }

        private void optTenSP_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            cbbTimKiem.Enabled = false;
            txtTimKiem.Focus();
            cbbTimKiem.SelectedIndex = -1;
            cbbTimKiem.Texts = "";
        }

        private void optDanhMuc_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = false;
            cbbTimKiem.Enabled = true;
            txtTimKiem.Texts = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Texts = "";
            cbbTimKiem.SelectedIndex = -1;
            cbbTimKiem.Texts = "";
            optMaSP.Checked = false;
            optTenSP.Checked = false;
            optDanhMuc.Checked = false;
            GridView_SP.DataSource = null;
            picSP.ImageLocation = "";
        }
    }
}
