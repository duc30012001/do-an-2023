using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Reflection;
using DevExpress.XtraReports.UI;
using System.IO;

namespace KeToan
{
    public partial class frmGridChung : DevexpressNVP.frmGridview
    {
        public frmGridChung()
        {
            InitializeComponent();
        }
        public virtual void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
        }
        public void btnThem_Click(object sender, EventArgs e)
        {
            Add();
        }
         public virtual void Add()
        {
            SqlConnect.connect.isAdd = 1;
            SqlConnect.connect.frmEdit.ShowDialog();
            LoadData();
        }

        public void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Edit();
         }
         public void btnSua_Click(object sender, EventArgs e)
         {
             Edit();
         }

        public void barDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Delete();
         }

         public void btnXoa_Click(object sender, EventArgs e)
         {
             Delete();
         }
         public void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Refresh();
         }
        
         public virtual void Refresh()
         {
            LoadData();
         }

         public void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Close();
         }

         public void btnThoat_Click(object sender, EventArgs e)
         {
             Close();
         }
   
         public void barPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Print();
         }

         public void btnIn_Click(object sender, EventArgs e)
         {
             Print();
         }

        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
