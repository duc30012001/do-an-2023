﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace KeToan
{
    public partial class usp_rpt_SoChiTiet : DevexpressNVP.XtraReportBase
    {
        public usp_rpt_SoChiTiet()
        {
            InitializeComponent();
        }
        public override void XtraReportBase_BeforePrint(object sender, PrintEventArgs e)
        {
            base.XtraReportBase_BeforePrint(sender, e);
        }
    }
}
