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
    public partial class frmPhuchoi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuchoi()
        {
            InitializeComponent();
        }
        string sDB = "";
        private void frmPhuchoi_Load(object sender, EventArgs e)
        {
            sDB = "KeToan";
        }

        private void btnphuchoi_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlRestore = "Use master ALTER DATABASE [" + sDB + "] SET SINGLE_USER WITH ROLLBACK  IMMEDIATE Use master Restore Database [" + sDB + "] from disk='" + txtduongdan.Text.Trim() + "' WITH replace";
                try
                {
                    SqlConnect.connect.CheckExecSQL(sqlRestore);
                    MessageBox.Show(" Cơ sở dữ liệu " + sDB + " đã được phục hồi");
                }
                catch
                {
                    MessageBox.Show("Cơ sở dữ liệu chưa được sao lưu vào ngày phục hồi");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Restore Database");
                return;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
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