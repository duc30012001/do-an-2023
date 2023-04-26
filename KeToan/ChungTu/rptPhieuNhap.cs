using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace KeToan
{
    public partial class rptPhieuNhap : DevexpressNVP.XtraReportBase
    {
        public rptPhieuNhap()
        {
            InitializeComponent();
        }
        public override void XtraReportBase_BeforePrint(object sender, PrintEventArgs e)
        {
            base.XtraReportBase_BeforePrint(sender, e);
            if (SqlConnect.connect.maCT == "PX")
            {
                lblTenPhieu.Text = "PHIẾU XUẤT KHO";
                lblDT.Text = "Công Trình";

            }
        }
    }
}
