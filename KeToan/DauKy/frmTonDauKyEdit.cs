using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToan
{
    public partial class frmTonDauKyEdit : DevexpressNVP.frmCatalogBase
    {
        public frmTonDauKyEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData(); 
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboMaVT, "DMVT", "MaVT, TenVT", "MaVT", "MaVT");
            SqlConnect.connect.GridLookUpEditData(cboMaKho, "DMKho", "MaKho, TenKho", "MaKho", "MaKho");

        }
    }
}
