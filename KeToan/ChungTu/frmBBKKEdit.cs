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
    public partial class frmBBKKEdit : DevexpressNVP.frmCatalogBase
    {
        // Load dữ liệu khi sửa
        int isLoadEdit = 0;
        public frmBBKKEdit()
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
            SqlConnect.connect.GridLookUpEditData(cboMaVT, "DMVT", "MaVT, TenVT", "MaVT", "MaVT");
            SqlConnect.connect.GridLookUpEditData(cboMaKho, "DMKho", "MaKho, TenKho", "MaKho", "MaKho");
            // Gán mã chứng từ
            txtMaCT.EditValue = SqlConnect.connect.maCT;
            txtMaCT.Visible = false;
            // Xử lý tự tăng số chứng từ
            if (SqlConnect.connect.isAdd == 1)
                txtSoCT.EditValue = SqlConnect.connect.CreateColKeyNew("BBKK", "SoCT", SqlConnect.connect.maCT, 3);
        }
        public override void Save()
        {
            base.Save();
        }
        public override void grv_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.grv_CellValueChanged(sender, e);
            var editor = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.Column.FieldName == "SoLuongKiemKe")
            {
                editor.SetRowCellValue(e.RowHandle, "SoLuongThua",
                          Math.Round(Convert.ToDecimal(editor.GetRowCellValue(e.RowHandle, "SoLuongKiemKe")) -
                          Convert.ToDecimal(editor.GetRowCellValue(e.RowHandle, "SoLuongSoSach")), 0));
                if(Convert.ToDecimal(editor.GetRowCellValue(e.RowHandle, "SoLuongThua")) <= 0)
                {
                    editor.SetRowCellValue(e.RowHandle, "SoLuongThua", 0);
                    editor.SetRowCellValue(e.RowHandle, "SoLuongThieu", editor.GetRowCellValue(e.RowHandle, "SoLuongThua"));
                }
                else
                {
                    editor.SetRowCellValue(e.RowHandle, "SoLuongThieu", 0);
                }
            }
        }
        public override void controls_EditValueChanged(object sender, EventArgs e)
        {
            base.controls_EditValueChanged(sender, e);
        }
    }
}
