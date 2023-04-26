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
    public partial class frmDMNCCEdit : DevexpressNVP.frmCatalogBase
    {
        public frmDMNCCEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData();
        }

        private void devNVPLabelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}
