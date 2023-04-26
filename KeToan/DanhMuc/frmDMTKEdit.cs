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
    public partial class frmDMTKEdit : DevexpressNVP.frmCatalogBase
    {
        public frmDMTKEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData();
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboTKCapTren, "DMTK", "MaTK, TenTK", "MaTK", "MaTK");
        }
        public override void Save()
        {
            string tblName = "DMTK";
            string procedureName = "";
            int npara = 5;
            System.Data.SqlClient.SqlParameter[] parameters = new System.Data.SqlClient.SqlParameter[npara];
            if (ConnectSQLServer._them == 1)
            {
                procedureName = "usp_" + tblName + "_INSERT";
            }
            if (ConnectSQLServer._sua == 1)
            {
                procedureName = "usp_" + tblName + "_UPDATE";
            }

            DataTable dtSave = ConnectSQLServer.GetDataSetProc(procedureName, parameters, npara).Tables[0];

            base.Save();
        }
    }
}
