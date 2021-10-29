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
    public partial class FrmTrangChu : Form
    {
        private bool EsColapse;
        public FrmTrangChu()
        {
            InitializeComponent();
            colapse.Start();
        }

        private void colapse_Tick_1(object sender, EventArgs e)
        {
            if (EsColapse)
            {
                panel1.Height += 10;
            
                if (panel1.Size == panel1.MaximumSize)
                {
                    colapse.Stop();
                    EsColapse = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    colapse.Stop();
                    EsColapse = true;
                }
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            colapse.Start();
        }

        private void AddForm(Form f)
        {
            this.panel2.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Form f = new FrmSanPham();
            AddForm(f);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Form f = new FrmNhaCungCap();
            AddForm(f);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form f = new FrmNhanVien();
            AddForm(f);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            Form f = new FrmPhieuNhap();
            AddForm(f);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                //  this.Close();
                Application.Exit();
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            Form f = new FrmGiaoHang();
            AddForm(f);
        }
    }
}
