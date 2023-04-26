namespace KeToan
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.groupControl1 = new DevexpressNVP.DevNVPGroupControl();
            this.btnExit = new DevexpressNVP.DevNVPSimpleButton();
            this.btnDelete = new DevexpressNVP.DevNVPSimpleButton();
            this.btnEdit = new DevexpressNVP.DevNVPSimpleButton();
            this.btnAdd = new DevexpressNVP.DevNVPSimpleButton();
            this.splitContainerControl1 = new DevexpressNVP.DevNVPSplitContainerControl();
            this.groupControl2 = new DevexpressNVP.DevNVPGroupControl();
            this.btnCancel = new DevexpressNVP.DevNVPSimpleButton();
            this.btnSave = new DevexpressNVP.DevNVPSimpleButton();
            this.labelControl9 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl8 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl7 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl6 = new DevexpressNVP.DevNVPLabelControl();
            this.cboRole = new DevexpressNVP.DevNVPComboBoxEdit();
            this.txtFullname = new DevexpressNVP.DevNVPTextEdit();
            this.txtRePassword = new DevexpressNVP.DevNVPTextEdit();
            this.txtPassword = new DevexpressNVP.DevNVPTextEdit();
            this.labelControl5 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl4 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl3 = new DevexpressNVP.DevNVPLabelControl();
            this.labelControl2 = new DevexpressNVP.DevNVPLabelControl();
            this.txtUsername = new DevexpressNVP.DevNVPTextEdit();
            this.labelControl1 = new DevexpressNVP.DevNVPLabelControl();
            this.grcUser = new DevexpressNVP.DevNVPGridControl();
            this.grvUser = new DevexpressNVP.DevNVPGridView();
            this.colId = new DevexpressNVP.DevNVPGridColumn();
            this.colTenDN = new DevexpressNVP.DevNVPGridColumn();
            this.colMatKhau = new DevexpressNVP.DevNVPGridColumn();
            this.colTenNguoiDung = new DevexpressNVP.DevNVPGridColumn();
            this.colQuyen = new DevexpressNVP.DevNVPGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 429);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1034, 78);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(894, 34);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(754, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.Location = new System.Drawing.Point(617, 34);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 37);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.Location = new System.Drawing.Point(481, 34);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grcUser);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1034, 429);
            this.splitContainerControl1.SplitterPosition = 323;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.cboRole);
            this.groupControl2.Controls.Add(this.txtFullname);
            this.groupControl2.Controls.Add(this.txtRePassword);
            this.groupControl2.Controls.Add(this.txtPassword);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtUsername);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(323, 429);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 258);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Ghi";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(100, 192);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(9, 17);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(111, 112);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(9, 17);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(65, 74);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(9, 17);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(98, 39);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(9, 17);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "*";
            // 
            // cboRole
            // 
            this.cboRole.EnterMoveNextControl = true;
            this.cboRole.Location = new System.Drawing.Point(128, 190);
            this.cboRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboRole.Name = "cboRole";
            this.cboRole.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRole.Properties.Items.AddRange(new object[] {
            "Quản trị",
            "Nhập liệu",
            "Xem Báo Cáo"});
            this.cboRole.Size = new System.Drawing.Size(175, 22);
            this.cboRole.TabIndex = 30;
            // 
            // txtFullname
            // 
            this.txtFullname.EnterMoveNextControl = true;
            this.txtFullname.Location = new System.Drawing.Point(128, 151);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFullname.Size = new System.Drawing.Size(175, 22);
            this.txtFullname.TabIndex = 29;
            // 
            // txtRePassword
            // 
            this.txtRePassword.EnterMoveNextControl = true;
            this.txtRePassword.Location = new System.Drawing.Point(128, 113);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRePassword.Properties.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(175, 22);
            this.txtRePassword.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(128, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 193);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 17);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Quyền truy cập:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 155);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 17);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Họ và tên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 117);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 17);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Nhắc lại mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.EnterMoveNextControl = true;
            this.txtUsername.Location = new System.Drawing.Point(128, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUsername.Size = new System.Drawing.Size(175, 22);
            this.txtUsername.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 17);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // grcUser
            // 
            this.grcUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcUser.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcUser.Location = new System.Drawing.Point(0, 0);
            this.grcUser.MainView = this.grvUser;
            this.grcUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grcUser.Name = "grcUser";
            this.grcUser.Size = new System.Drawing.Size(699, 429);
            this.grcUser.TabIndex = 0;
            this.grcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUser});
            // 
            // grvUser
            // 
            this.grvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTenDN,
            this.colMatKhau,
            this.colTenNguoiDung,
            this.colQuyen});
            this.grvUser.DetailHeight = 294;
            this.grvUser.FixedLineWidth = 1;
            this.grvUser.GridControl = this.grcUser;
            this.grvUser.GroupPanelText = "Kéo một cột để thả vào đây";
            this.grvUser.Name = "grvUser";
            this.grvUser.NewItemRowText = "Thêm mới";
            this.grvUser.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvUser.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvUser.OptionsBehavior.ReadOnly = true;
            this.grvUser.OptionsView.ShowAutoFilterRow = true;
            this.grvUser.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 15;
            this.colId.Name = "colId";
            this.colId.Width = 58;
            // 
            // colTenDN
            // 
            this.colTenDN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenDN.AppearanceCell.Options.UseFont = true;
            this.colTenDN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTenDN.AppearanceHeader.Options.UseFont = true;
            this.colTenDN.Caption = "Tên đăng nhập";
            this.colTenDN.FieldName = "TenDN";
            this.colTenDN.MinWidth = 15;
            this.colTenDN.Name = "colTenDN";
            this.colTenDN.Visible = true;
            this.colTenDN.VisibleIndex = 0;
            this.colTenDN.Width = 318;
            // 
            // colMatKhau
            // 
            this.colMatKhau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colMatKhau.AppearanceCell.Options.UseFont = true;
            this.colMatKhau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMatKhau.AppearanceHeader.Options.UseFont = true;
            this.colMatKhau.Caption = "Mật khẩu";
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.MinWidth = 15;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Width = 58;
            // 
            // colTenNguoiDung
            // 
            this.colTenNguoiDung.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenNguoiDung.AppearanceCell.Options.UseFont = true;
            this.colTenNguoiDung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTenNguoiDung.AppearanceHeader.Options.UseFont = true;
            this.colTenNguoiDung.Caption = "Họ và tên";
            this.colTenNguoiDung.FieldName = "TenNguoiDung";
            this.colTenNguoiDung.MinWidth = 15;
            this.colTenNguoiDung.Name = "colTenNguoiDung";
            this.colTenNguoiDung.Visible = true;
            this.colTenNguoiDung.VisibleIndex = 1;
            this.colTenNguoiDung.Width = 384;
            // 
            // colQuyen
            // 
            this.colQuyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colQuyen.AppearanceCell.Options.UseFont = true;
            this.colQuyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colQuyen.AppearanceHeader.Options.UseFont = true;
            this.colQuyen.Caption = "Quyền đăng nhập";
            this.colQuyen.FieldName = "Quyen";
            this.colQuyen.MinWidth = 15;
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Visible = true;
            this.colQuyen.VisibleIndex = 2;
            this.colQuyen.Width = 216;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 507);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmUser.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị người dùng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevexpressNVP.DevNVPGroupControl groupControl1;
        public DevexpressNVP.DevNVPSimpleButton btnDelete;
        public DevexpressNVP.DevNVPSimpleButton btnEdit;
        public DevexpressNVP.DevNVPSimpleButton btnAdd;
        public DevexpressNVP.DevNVPSplitContainerControl splitContainerControl1;
        public DevexpressNVP.DevNVPGroupControl groupControl2;
        public DevexpressNVP.DevNVPGridControl grcUser;
        public DevexpressNVP.DevNVPGridView grvUser;
        public DevexpressNVP.DevNVPSimpleButton btnCancel;
        public DevexpressNVP.DevNVPSimpleButton btnSave;
        public DevexpressNVP.DevNVPLabelControl labelControl9;
        public DevexpressNVP.DevNVPLabelControl labelControl8;
        public DevexpressNVP.DevNVPLabelControl labelControl7;
        public DevexpressNVP.DevNVPLabelControl labelControl6;
        public DevexpressNVP.DevNVPComboBoxEdit cboRole;
        public DevexpressNVP.DevNVPTextEdit txtFullname;
        public DevexpressNVP.DevNVPTextEdit txtRePassword;
        public DevexpressNVP.DevNVPTextEdit txtPassword;
        public DevexpressNVP.DevNVPLabelControl labelControl5;
        public DevexpressNVP.DevNVPLabelControl labelControl4;
        public DevexpressNVP.DevNVPLabelControl labelControl3;
        public DevexpressNVP.DevNVPLabelControl labelControl2;
        public DevexpressNVP.DevNVPTextEdit txtUsername;
        public DevexpressNVP.DevNVPLabelControl labelControl1;
        public DevexpressNVP.DevNVPGridColumn colId;
        public DevexpressNVP.DevNVPGridColumn colTenDN;
        public DevexpressNVP.DevNVPGridColumn colMatKhau;
        public DevexpressNVP.DevNVPGridColumn colTenNguoiDung;
        public DevexpressNVP.DevNVPGridColumn colQuyen;
        public DevexpressNVP.DevNVPSimpleButton btnExit;
    }
}