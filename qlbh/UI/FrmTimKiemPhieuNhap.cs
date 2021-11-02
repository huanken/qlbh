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
    public partial class FrmTimKiemPhieuNhap : Form
    {
        public FrmTimKiemPhieuNhap()
        {
            InitializeComponent();
        }

        SQLConnection cnn = new SQLConnection();
        private void FrmTimKiemPhieuNhap_Load(object sender, EventArgs e)
        {
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Texts = "";
            dateNgayNhap2.Enabled = false;
            dateNgayNhap.Enabled = false;
            cbbNCC.Enabled = false;
            txtMaPN.Enabled = false;
            string sqltk;
            sqltk = "Select * from nhacungcap order by ma_ncc";
            DataTable dta = cnn.Lay_DulieuBang(sqltk);
            cbbNCC.DataSource = dta;
            cbbNCC.DisplayMember = "ma_ncc";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (optMaPN.Checked == true)
            {
                if (txtMaPN.Texts == "")
                {
                    MessageBox.Show("Hãy nhập giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from PHIEUNHAP where ma_pn like '" + txtMaPN.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optNgayNhap.Checked == true)
            {
                sqltk = "Select * from PHIEUNHAP where ngay_nhap >= '" + dateNgayNhap.Value.Date + "' and ngay_nhap <= '" + dateNgayNhap2.Value.Date + "';";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            if (optNCC.Checked == true)
            {
                if (cbbNCC.Texts == "")
                {
                    MessageBox.Show("Hãy chọn giá trị cần tìm kiếm!");
                    return;
                }
                sqltk = "Select * from PHIEUNHAP where ma_ncc like '" + cbbNCC.Texts + "'";
                dta = cnn.Lay_DulieuBang(sqltk);
            }
            GridView_PN.DataSource = dta;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPN.Texts = "";
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Texts = "";
            optMaPN.Checked = false;
            optNgayNhap.Checked = false;
            optNCC.Checked = false;
            GridView_PN.DataSource = null;
        }

        private void optMaPN_CheckedChanged(object sender, EventArgs e)
        {
            txtMaPN.Enabled = true;
            dateNgayNhap.Enabled = false;
            dateNgayNhap2.Enabled = false;
            cbbNCC.Enabled = false;
            txtMaPN.Focus();
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Texts = "";
        }

        private void optNgayNhap_CheckedChanged(object sender, EventArgs e)
        {
            txtMaPN.Texts = "";
            txtMaPN.Enabled = false;
            dateNgayNhap.Enabled = true;
            dateNgayNhap2.Enabled = true;
            cbbNCC.Enabled = false;
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Texts = "";
        }

        private void optNCC_CheckedChanged(object sender, EventArgs e)
        {
            txtMaPN.Texts = "";
            txtMaPN.Enabled = false;
            dateNgayNhap2.Enabled = false;
            dateNgayNhap.Enabled = false;
            cbbNCC.Enabled = true;
            cbbNCC.SelectedIndex = -1;
            cbbNCC.Texts = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in GridView_PN.SelectedRows)
                    {
                        string sqlXoa = "Delete phieunhap Where ma_pn='" + row.Cells[0].Value.ToString() + "'; ";
                        cnn.Thucthi(sqlXoa);
                        GridView_PN.Rows.RemoveAt(row.Index);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void displayCTN()
        {
            DataGridViewRow r = GridView_PN.SelectedRows[0];

            GridView_PN.DataSource = SQLConnection.ExecuteDataTable(@"SELECT
                                                                            ma_ctpn AS [Mã chi tiết PN],
                                                                            ma_sp AS [Mã sản phẩm],
                                                                            so_luong AS [Số lượng],
                                                                            thanh_tien AS [Thành tiền]
                                                                                FROM chitietphieunhap
                                                                                WHERE ma_pn = '" + r.Cells[0].Value.ToString() + "'");
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (GridView_PN.SelectedRows.Count == 1)
            {
                displayCTN();
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 phiếu nhập cần xem chi tiết!");
                return;
            }
        }

        private void cbbNCC_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           txtNhaCungCap.Texts = SQLConnection.GetFieldValues("SELECT ten_ncc FROM nhacungcap WHERE ma_ncc =" + (cbbNCC.SelectedIndex + 1) + "");
        }
    }
}
