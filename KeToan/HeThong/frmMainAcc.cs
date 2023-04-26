using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeToanBanHang.SystemNVP
{
    public partial class frmMainAcc : DevexpressNVP.frmMain
    {
        public frmMainAcc()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                SqlConnect.connect.ViewControls(control);
            }
            this.Text = base.Text;
        }

        private void danhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("TaiKhoan", "MaTK");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }

        private void frmMainAcc_Load(object sender, EventArgs e)
        {

        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("KhachHang", "MaKH");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("HangHoa", "MaHH");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }

        private void danhMụcNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("NganHang", "MaNH");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }

        private void sốTàiKhoảnNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("TKNganHang", "SoTKNH");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }

        private void danhMụcKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            splitContainerControl1.Panel2.Controls.Clear();
            frmViewData tk = new frmViewData("Kho", "MaKho");
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(tk);
        }
    }
}
