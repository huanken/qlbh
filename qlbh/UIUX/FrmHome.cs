using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace qlbh.UI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            StartTimer();
        }

        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
        }

        private void pictureBox_Dessert_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Dessert.Image;
            pictureBox_food1.Load("m_th_t_b_.jpg");
            pictureBox_food2.Load("khoai_vi_n_ph_mai_1.png");
            pictureBox_food3.Load("g_xi_n_que_3_1.jpg");
            panel1.Show();
            panel3.Hide();
        }

        private void pictureBox_Hamburger_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Hamburger.Image;
            pictureBox_food1.Load("teriyaki-burger_4.png");
            pictureBox_food2.Load("burger_bulgogi_4.png");
            pictureBox_food3.Load("burger_fish_5.png");
            panel1.Show();
            panel3.Hide();
        }

        private void pictureBox_Rice_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Rice.Image;
            pictureBox_food1.Load("c_m_g_n_ng_g_c_t_.png");
            pictureBox_food2.Load("z2054357287951_e157e816f01218490778bac846704d4d.jpg");
            pictureBox_food3.Load("soup_g__1.jpg");
            panel1.Show();
            panel3.Hide();
        }

        private void pictureBox_drink_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_drink.Image;
            pictureBox_food1.Load("milo.png");
            pictureBox_food2.Load("nestea.png");
            pictureBox_food3.Load("orangejuice_4.png");
            panel1.Show();
            panel3.Hide();
        }

        private void pictureBox_chiken_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_chiken.Image;
            pictureBox_food1.Load("z1921445934290_1a09a8072d9fa62189c5cdea0b83d2ff.jpg");
            pictureBox_food2.Load("g_s_t_ph_mai_3_6_9_mi_ng.jpg");
            pictureBox_food3.Load("g_g_c_t_.png");
            panel1.Show();
            panel3.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                btnHide.Text = "Show";
                panel1.Hide();
                panel3.Show();
            } else
            {
                btnHide.Text = "Hide";
                panel1.Show();
                panel3.Hide();
            }
        }

        private void pictureBox_food3_Click_1(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food3.Image;
        }

        private void pictureBox_food2_Click_1(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food2.Image;
        }

        private void pictureBox_food1_Click_1(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food1.Image;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            btnHide.PerformClick();
            picBannerChicken.Visible = false;
            picBannerGiaoHang.Visible = false;
            timer1.Start();
            label17.Text = "Welcome " + FrmLogin.tk + " !";
            try
            {
                long doanhthu = Convert.ToInt64(SQLConnection.GetFieldValues("select SUM(tong_tien) from hoadonban where CONVERT(VARCHAR(10), ngay_ban, 103)= '" + DateTime.Today.ToString("dd/MM/yyyy") + "' "));
                label13.Text = String.Format("{0:n0}", doanhthu) + " VNĐ";
            } catch (Exception ex)
            {
                label13.Text = "0 VNĐ";
            }
            try
            {
                long tongchi = Convert.ToInt64(SQLConnection.GetFieldValues("select SUM(tong_tien) from phieunhap where CONVERT(VARCHAR(10), ngay_nhap, 103)= '" + DateTime.Today.ToString("dd/MM/yyyy") + "' "));
                label15.Text = String.Format("{0:n0}", tongchi) + " VNĐ";
            }
            catch (Exception ex)
            {
                label15.Text = "0 VNĐ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBannerBurger.Visible)
            {
                opt1.Checked = true;
                opt2.Checked = false;
                opt3.Checked = false;
                picBannerBurger.Visible = false;
                picBannerChicken.Visible = true;
            }
            else if (picBannerChicken.Visible)
            {
                opt1.Checked = false;
                opt2.Checked = true;
                opt3.Checked = false;
                picBannerChicken.Visible = false;
                picBannerGiaoHang.Visible = true;
            }
            else 
            {
                opt1.Checked = false;
                opt2.Checked = false;
                opt3.Checked = true;
                picBannerGiaoHang.Visible = false;
                picBannerBurger.Visible = true;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            
            if (picBannerBurger.Visible)
            {
                opt1.Checked = false;
                opt2.Checked = true;
                opt3.Checked = false;
                picBannerBurger.Visible = false;
                picBannerGiaoHang.Visible = true;
            }
            else if (picBannerGiaoHang.Visible)
            {
                opt1.Checked = true;
                opt2.Checked = false;
                opt3.Checked = false;
                picBannerGiaoHang.Visible = false;
                picBannerChicken.Visible = true;
            }
            else
            {
                opt1.Checked = false;
                opt2.Checked = false;
                opt3.Checked = true;
                picBannerChicken.Visible = false;
                picBannerBurger.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (picBannerBurger.Visible)
            {
                opt1.Checked = true;
                opt2.Checked = false;
                opt3.Checked = false;
                picBannerBurger.Visible = false;
                picBannerChicken.Visible = true;
            }
            else if (picBannerChicken.Visible)
            {
                opt1.Checked = false;
                opt2.Checked = true;
                opt3.Checked = false;
                picBannerChicken.Visible = false;
                picBannerGiaoHang.Visible = true;
            }
            else
            {
                opt1.Checked = false;
                opt2.Checked = false;
                opt3.Checked = true;
                picBannerGiaoHang.Visible = false;
                picBannerBurger.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                //  this.Close();
                Application.Exit();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/neu.dhktqd/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ktqdNEU");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.neu.edu.vn/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCISxQDUvx_vQIZOsOWSZKKg");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.neu.edu.vn/");
        }
    }
}
