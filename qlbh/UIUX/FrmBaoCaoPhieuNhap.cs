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
    public partial class FrmBaoCaoPhieuNhap : Form
    {
        public FrmBaoCaoPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DataTable dta2 = new DataTable();
            dta2 = SQLConnection.ExecuteDataTable("Select ma_pn,ngay_nhap,trang_thai,tong_tien,ma_ncc from phieunhap where ngay_nhap between CONVERT(datetime,'" + date1.Value.Date.ToString("MM/dd/yyyy") + "')and CONVERT(datetime,'" + date2.Value.Date.ToString("MM/dd/yyyy") + "')");
            rptBaoCaoPhieuNhap BC2 = new rptBaoCaoPhieuNhap();
            BC2.SetDataSource(dta2);
            CRVBCPhieuNhap.ReportSource = BC2;
        }
    }
}
