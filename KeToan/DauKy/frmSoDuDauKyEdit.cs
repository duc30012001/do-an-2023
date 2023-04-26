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
    public partial class frmSoDuDauKyEdit : DevexpressNVP.frmCatalogBase
    {
        public frmSoDuDauKyEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData(); 
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboMaTK, "DMTK", "MaTK, TenTK", "MaTK", "MaTK");

        }
    }
}
