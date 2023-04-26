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
    public partial class frmBackupData : DevexpressNVP.frmBase
    {
        public frmBackupData()
        {
            InitializeComponent();
        }
        string sDB = SqlConnect.connect.dtcongty().Rows[0]["Database"].ToString();
        public void btnsaoluu_Click(object sender, EventArgs e)
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

        public void frmPhuchoi_Load(object sender, EventArgs e)
        {
        }

        public void btnChon_Click(object sender, EventArgs e)
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

        public void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}