using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToan
{
    public partial class frmV4Main : DevexpressNVP.frmMainBase
    {
        public frmV4Main()
        {
            InitializeComponent();
         }


        public void frmV4Main_Load(object sender, EventArgs e)
        {
            SqlConnect.connect.quyen = "1";
            DevexpressNVP.connectsql.quyen = "1";
            this.Text = "PHẦN MỀM KẾ TOÁN VẬT TƯ TẠI " + SqlConnect.connect.dtcongty().Rows[0]["tencongty"].ToString();
        }

        public void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDMTKGrid frm = new frmDMTKGrid();
            frm.ShowDialog();
        }

        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
         //   frmUser form = new frmUser();
            frmNguoiDungGrid form = new frmNguoiDungGrid();
            form.ShowDialog();
        }

        public void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmBackupData frm = new frmBackupData();
            frm.ShowDialog();
        }

        public void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRestoreData frm = new frmRestoreData();
            frm.ShowDialog();
        }

        public void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        public void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        public void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmBoPhanGrid frm = new frmBoPhanGrid();
            frm.ShowDialog();
        }

        public void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMNCCGrid frm = new frmDMNCCGrid();
            frm.ShowDialog();
        }

        public void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMVTGrid frm = new frmDMVTGrid();
            frm.ShowDialog();
        }

        public void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmSanPhamGrid frm = new frmSanPhamGrid();
            frm.ShowDialog();
        }

        public void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMKhoGrid frm = new frmDMKhoGrid();
            frm.ShowDialog();
        }

        public void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmSoDuDauKyGrid frm = new frmSoDuDauKyGrid();
            frm.ShowDialog();
        }

        public void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        public void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PN";
            frmPhieuNhapGrid frm = new frmPhieuNhapGrid();
            frm.ShowDialog();
        }

        public void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PX";
            frmPhieuXuatGrid frm = new frmPhieuXuatGrid();
            frm.ShowDialog();
        }

        public void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        public void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KT";
            frmPhieuKTGrid frm = new frmPhieuKTGrid();
            frm.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTietVatTu frm = new frmRptSoChiTietVatTu();
            frm.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTHNXT frm = new frmRptTHNXT();
            frm.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTonKho frm = new frmRptTonKho();
            frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTheKho frm = new frmRptTheKho();
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoCai frm = new frmRptSoCai();
            frm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTiet frm = new frmRptSoChiTiet();
            frm.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoNKC frm = new frmRptSoNKC();
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KK";
            frmBBKKGrid frm = new frmBBKKGrid();
            frm.ShowDialog();
        }

       

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "6")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmHuongDanPhanMem frm = new frmHuongDanPhanMem();
            frm.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KK";
            frmTonDauKyGrid frm = new frmTonDauKyGrid();
            frm.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmTinhGiaVon frm = new frmTinhGiaVon();
            frm.ShowDialog();
        }

        private void devNVPLabelControl6_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCNK frm = new frmRptBCNK();
            //frm.ShowDialog();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCXK frm = new frmRptBCXK();
            //frm.ShowDialog();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTheKho frm = new frmRptTheKho();
            frm.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            //   frmUser form = new frmUser();
            frmNguoiDungGrid form = new frmNguoiDungGrid();
            form.ShowDialog();
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmBackupData frm = new frmBackupData();
            frm.ShowDialog();
        }

        private void phụcHồiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen != "1")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRestoreData frm = new frmRestoreData();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMTKGrid frm = new frmDMTKGrid();
            frm.ShowDialog();
        }

        private void danhMụcVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMVTGrid frm = new frmDMVTGrid();
            frm.ShowDialog();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMNCCGrid frm = new frmDMNCCGrid();
            frm.ShowDialog();
        }

        private void danhMụcBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmBoPhanGrid frm = new frmBoPhanGrid();
            frm.ShowDialog();
        }

        private void danhMụcKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmSanPhamGrid frm = new frmSanPhamGrid();
            frm.ShowDialog();
        }

        private void danhMụcKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMKhoGrid frm = new frmDMKhoGrid();
            frm.ShowDialog();
        }

        private void tồnĐầuKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KK";
            frmTonDauKyGrid frm = new frmTonDauKyGrid();
            frm.ShowDialog();
        }

        private void sốDưĐầuKỳTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmSoDuDauKyGrid frm = new frmSoDuDauKyGrid();
            frm.ShowDialog();
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PN";
            frmPhieuNhapGrid frm = new frmPhieuNhapGrid();
            frm.ShowDialog();
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PX";
            frmPhieuXuatGrid frm = new frmPhieuXuatGrid();
            frm.ShowDialog();
        }

        private void biênBảnKiểmKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KK";
            frmBBKKGrid frm = new frmBBKKGrid();
            frm.ShowDialog();
        }

        private void phiếuKếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KT";
            frmPhieuKTGrid frm = new frmPhieuKTGrid();
            frm.ShowDialog();
        }

        private void tínhGiáVốnHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmTinhGiaVon frm = new frmTinhGiaVon();
            frm.ShowDialog();
        }

        private void thẻKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTheKho frm = new frmRptTheKho();
            frm.ShowDialog();
        }

        private void sổChiTiếtVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTietVatTu frm = new frmRptSoChiTietVatTu();
            frm.ShowDialog();
        }

        private void sổCáiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoCai frm = new frmRptSoCai();
            frm.ShowDialog();
        }

        private void sổChiTiếtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTiet frm = new frmRptSoChiTiet();
            frm.ShowDialog();
        }

        private void báoCáoTổngHợpNhậpXuấtTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTHNXT frm = new frmRptTHNXT();
            frm.ShowDialog();
        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTonKho frm = new frmRptTonKho();
            frm.ShowDialog();
        }

        private void báoCáoNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCNK frm = new frmRptBCNK();
            //frm.ShowDialog();
        }

        private void báoCáoXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCXK frm = new frmRptBCXK();
            //frm.ShowDialog();
        }

        private void btnVicPro_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMVTGrid frm = new frmDMVTGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton2_Click(object sender, EventArgs e)
        {
            frmDMTKGrid frm = new frmDMTKGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton1_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMNCCGrid frm = new frmDMNCCGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton5_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmBoPhanGrid frm = new frmBoPhanGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton4_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmSanPhamGrid frm = new frmSanPhamGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton3_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmDMKhoGrid frm = new frmDMKhoGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton6_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PN";
            frmPhieuNhapGrid frm = new frmPhieuNhapGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton7_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "PX";
            frmPhieuXuatGrid frm = new frmPhieuXuatGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton8_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KK";
            frmBBKKGrid frm = new frmBBKKGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton9_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "3")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            SqlConnect.connect.maCT = "KT";
            frmPhieuKTGrid frm = new frmPhieuKTGrid();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton13_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTheKho frm = new frmRptTheKho();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton12_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTietVatTu frm = new frmRptSoChiTietVatTu();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton11_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoCai frm = new frmRptSoCai();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton10_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptSoChiTiet frm = new frmRptSoChiTiet();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton17_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTHNXT frm = new frmRptTHNXT();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton16_Click(object sender, EventArgs e)
        {
            if (DevexpressNVP.connectsql.quyen == "2")
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
                return;
            }
            frmRptTonKho frm = new frmRptTonKho();
            frm.ShowDialog();
        }

        private void devNVPSimpleButton14_Click(object sender, EventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCNK frm = new frmRptBCNK();
            //frm.ShowDialog();
        }

        private void devNVPSimpleButton15_Click(object sender, EventArgs e)
        {
            //if (DevexpressNVP.connectsql.quyen == "2")
            //{
            //    MessageBox.Show("Bạn không đủ quyền thực hiện chức năng này");
            //    return;
            //}
            //frmRptBCXK frm = new frmRptBCXK();
            //frm.ShowDialog();
        }
    }
}
