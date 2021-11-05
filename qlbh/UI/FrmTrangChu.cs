using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
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

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static int sttbaihat = 0;
        public static String strbaihat1 = "https://vnno-vn-5-tf-mp3-s1-zmp3.zadn.vn/b0c1b3a0aae143bf1af0/8702956433249017962?authen=exp=1636250325~acl=/b0c1b3a0aae143bf1af0/*~hmac=c2ea454be467d4015a8f537cb88839b6&fs=MTYzNjA3NzUyNTI3OXx3ZWJWNnwwfDExNy41LjE1My4zNA";
        public static String strbaihat2 = "https://vnno-vn-6-tf-mp3-s1-zmp3.zadn.vn/94a965343c72d52c8c63/3337086739829767214?authen=exp=1636251187~acl=/94a965343c72d52c8c63/*~hmac=5f73e62bce3553238dfc48a92ffa6b21&fs=MTYzNjA3ODM4NzgwMnx3ZWJWNnwwfDExNy41LjE1My4zNA";
        public static String strbaihat3 = "https://vnno-vn-6-tf-mp3-s1-zmp3.zadn.vn/6a7f4f5c9c1875462c09/6915996016203233196?authen=exp=1636250707~acl=/6a7f4f5c9c1875462c09/*~hmac=cc5d2bf93f3dac2aad3c588559956f9e&fs=MTYzNjA3NzkwNzI0MXx3ZWJWNnwxMDIwMjU3MTmUsICzfDExNy4zLjIzOC4yMDQ";
        public static String strbaihat4 = "https://vnno-vn-6-tf-mp3-s1-zmp3.zadn.vn/c2c5eac02a87c3d99a96/6463151866451065802?authen=exp=1636250360~acl=/c2c5eac02a87c3d99a96/*~hmac=799189203dfcc8e6a043570271b911b1&fs=MTYzNjA3NzU2MDgxOHx3ZWJWNnwxMDAyNDIyMjY2fDI3LjmUsICyLjI5LjIzMQ";
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
    }
}
