using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToan
{

    public partial class frmNguoiDungGrid : frmGridChung
    {
        // Khai báo dùng chung
        public frmNguoiDungGrid()
        {
            InitializeComponent();
        }
        public void frmGridview_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho GridControl
            base.LoadData();
            // Form Thêm, Sửa dữ liệu
            SqlConnect.connect.frmEdit = 
                (Form)Assembly.GetExecutingAssembly().CreateInstance("KeToan." + "frmNguoiDungEdit");
        }
        public override void Add()
        {
            base.Add();
        }
        public override void Edit()
        {
            base.Edit();
        }
        public override void Delete()
        {
            base.Delete();
        }
        public override void Print()
        {
            base.Print();
        }
        public override void Refresh()
        {
            base.Refresh();
        }
    }
}
