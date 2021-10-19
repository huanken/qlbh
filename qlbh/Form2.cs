using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh
{
    public partial class Form2 : Form
    {
        SQLConnection kn = new SQLConnection();
        public Form2()
        {
            InitializeComponent();
        }
        private void BANG_nhanvien()//tạo thủ tục để gọi nhiều lần
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from nhanvien");
            dataGridView1.DataSource = dta;
            //HIENTHI_DULIEU();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BANG_nhanvien();
        }
    }
}
