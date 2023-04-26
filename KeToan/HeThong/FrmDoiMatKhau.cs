using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeToan
{
    public partial class FrmDoiMatKhau : DevexpressNVP.frmBase
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        public void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTk.Text = DevexpressNVP.connectsql.tendangnhap;            
        }

        public void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMatKhau.Text != SqlConnect.connect.GetTable("SELECT MatKhau FROM NguoiDung WHERE TenDN = N'" + txtTenTk.Text.Trim() + "'").Rows[0]["MatKhau"].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không đúng !");
            }
            else
            {
                try
                {
                    //TenDN, MatKhau, TenNguoiDung, Quyen
                    string updatelist = "TenDN = N'" + txtTenTk.Text.Trim() + "', "
                                 + "MatKhau = N'" + txtMatKhauMoi.Text.Trim() + "' ";
                    if (SqlConnect.connect.Update("NguoiDung", updatelist, "TenDN", txtTenTk.Text.Trim()) == true)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                }
                catch
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!");
                }
            }
        }
        public string tentk;
        public string matkhau;
        
    }
}
