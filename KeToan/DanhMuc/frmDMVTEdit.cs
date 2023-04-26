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
    public partial class frmDMVTEdit : DevexpressNVP.frmCatalogBase
    {
        public frmDMVTEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData();
        }
        public override void Save()
        {
            base.Save();
        }
    }
}
