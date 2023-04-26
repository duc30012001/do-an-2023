using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToan
{
    public partial class frmRptTheKho : DevexpressNVP.frmReportBase
    {
        public frmRptTheKho()
        {
            InitializeComponent();
        }

        private void frmRptSoQuy_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboMaVT, "DMVT", "MaVT, TenVT", "MaVT", "MaVT");
            SqlConnect.connect.GridLookUpEditData(cboMaKho, "DMKho", "MaKho, TenKho", "MaKho", "MaKho");
        }
        public override void View()
        {
            base.View();
            usp_rpt_TheKho rpt = new usp_rpt_TheKho();
            rpt.DataSource = SqlConnect.connect.dsReport;
            DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt);
            tool.ShowPreview();
        }
    }
}
