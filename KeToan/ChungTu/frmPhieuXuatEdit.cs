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
    public partial class frmPhieuXuatEdit : DevexpressNVP.frmCatalogBase
    {
        // Load dữ liệu khi sửa
        int isLoadEdit = 0;
        public frmPhieuXuatEdit()
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
            SqlConnect.connect.GridLookUpEditData(cboMaKho, "DMKho", "MaKho, TenKho", "MaKho", "MaKho");
            SqlConnect.connect.GridLookUpEditData(cboMaSanPham, "SanPham", "MaSanPham, TenSanPham", "MaSanPham", "MaSanPham");
            SqlConnect.connect.GridLookUpEditData(cboMaTK, "DMTK", "MaTK, TenTK", "MaTK", "MaTK");
            SqlConnect.connect.GridLookUpEditData(cboMaVT, "DMVT", "MaVT, TenVT", "MaVT", "MaVT");
            // Gán mã chứng từ
            txtMaCT.EditValue = SqlConnect.connect.maCT;
            txtMaCT.Visible = false;
            // Xử lý tự tăng số chứng từ
            if (SqlConnect.connect.isAdd == 1)
                txtSoCT.EditValue = SqlConnect.connect.CreateColKeyNew("PhieuXuat", "SoCT", SqlConnect.connect.maCT, 3);
        }
        public override void Save()
        {
            base.Save();
        }
        public override void grv_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.grv_CellValueChanged(sender, e);
            var editor = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.Column.FieldName == "MaVT")
            {
                string s = SqlConnect.connect.GetTable("SELECT T1.TenVT FROM DMVT T1 WHERE MaVT = N'"
                                        + editor.GetRowCellValue(e.RowHandle, "MaVT") + "'").Rows[0][0].ToString();
                editor.SetRowCellValue(e.RowHandle, "TenVT",
                       SqlConnect.connect.GetTable("SELECT T1.TenVT FROM DMVT T1 WHERE MaVT = N'"
                                        + editor.GetRowCellValue(e.RowHandle,"MaVT") + "'").Rows[0][0].ToString());
                editor.SetRowCellValue(e.RowHandle, "DVT",
                       SqlConnect.connect.GetTable("SELECT T1.DVT FROM DMVT T1 WHERE MaVT = N'"
                                        + editor.GetRowCellValue(e.RowHandle, "MaVT") + "'").Rows[0][0].ToString());
            }
            if (e.Column.FieldName == "SoLuong" || e.Column.FieldName == "DonGia")
            {
                editor.SetRowCellValue(e.RowHandle, "ThanhTien",
                          Math.Round((Convert.ToDecimal(editor.GetRowCellValue(e.RowHandle, "SoLuong"))) *
                          Convert.ToDecimal(editor.GetRowCellValue(e.RowHandle, "DonGia")), 0));
            }
        }
        public override void controls_EditValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
