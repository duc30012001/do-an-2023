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
    public partial class frmNguoiDungEdit : DevexpressNVP.frmCatalogBase
    {
        public frmNguoiDungEdit()
        {
            InitializeComponent();     
       }

        public void frmDMTKEdit_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ngầm định
            base.LoadData();
            // Load dữ liệu cho GridLookupEdit
            SqlConnect.connect.GridLookUpEditData(cboQuyen,
                "(SELECT 1 AS MaQuyen, N'Toàn quyền' AS TenQuyen "
                + " UNION ALL SELECT 2 AS MaQuyen, N'Nhập liệu' AS TenQuyen "
                + " UNION ALL SELECT 3 AS MaQuyen, N'Xem báo cáo' AS TenQuyen)", 
                                "MaQuyen, TenQuyen", "MaQuyen", "TenQuyen");
            //
       }
        public override void Save()
        {
            if(txtMatKhau.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau!111");
                return;
            }
            base.Save();
        }
    }
}
