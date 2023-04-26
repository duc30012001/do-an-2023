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
    public partial class frmLogin : DevexpressNVP.frmBaseLogin
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void frmDangnhap_Load(object sender, EventArgs e)
        {
            /* DataTable dt = new DataTable();
            string ss = SqlConnect.connect.strcon();
            dt = SqlConnect.connect.dtcongty();
           string tencongty = SqlConnect.connect.dtcongty().Rows[0]["tencongty"].ToString(); */
            string tencongty = "HOANG KIM SA";
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string strtbldn = "SELECT TenDN, TenNguoiDung, MatKhau, Quyen FROM NguoiDung WHERE TenDN = N'" +
                                        txtUsername.Text.Trim() + "' AND MatKhau = '" +
                                        txtPassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(strtbldn, SqlConnect.connect.ketnoi());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                DevexpressNVP.frmConnect frm = new DevexpressNVP.frmConnect();
                frm.ShowDialog();
                return;
            }
            SqlDataAdapter adt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Đăng nhập không thành công");
                txtUsername.Refresh();
                txtPassword.Refresh();
                txtUsername.Select();
            }
            else
            {
                this.Hide();
                DevexpressNVP.connectsql.quyen = dt.Rows[0]["Quyen"].ToString();
                DevexpressNVP.connectsql.tendangnhap = dt.Rows[0]["TenDN"].ToString();
                frmV2Main frm = new frmV2Main();
                frm.ShowDialog();
                this.Close();
            }
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void devNVPSimpleButton1_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}