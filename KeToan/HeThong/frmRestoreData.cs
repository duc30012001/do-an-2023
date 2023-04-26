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
    public partial class frmRestoreData : DevexpressNVP.frmBase
    {
        public frmRestoreData()
        {
            InitializeComponent();
        }
        string sDB = "";
        public void frmPhuchoi_Load(object sender, EventArgs e)
        {
            sDB = SqlConnect.connect.dtcongty().Rows[0]["Database"].ToString();
        }

        public void btnphuchoi_Click(object sender, EventArgs e)
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

        public void btnChon_Click(object sender, EventArgs e)
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

        public void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}