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
    public partial class frmTinhGiaVon : DevexpressNVP.frmCalBase
    {
        public frmTinhGiaVon()
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
            this.Close();
        }
    }
}
