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
        private bool EsColapse2;
        public FrmTrangChu()
        {
            InitializeComponent();
            colapse.Start();
            colapse2.Start();
            Form f = new FrmHome();
            AddForm(f);
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
        private void colapse2_Tick(object sender, EventArgs e)
        {
            if (EsColapse2)
            {
                panel3.Height += 10;

                if (panel3.Size == panel3.MaximumSize)
                {
                    colapse2.Stop();
                    EsColapse2 = false;
                }
            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    colapse2.Stop();
                    EsColapse2 = true;
                }
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            colapse.Start();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            colapse2.Start();
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
            Form f = new FrmHoaDonBan();
            AddForm(f);
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
            Form f = new FrmHome();
            AddForm(f);
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            Form f = new FrmGiaoHang();
            AddForm(f);
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            Form f = new FrmTimKiemSanPham();
            AddForm(f);
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            Form f = new FrmTimKiemHoaDon();
            AddForm(f);
        }

        private void btnTimKiemPhieuNhap_Click(object sender, EventArgs e)
        {
            Form f = new FrmTimKiemPhieuNhap();
            AddForm(f);
        }

    }
}
