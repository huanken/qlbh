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
    public partial class FrmSanPham : Form
    {

        SQLConnection kn = new SQLConnection();

        public FrmSanPham()
        {
            InitializeComponent();
        }
            public void BANG_SANPHAM()
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_DulieuBang("select * from sanpham");
                dgv_sanpham.DataSource = dta;
                HIENTHI_DULIEU();
            }
            public void HIENTHI_DULIEU()
            {
                txtBox_masp.DataBindings.Clear();
                txtBox_masp.DataBindings.Add("Text", dgv_sanpham.DataSource, "ma_sp");
                txtBox_tensp.DataBindings.Clear();
                txtBox_tensp.DataBindings.Add("Text", dgv_sanpham.DataSource, "ten_san_pham");
                txtBox_giasp.DataBindings.Clear();
                txtBox_giasp.DataBindings.Add("Text", dgv_sanpham.DataSource, "don_gia_ban");
                pic_B1.DataBindings.Clear();
                pic_B1.DataBindings.Add("Text", dgv_sanpham.DataSource, "hinhanh");
                txtBox_dvt.DataBindings.Clear();
                txtBox_dvt.DataBindings.Add("Text", dgv_sanpham.DataSource, "don_vi_tinh");
                txtBox_dm.DataBindings.Clear();
                txtBox_dm.DataBindings.Add("Text", dgv_sanpham.DataSource, "ma_dm_sp");

            }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            txtBox_masp.Text = "";
            txtBox_tensp.Text = "";
            txtBox_giasp.Text = "";
            txtBox_dvt.Text = "";
            txtBox_dm.Text = "";
            pic_B1.ImageLocation = "https://th.bing.com/th/id/R.97404a574384998a803cba453d618030?rik=YZW3N0XO6ERMBQ&riu=http%3a%2f%2fwww.actnss.org%2fassets%2fHomemade-burger-healthy-chicken-Cropped.jpg&ehk=3Knvtrlu%2b4%2fUDuzUSHz0Wd691cGW8zUV2%2b3MS7FopMQ%3d&risl=&pid=ImgRaw&r=0";
            txtBox_masp.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            String sql_luu = "insert into sanpham values ('" + txtBox_masp.Text + "','" + txtBox_tensp.Text + "','" + txtBox_giasp.Text + "','" + pic_B1.ImageLocation + "','" + txtBox_dvt.Text + "','" + txtBox_dm.Text + "')";
            kn.Thucthi(sql_luu);
            BANG_SANPHAM();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string sql_sua = "update sanpham set ten_san_pham = '" + txtBox_tensp.Text + "', don_gia_ban = '" + txtBox_giasp.Text + "','" + txtBox_dm.Text + "' where ma_sp = '" + txt_masp.Text + "'";
            kn.Thucthi(sql_sua);
            BANG_SANPHAM();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "delete sanpham where ma_sp = '" + txtBox_masp.Text + "'";
            kn.Thucthi(sql_xoa);
            BANG_SANPHAM();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            BANG_SANPHAM();
            btn_Luu.Enabled = false;
        }
    }
}

