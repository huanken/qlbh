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
    public partial class FrmTimKiemHoaDon : Form
    {
        public FrmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        SQLConnection cnn = new SQLConnection();
        private void FrmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            cbbManv.SelectedIndex = -1;
            cbbManv.Texts = "";
            dateNgayban.Enabled = false;
            dateNgayBan2.Enabled = false;
            cbbManv.Enabled = false;
            txtMahdban.Enabled = false;
            string sqltk;
            sqltk = "Select * from nhanvien order by ma_nv";
            DataTable dta = cnn.Lay_DulieuBang(sqltk);
            cbbManv.DataSource = dta;
            cbbManv.DisplayMember = "ma_nv";
        }

        private void optMahdban_CheckedChanged(object sender, EventArgs e)
        {
            txtMahdban.Enabled = true;
            dateNgayban.Enabled = false;
            dateNgayBan2.Enabled = false;
            cbbManv.Enabled = false;
            txtMahdban.Focus();
            cbbManv.SelectedIndex = -1;
            cbbManv.Texts = "";
        }

        private void optNgayNhap_CheckedChanged(object sender, EventArgs e)
        {
            txtMahdban.Texts = "";
            txtMahdban.Enabled = false;
            dateNgayban.Enabled = true;
            dateNgayBan2.Enabled = true;
            cbbManv.Enabled = false;
            cbbManv.SelectedIndex = -1;
            cbbManv.Texts = "";
        }

        private void optManv_CheckedChanged(object sender, EventArgs e)
        {
            txtMahdban.Texts = "";
            txtMahdban.Enabled = false;
            dateNgayban.Enabled = false;
            dateNgayBan2.Enabled = false;
            cbbManv.Enabled = true;
            cbbManv.SelectedIndex = -1;
            cbbManv.Texts = "";
        }

        private void cbbManv_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennv.Texts = SQLConnection.GetFieldValues("SELECT ten_nv FROM nhanvien WHERE ma_nv =" + (cbbManv.SelectedIndex + 1) + "");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (optMahdban.Checked == true)
            {
                if (txtMahdban.Texts == "")
                {
                    MessageBox.Show("Hãy nhập giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from hoadonban where ma_hd_ban like '" + txtMahdban.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optNgayban.Checked == true)
            {
                sqltk = "Select * from hoadonban where ngay_ban >= '" + dateNgayban.Value.Date + "' and ngay_ban <= '" + dateNgayBan2.Value.Date + "';";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optManv.Checked == true)
            {
                if (cbbManv.Texts == "")
                {
                    MessageBox.Show("Hãy chọn giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from hoadonban where ma_nv like '" + cbbManv.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            GridView_HDBH.DataSource = dta;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMahdban.Texts = "";
            cbbManv.SelectedIndex = -1;
            cbbManv.Texts = "";
            optManv.Checked = false;
            optNgayban.Checked = false;
            optManv.Checked = false;
            GridView_HDBH.DataSource = null;
        }

        private void displayCTHDBH()
        {
            DataGridViewRow r = GridView_HDBH.SelectedRows[0];

            GridView_HDBH.DataSource = SQLConnection.ExecuteDataTable(@"SELECT
                                                                            ma_ctdb AS [Mã ctiết đbán],
                                                                            so_luong AS [Số lượng],
                                                                            thanh_tien AS [Thành tiền],
                                                                            ma_hd_ban AS [Mã hóa đơn bán]
                                                                                FROM chitietdonban
                                                                                WHERE ma_hd_ban = '" + r.Cells[0].Value.ToString() + "'");
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (GridView_HDBH.SelectedRows.Count == 1)
            {
                displayCTHDBH();
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 hoá đơn cần xem chi tiết!");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in GridView_HDBH.SelectedRows)
                    {
                        string sqlXoa = "Delete hoadonban Where ma_hd_ban='" + row.Cells[0].Value.ToString() + "'; ";
                        cnn.Thucthi(sqlXoa);
                        GridView_HDBH.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
