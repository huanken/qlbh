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
            txtmahdon.Text = SQLConnection.CreateUniqueID("HDB", DateTime.Now);
            //dgvhoadonban.Rows.Add();
        }
        SQLConnection kn = new SQLConnection();


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {

        }

        private void datengayban_ValueChanged(object sender, EventArgs e)
        {
            txtmahdon.Text = SQLConnection.CreateUniqueID("HDB", datengayban.Value);
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttennv.Text = SQLConnection.GetFieldValues("SELECT ten_nv FROM nhanvien WHERE ma_nv = '" + cbomanv.Text + "'");
        }

        private void cbomanv_DropDown(object sender, EventArgs e)
        {
            ComboBox cbomanv = sender as ComboBox;

            cbomanv.DataSource = SQLConnection.ExecuteDataTable("SELECT ma_nv FROM nhanvien");
           cbomanv.ValueMember = "ma_nv";
            cbomanv.SelectedIndex = -1;
        }


    }
}
