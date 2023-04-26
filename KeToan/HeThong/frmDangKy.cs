using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace KeToan
{
    public partial class frmDangKy : DevexpressNVP.frmBase
    {
        public frmDangKy()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                SqlConnect.connect.ViewControls(control);
            }
            cboRole.Properties.DataSource = SqlConnect.connect.GetTable("SELECT 1 AS Quyen, N'Toàn quyền' AS TenQuyen UNION ALL SELECT 2, N'Nhập liệu' UNION ALL SELECT 3, N'Xem báo cáo' ORDER BY Quyen");
            cboRole.Properties.ValueMember = "Quyen";
            cboRole.Properties.DisplayMember = "Quyen";
        }

        public void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Tên người dùng không được để trống", "Thông báo");
                txtUser.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo");
                txtPassword.Focus();
                return;
            }
            if (txtPassword2.Text != txtPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Thông Báo");
                txtPassword2.Refresh();
                txtPassword2.Focus();
                return;
            }
            if (SqlConnect.connect.CheckPrimary("NguoiDung", "TenDN", txtUser.Text.Trim()) == false)
            {
                string tentruong = "TenDN, MatKhau, TenNguoiDung, Quyen";
                string giatri = "'" + txtUser.Text + "','" + txtPassword.Text + "',N'" + txtFullName.Text + "'," + cboRole.EditValue + "";
                //"',N'"+txtquyen.Text+"'";
                SqlConnect.connect.Insert("NguoiDung", tentruong, giatri, "TenDN", txtUser.Text.Trim(), true);
                MessageBox.Show("Đăng kí thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên người dùng đã tồn tại", "Thông báo");
                txtUser.Refresh();
                txtPassword.Refresh();
                txtPassword2.Refresh();
                //txtquyen.Clear();
                txtUser.Select();
            }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboRole_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}