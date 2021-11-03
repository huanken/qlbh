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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Dessert.Image;
            pictureBox_food1.Load("m_th_t_b_.jpg");
            pictureBox_food2.Load("khoai_vi_n_ph_mai_1.png");
            pictureBox_food3.Load("g_xi_n_que_3_1.jpg");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Hamburger.Image;
            pictureBox_food1.Load("teriyaki-burger_4.png");
            pictureBox_food2.Load("burger_bulgogi_4.png");
            pictureBox_food3.Load("burger_fish_5.png");
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Rice.Image;
            pictureBox_food1.Load("c_m_g_n_ng_g_c_t_.png");
            pictureBox_food2.Load("z2054357287951_e157e816f01218490778bac846704d4d.jpg");
            pictureBox_food3.Load("soup_g__1.jpg");
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_drink.Image;
            pictureBox_food1.Load("milo.png");
            pictureBox_food2.Load("nestea.png");
            pictureBox_food3.Load("orangejuice_4.png");
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_chiken.Image;
            pictureBox_food1.Load("z1921445934290_1a09a8072d9fa62189c5cdea0b83d2ff.jpg");
            pictureBox_food2.Load("g_s_t_ph_mai_3_6_9_mi_ng.jpg");
            pictureBox_food3.Load("g_g_c_t_.png");
        }

        private void pictureBox_food3_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food3.Image;
        }

        private void pictureBox_food2_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food2.Image;
        }

        private void pictureBox_food1_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_food1.Image;
        }

        private void pictureBox_Dessert_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Dessert.Image;
            pictureBox_food1.Load("m_th_t_b_.jpg");
            pictureBox_food2.Load("khoai_vi_n_ph_mai_1.png");
            pictureBox_food3.Load("g_xi_n_que_3_1.jpg");
        }

        private void pictureBox_Hamburger_Click(object sender, EventArgs e)
        {
            Pbox_food.Image = pictureBox_Hamburger.Image;
            pictureBox_food1.Load("teriyaki-burger_4.png");
            pictureBox_food2.Load("burger_bulgogi_4.png");
            pictureBox_food3.Load("burger_fish_5.png");
        }

        private void pictureBox_Rice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_drink_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_chiken_Click(object sender, EventArgs e)
        {

        }
    }
}
