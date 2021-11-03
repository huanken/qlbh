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
using System.IO;
using System.Drawing.Imaging;

namespace qlbh.UI
{
    public partial class FrmSanPham : Form
    {

        SQLConnection kn = new SQLConnection();

        public FrmSanPham()
        {
            InitializeComponent();
        }
        public void BANG_DM()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from dmsanpham order by ma_dm_sp");
            cbo_dm.DataSource = dta;
            cbo_dm.DisplayMember = "ma_dm_sp";
            cbo_dm.ValueMember = "ma_dm_sp";
        }
        public void BANG_SANPHAM()
        {
            dgv_sanpham.DataSource = SQLConnection.ExecuteDataTable(@"SELECT
                                                                 ma_sp AS [Mã sản phẩm],
                                                                 ten_san_pham AS [Tên sản phẩm],
                                                                 don_gia_ban AS [Đơn giá],  
                                                                 hinhanh AS [Source],
                                                                 don_vi_tinh AS [Đơn vị tính],
                                                                 ma_dm_sp AS [Mã danh mục SP]
                                                                 FROM sanpham order by cast( ma_sp as int) ");
            HIENTHI_DULIEU();
        }
        public void HIENTHI_DULIEU()
        {
            txtBox_masp.DataBindings.Clear();
            txtBox_masp.DataBindings.Add("Text", dgv_sanpham.DataSource, "Mã sản phẩm");
            txtBox_tensp.DataBindings.Clear();
            txtBox_tensp.DataBindings.Add("Text", dgv_sanpham.DataSource, "Tên sản phẩm");
            txtBox_giasp.DataBindings.Clear();
            txtBox_giasp.DataBindings.Add("Text", dgv_sanpham.DataSource, "Đơn giá");
            txtImagepath.DataBindings.Clear();
            txtImagepath.DataBindings.Add("Text", dgv_sanpham.DataSource, "Source");
            txtBox_dvt.DataBindings.Clear();
            txtBox_dvt.DataBindings.Add("Text", dgv_sanpham.DataSource, "Đơn vị tính");
            cbo_dm.DataBindings.Clear();
            cbo_dm.DataBindings.Add("Text", dgv_sanpham.DataSource, "Mã danh mục SP");
            pic_B1.DataBindings.Clear();
            this.pic_B1.WaitOnLoad = false;
            this.pic_B1.DataBindings.Add(new System.Windows.Forms.Binding(
                "ImageLocation", dgv_sanpham.DataSource , "Source", true));
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            txtBox_masp.Text = "";
            txtBox_tensp.Text = "";
            txtBox_giasp.Text = "";
            txtBox_dvt.Text = "";
            cbo_dm.Text = "";
            txtImagepath.Text = "";
            txtBox_masp.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            SQLConnection.Ketnoi_DuLieu();
            String StrKtra = "Select ma_sp from sanpham where ma_sp = '" + txtBox_masp.Text + "'";
            SqlCommand cmd = new SqlCommand(StrKtra, SQLConnection.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã Sản Phẩm này đã tồn tại, Nhập lại mã khác", "thông báo");
                txtBox_masp.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                DialogResult TBchen;
                TBchen = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (TBchen == DialogResult.Yes)
                {
                    String sql_luu = "insert into sanpham values ('" + txtBox_masp.Text + "',N'" + txtBox_tensp.Text + "','" + txtBox_giasp.Text + "','" + txtImagepath.Text + "','" + txtBox_dvt.Text + "','" + cbo_dm.Text + "'"+")";
                    kn.Thucthi(sql_luu);
                    BANG_SANPHAM();
                }

            }
            
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string sql_sua = "update sanpham set ten_san_pham = N'" + txtBox_tensp.Text + "', don_gia_ban = '" + txtBox_giasp.Text + "',don_vi_tinh = '" + txtBox_dvt.Text +"', ma_dm_sp = '" + cbo_dm.Text + "',  hinhanh='" + txtImagepath.Text + "' where ma_sp ='" + txtBox_masp.Text + "'";
            kn.Thucthi(sql_sua); 
            BANG_SANPHAM();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "delete sanpham where ma_sp = '" + txtBox_masp.Text + "'";
                kn.Thucthi(sql_xoa);
                BANG_SANPHAM();
            }
          
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            BANG_DM();
            BANG_SANPHAM();
            btn_Luu.Enabled = false;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (openFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {

                        string fileName = openFile.FileName;
                        txtImagepath.Text = openFile.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("Kích thước file quá lớn !");
                        }
                        else
                            pic_B1.Load(fileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           HIENTHI_DULIEU();
        }
    }
}

