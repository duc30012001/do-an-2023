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
    public partial class frmRptSoNKC : DevexpressNVP.frmReportBase
    {
        public frmRptSoNKC()
        {
            InitializeComponent();
        }

        private void frmRptSoQuy_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho GridLookupEdit
        }
        public override void View()
        {
            base.View();
            usp_rpt_SoNKC rpt = new usp_rpt_SoNKC();
            rpt.DataSource = SqlConnect.connect.dsReport;
            DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt);
            tool.ShowPreview();
        }
    }
}
