using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KeToan
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        #region properties
        DevexpressNVP.connectsql.FormAction formAction;
        #endregion
        #region Methods
        public void LoadDataGrid()
        {
            DataTable dt = SqlConnect.connect.GetTable("SELECT * FROM NguoiDung");
            grcUser.DataSource = dt;
        }

        public void SetEnabledControls(DevexpressNVP.connectsql.FormAction action)
        {
            switch (action)
            {
                case DevexpressNVP.connectsql.FormAction.Add:
                case DevexpressNVP.connectsql.FormAction.Edit:
                    this.btnAdd.Enabled = false;
                    this.btnEdit.Enabled = false;
                    this.btnDelete.Enabled = false;

                    this.btnSave.Enabled = true;
                    this.btnCancel.Enabled = true;

                    this.txtUsername.Enabled = true;
                    this.txtPassword.Enabled = true;
                    this.txtRePassword.Enabled = true;
                    this.txtFullname.Enabled = true;
                    this.cboRole.Enabled = true;

                    this.grcUser.Enabled = false;

                    break;

                case DevexpressNVP.connectsql.FormAction.Delete:
                case DevexpressNVP.connectsql.FormAction.Save:
                case DevexpressNVP.connectsql.FormAction.Cancel:
                case DevexpressNVP.connectsql.FormAction.Exit:
                case DevexpressNVP.connectsql.FormAction.None:
                default:
                    this.btnAdd.Enabled = true;
                    this.btnEdit.Enabled = true;
                    this.btnDelete.Enabled = true;

                    this.btnSave.Enabled = false;
                    this.btnCancel.Enabled = false;

                    this.txtUsername.Enabled = false;
                    this.txtPassword.Enabled = false;
                    this.txtRePassword.Enabled = false;
                    this.txtFullname.Enabled = false;
                    this.cboRole.Enabled = false;

                    this.grcUser.Enabled = true;
                    break;
            }
        }

        public void ClearTextBoxes()
        {
            this.txtUsername.Text = String.Empty;
            this.txtPassword.Text = String.Empty;
            this.txtRePassword.Text = String.Empty;
            this.txtFullname.Text = String.Empty;
            this.txtUsername.Focus();
        }

        #endregion

        public frmUser()
        {
            InitializeComponent();
        }

        public void frmUser_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnCancel.Visible = true;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            btnExit.Visible = true;
            btnSave.Visible = true;
            this.formAction = DevexpressNVP.connectsql.FormAction.None;
            this.SetEnabledControls(this.formAction);

            this.LoadDataGrid();            
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "TenDN") == null)
                return;
            String username = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "TenDN").ToString();

            this.formAction = DevexpressNVP.connectsql.FormAction.Delete;

            if (XtraMessageBox.Show("Bạn có muốn xóa tên đăng nhập: " + username + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlConnect.connect.Delete("NguoiDung", "TenDN", username);
                MessageBox.Show("Xóa dữ liệu thành công");
                this.LoadDataGrid();
                this.ClearTextBoxes();
            }

            this.SetEnabledControls(DevexpressNVP.connectsql.FormAction.Delete);

            this.formAction = DevexpressNVP.connectsql.FormAction.None;            
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            this.formAction = DevexpressNVP.connectsql.FormAction.Add;
            // Set visible and enable buttons            
            this.SetEnabledControls(this.formAction);
            // Clear textboxes
            this.ClearTextBoxes();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            this.formAction = DevexpressNVP.connectsql.FormAction.Edit;

            this.SetEnabledControls(this.formAction);

            this.txtUsername.Text = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "TenDN").ToString();
            this.txtPassword.Text = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "MatKhau").ToString();
            this.txtRePassword.Text = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "MatKhau").ToString();
            this.txtFullname.Text = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "TenNguoiDung").ToString();

            String role = grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "Quyen").ToString();
            if (role == "1") cboRole.SelectedIndex = 0;
            else cboRole.SelectedIndex = 1;
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string quyen = "";
            string ex = "";
            if (this.cboRole.SelectedIndex == 0) quyen = "1";
            if (this.cboRole.SelectedIndex == 1) quyen = "2";
            if (this.cboRole.SelectedIndex == 2) quyen = "3";

            switch (this.formAction)
            {
                case DevexpressNVP.connectsql.FormAction.Add:

                    if (txtUsername.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Tên đăng nhập không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtUsername.Focus();
                    }
                    else if (txtPassword.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Mật khẩu không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPassword.Focus();
                    }
                    else if (cboRole.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Quyền truy cập không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cboRole.Focus();
                    }
                    else if (txtPassword.Text.Trim() != txtRePassword.Text.Trim())
                    {
                        XtraMessageBox.Show("Mật khẩu đăng nhập và mật khẩu nhập lại khác nhau!", "Lỗi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPassword.Focus();
                    }
                    else if (SqlConnect.connect.CheckPrimary("NguoiDung", "TenDN", txtUsername.EditValue.ToString().Trim()) == true)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại. Nhập lại!");
                        txtUsername.EditValue = "";
                        txtUsername.Focus();
                        return;
                    }
                    else
                    {
                        // Insert the user into NguoiDung
                        string valuelist = "N'" + txtUsername.Text.Trim() + "', "
                                            + "N'" + txtPassword.Text.Trim() + "', "
                                            + "N'" + txtFullname.Text.Trim() + "', "
                                            + "N'" + quyen + "'";
                        if (SqlConnect.connect.Insert("NguoiDung", "TenDN, MatKhau, TenNguoiDung, Quyen", valuelist) == true)
                        {
                            ex = "Thêm mới thành công";
                        }

                        this.SetEnabledControls(DevexpressNVP.connectsql.FormAction.Save);
                        this.formAction = DevexpressNVP.connectsql.FormAction.None;

                        this.ClearTextBoxes();
                        this.LoadDataGrid();
                    }

                    break;

                case DevexpressNVP.connectsql.FormAction.Edit:

             //       int id = int.Parse(grvUser.GetRowCellValue(grvUser.FocusedRowHandle, "Id").ToString());
                    
                    if (txtUsername.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Tên đăng nhập không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtUsername.Focus();
                    }
                    else if (txtPassword.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Mật khẩu không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPassword.Focus();
                    }
                    else if (cboRole.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Quyền truy cập không được trống!", "Lỗi trống dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cboRole.Focus();
                    }
                    else if (txtPassword.Text.Trim() != txtRePassword.Text.Trim())
                    {
                        XtraMessageBox.Show("Mật khẩu đăng nhập và mật khẩu nhập lại khác nhau!", "Lỗi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPassword.Focus();
                    }
                    else
                    { //TenDN, MatKhau, TenNguoiDung, Quyen
                        string updatelist = "TenDN = N'" + txtUsername.Text.Trim() + "', "
                                     + "MatKhau = N'" + txtPassword.Text.Trim() + "', "
                                     + "TenNguoiDung = N'" + txtFullname.Text.Trim() + "', "
                                     + "Quyen = N'" + quyen + "' ";
                        if (SqlConnect.connect.Update("NguoiDung", updatelist, "TenDN", txtUsername.Text.Trim()) == true)
                        {
                            ex = "Cập nhật thành công";
                        }
                    }
                      this.SetEnabledControls(DevexpressNVP.connectsql.FormAction.Save);
                      this.formAction = DevexpressNVP.connectsql.FormAction.None;

                        this.ClearTextBoxes();
                        this.LoadDataGrid();
                    break;
            }
            MessageBox.Show(ex);
           
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.SetEnabledControls(DevexpressNVP.connectsql.FormAction.Cancel);

            this.formAction = DevexpressNVP.connectsql.FormAction.None;
            this.ClearTextBoxes();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}