using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace KeToan
{
    public partial class frmPhieuKTEdit : DevexpressNVP.frmCatalogBase
    {
        // Load dữ liệu khi sửa
        int isLoadEdit = 0;
        public frmPhieuKTEdit()
        {
            InitializeComponent();     
       }
        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData();
            isLoadEdit = 1;
            controls_EditValueChanged(null, null);
            isLoadEdit = 0;
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboMaNC, "DMNCC", "MaNCC, TenNCC, MaSoThue", "MaNCC", "MaNCC");
            SqlConnect.connect.GridLookUpEditData(cboTKNo, "DMTK", "MaTK, TenTK", "MaTK", "MaTK");
            // Gán mã chứng từ
            txtMaCT.EditValue = SqlConnect.connect.maCT;
            txtMaCT.Visible = false;
            // Xử lý tự tăng số chứng từ
            if (SqlConnect.connect.isAdd == 1)
                txtSoCT.EditValue = SqlConnect.connect.CreateColKeyNew("PhieuKT", "SoCT", SqlConnect.connect.maCT, 3);
        }
        public override void Save()
        {
            base.Save();
        }
        public override void grv_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
        }
        public override void controls_EditValueChanged(object sender, EventArgs e)
        {
            if(cboMaNC.ContainsFocus || isLoadEdit == 1)
            {
                txtTenNCC.EditValue = SqlConnect.connect.GetValue("SELECT TenNCC FROM DMNCC WHERE MaNCC = N'"
                                            + cboMaNC.EditValue + "'");
                txtDiaChi.EditValue = SqlConnect.connect.GetValue("SELECT DiaChi FROM DMNCC WHERE MaNCC = N'"
                                            + cboMaNC.EditValue + "'");
            }
        }
    }
}
