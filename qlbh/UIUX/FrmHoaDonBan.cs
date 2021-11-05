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
            txtmahdon.Text = SQLConnection.CreateUniqueID("HDB", DateTime.Now);
            //dgvhoadonban.Rows.Add();
        }
        SQLConnection kn = new SQLConnection();


        private void btnThoat_Click(object sender, EventArgs e)
        {
           // this.Close();
            Reload();
        }

        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtsoluong.Enabled = false;
            txtgiamgia.Enabled = false;

            txtmahdon.ReadOnly = true;
            txttennv.ReadOnly = true;
            txttensp.ReadOnly = true;
            txtgiaban.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txtcongtienhang.ReadOnly = true;
            txtVAT.ReadOnly = true;
            txttongtien.ReadOnly = true;
        }

        private void datengayban_ValueChanged(object sender, EventArgs e)
        {
            txtmahdon.Text = SQLConnection.CreateUniqueID("HDB", datengayban.Value);
        }

        

        private void cbomanv_DropDown(object sender, EventArgs e)
        {
            ComboBox cbomanv = sender as ComboBox;

            cbomanv.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_nv FROM nhanvien");
           cbomanv.ValueMember = "ma_nv";
            cbomanv.SelectedIndex = -1;
        }

         private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttennv.Text = SQLConnection.GetFieldValues("SELECT ten_nv FROM nhanvien WHERE ma_nv = '" + cbomanv.Text + "'");
        }

         private void cbomasp_DropDown(object sender, EventArgs e)
         {
            cbomasp.DisplayMember = "Sản phẩm";
            cbomasp.ValueMember = "Sản phẩm";
            cbomasp.SelectedIndex = -1;
           // cbomasp.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_sp FROM sanpham") ;
            cbomasp.DataSource = SQLConnection.ExecuteDataTable("SELECT cast(ma_sp as int) as [Sản phẩm] FROM sanpham order by [Sản phẩm]");
            txtgiaban.Text = "";
         }


        private void cbomasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbomasp.Text))
            {
                txtsoluong.Enabled = txtgiamgia.Enabled = false;
            }
            else
            {
                txtsoluong.Enabled = txtgiamgia.Enabled = true;
            }

            txttensp.Text = SQLConnection.GetFieldValues("SELECT ten_san_pham FROM sanpham WHERE ma_sp='" + cbomasp.Text + "'");
            double db = Double.TryParse(SQLConnection.GetFieldValues(@"SELECT don_gia_ban FROM sanpham WHERE ma_sp = N'" + cbomasp.Text + "'"), out db) ? db : 0;
            txtgiaban.Text = String.Format("{0:n}", db);
        }

        

        private void txtgiamgia_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtgia_giamgia_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Tính thành tiền
                double thanhtien = (Convert.ToDouble(txtgiaban.Text) - Convert.ToDouble(txtgiaban.Text) * Convert.ToDouble(txtgiamgia.Text) / 100) * Convert.ToInt16(txtsoluong.Text);
                txtthanhtien.Text = String.Format("{0:n}", thanhtien);
            }
            catch (Exception ex)
            {
                txtthanhtien.Text = "0.00";
            }
        }
      
         internal void calculatetongtien(TextBox a, DataGridView dgv)
         {
             double congtienhang = 0;

             for (int i = 0; i < dgv.Rows.Count - 1; i++)
             {
                 congtienhang += Convert.ToDouble(dgv.Rows[i].Cells[dgv.ColumnCount - 2].Value);
             }

             txtcongtienhang.Text = String.Format("{0:n}", congtienhang);
             txtVAT.Text = String.Format("{0:n}", congtienhang * 0.1);
             txttongtien.Text = String.Format("{0:n}", congtienhang + congtienhang * 0.1);
         }
       


        private void btnThem_Click(object sender, EventArgs e)
        {
            //Check thông tin sản phẩm
            if (String.IsNullOrEmpty(cbomasp.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomasp.Focus();
                return;
            }

            btnLuu.Enabled = true;

            int lastRow = dgvhoadonban.Rows.Count - 1;

            dgvhoadonban.Rows.Add();

            dgvhoadonban.Rows[lastRow].Cells[0].Value = cbomasp.Text;
            dgvhoadonban.Rows[lastRow].Cells[1].Value = txtsoluong.Text;
            dgvhoadonban.Rows[lastRow].Cells[2].Value = txtgiaban.Text;
            dgvhoadonban.Rows[lastRow].Cells[3].Value = txtgiamgia.Text;
            dgvhoadonban.Rows[lastRow].Cells[4].Value = txtthanhtien.Text;
            dgvhoadonban.Rows[lastRow].Cells[5].Value = txtghichu.Text;
            calculatetongtien(txtcongtienhang, dgvhoadonban);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            //Check mã hóa đơn
            if (!String.IsNullOrEmpty(SQLConnection.GetFieldValues("SELECT ma_hd_ban FROM HoaDonBan WHERE ma_hd_ban = '" + txtmahdon.Text + "'")))
            {
                MessageBox.Show("Hóa đơn " + txtmahdon + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin nhân viên
            if (String.IsNullOrEmpty(cbomanv.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

    

            DialogResult result = MessageBox.Show("Đồng ý lưu hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                //Hóa đơn bán
                try
                {
                    cmd.CommandText = @"INSERT INTO hoadonban(ma_hd_ban, ngay_ban,  tong_tien, ma_nv) 
                                            VALUES(@ma_hd_ban, @ngay_ban, @tong_tien, @ma_nv)";
                    cmd.Parameters.AddWithValue("@ma_hd_ban", txtmahdon.Text);
                    cmd.Parameters.AddWithValue("@ngay_ban", datengayban.Value);
                    cmd.Parameters.AddWithValue("@tong_tien", Convert.ToDouble(txtcongtienhang.Text));
                    cmd.Parameters.AddWithValue("@ma_nv", cbomanv.Text);
                    

                    SQLConnection.ExecuteCommand(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Chi tiết đơn bán
                try
                {
                    for (int i = 0; i < dgvhoadonban.Rows.Count - 1; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"INSERT INTO chitietdonban (ma_ctdb, so_luong, giam_gia, thanh_tien, ghi_chu, ma_hd_ban, ma_sp) 
                                            VALUES(@ma_ctdb, @so_luong, @giam_gia, @thanh_tien, @ghi_chu, @ma_hd_ban, @ma_sp)";
                        cmd.Parameters.AddWithValue("@ma_ctdb", "CTHDB" + i + txtmahdon.Text);
                        cmd.Parameters.AddWithValue("@so_luong", Convert.ToInt32(dgvhoadonban.Rows[i].Cells[1].Value.ToString()));
                        cmd.Parameters.AddWithValue("@giam_gia", Convert.ToDouble(dgvhoadonban.Rows[i].Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@thanh_tien", Convert.ToDouble(dgvhoadonban.Rows[i].Cells[4].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ghi_chu", Convert.ToString(dgvhoadonban.Rows[i].Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ma_sp", dgvhoadonban.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@ma_hd_ban", txtmahdon.Text);                
                        SQLConnection.ExecuteCommand(cmd);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void Reload()
        {
            datengayban.Value = DateTime.Now;
            cbomanv.SelectedIndex = -1;
            cbomasp.SelectedIndex = -1;
            txtsoluong.Text = "0";
            txtgiamgia.Text = "0.00";
            dgvhoadonban.Rows.Clear();
            
            dgvhoadonban.Refresh();
            txtcongtienhang.Text = "0.00";
            txtghichu.Text = "";
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvhoadonban.SelectedRows)
            {
                dgvhoadonban.Rows.RemoveAt(row.Index);
            }

            calculatetongtien(txtcongtienhang, dgvhoadonban);
        }
    }

        


} 

