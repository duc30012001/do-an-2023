using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToan
{

    public partial class frmPhieuKTGrid : frmGridChung
    {
        // Khai báo dùng chung
        public frmPhieuKTGrid()
        {
            InitializeComponent();
        }
        public void frmGridview_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho GridControl
            base.LoadData();
            // Form Thêm, Sửa dữ liệu
            SqlConnect.connect.frmEdit = 
                (Form)Assembly.GetExecutingAssembly().CreateInstance("KeToan." + "frmPhieuKTEdit");
        }
        public override void Print()
        {
            base.Print();
            rptPhieuKT rpt = new rptPhieuKT();
            rpt.DataSource = SqlConnect.connect.dsReport;
            DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt);
            tool.ShowPreview();
        }
    }
}
