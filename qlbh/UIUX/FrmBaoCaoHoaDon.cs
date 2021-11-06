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
    public partial class FrmBaoCaoHoaDon : Form
    {
        public FrmBaoCaoHoaDon()
        {
            InitializeComponent();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = SQLConnection.ExecuteDataTable("Select * from hoadonban where ngay_ban between CONVERT(datetime,'" + date1.Value.Date.ToString("MM/dd/yyyy") + "')and CONVERT(datetime,'" + date2.Value.Date.ToString("MM/dd/yyyy") + "')");
            rptBaoCaoHoaDon BC = new rptBaoCaoHoaDon();
            BC.SetDataSource(dta);
            CRVBCHD.ReportSource = BC;
        }
    }
}
