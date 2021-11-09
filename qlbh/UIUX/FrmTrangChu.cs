using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using WMPLib;
namespace qlbh.UI
{
    public partial class FrmTrangChu : Form
    {
        private bool EsColapse;
        private bool EsColapse2;
        private bool EsColapse3;
        public FrmTrangChu()
        {
            InitializeComponent();
            colapse.Start();
            colapse2.Start();
            colapse3.Start();
            Form f = new FrmHome();
            AddForm(f);
            if (FrmLogin.quyentruycap == 1)
            {
                btnTaiKhoan.Visible = true;
            } else
            {
                btnTaiKhoan.Hide();
            }
        }
        private void colapse3_Tick(object sender, EventArgs e)
        {
            if (EsColapse3)
            {
                panel4.Height += 10;

                if (panel4.Size == panel4.MaximumSize)
                {
                    colapse3.Stop();
                    EsColapse3 = false;
                }
            }
            else
            {
                panel4.Height -= 10;
                if (panel4.Size == panel4.MinimumSize)
                {
                    colapse3.Stop();
                    EsColapse3 = true;
                }
            }
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
            thongbao = MessageBox.Show("Bạn có muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                Form form = new FrmLogin();
                this.Hide();
                this.Close();
                form.Show();
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

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static int sttbaihat = 0;
        public static String strbaihat1 = "https://nhacpro.me/stream/wk7v.mp3";
        public static String strbaihat2 = "https://nhacpro.me/stream/1zhc.mp3";
        public static String strbaihat3 = "https://nhacpro.me/stream/atd.mp3";
        public static String strbaihat4 = "https://nhacpro.me/stream/1aef.mp3";

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sttbaihat = 1;
            wplayer.URL = strbaihat1;
            wplayer.controls.play();
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            if(sttbaihat == 1)
            {
                wplayer.URL = strbaihat2;
                wplayer.controls.play();
                sttbaihat++;
            } else if (sttbaihat == 2)
            {
                wplayer.URL = strbaihat3;
                wplayer.controls.play();
                sttbaihat++;
            }
            else if (sttbaihat == 3)
            {
                wplayer.URL = strbaihat4;
                wplayer.controls.play();
                sttbaihat++;
            }
            else
            {
                wplayer.URL = strbaihat1;
                wplayer.controls.play();
                sttbaihat = 0;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(this.pictureBox1,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wplayer.playState == WMPPlayState.wmppsStopped)
            {
                rjButton1.PerformClick();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            colapse3.Start();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Form f = new FrmTaiKhoan();
            AddForm(f);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            btnTrangChu.PerformClick();
        }

        private void btnBaoCaoHoaDon_Click(object sender, EventArgs e)
        {
            Form f = new FrmBaoCaoHoaDon();
            AddForm(f);
        }

        private void btnBaoCaoPhieuNhap_Click(object sender, EventArgs e)
        {
            Form f = new FrmBaoCaoPhieuNhap();
            AddForm(f);
        }


    }
}
