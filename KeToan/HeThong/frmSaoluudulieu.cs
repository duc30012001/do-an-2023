using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace KeToan.HeThong
{
    public partial class frmSaoluudulieu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoluudulieu()
        {
            InitializeComponent();
        }
        string sDB = "K51_C#_DTBH_Trang_S";
        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlBackup = @"BACKUP DATABASE [" + sDB + @"] TO DISK='" + txtduongdan.Text.Trim()
                               + ".bak'";
                SqlConnect.connect.CheckExecSQL(sqlBackup);

                MessageBox.Show(" Cơ sở dữ liệu " + sDB + " đã được sao lưu");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
                return;
            }
        }

        private void frmPhuchoi_Load(object sender, EventArgs e)
        {
            sDB = "KeToan";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                try
                {
                    txtduongdan.Text = file;
                }
                catch
                {
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}