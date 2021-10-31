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
        }

        SQLConnection kn = new SQLConnection();

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbomanv_DropDown(object sender, EventArgs e)
        {

        }
    }
}
