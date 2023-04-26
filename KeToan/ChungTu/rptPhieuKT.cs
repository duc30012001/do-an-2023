using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace KeToan
{
    public partial class rptPhieuKT : DevexpressNVP.XtraReportBase
    {
        public rptPhieuKT()
        {
            InitializeComponent();
        }
        public override void XtraReportBase_BeforePrint(object sender, PrintEventArgs e)
        {
            base.XtraReportBase_BeforePrint(sender, e);
            if (SqlConnect.connect.maCT == "KT")
            {
                lblTenPhieu.Text = "PHIẾU KẾ TOÁN";

            }
        }
    }
}
