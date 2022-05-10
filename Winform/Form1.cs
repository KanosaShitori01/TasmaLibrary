using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasmaControl;
using System.Data.SqlClient;
namespace Winform
{
    public partial class Form1 : Form
    {
        SqlConnection conn = TasmaMain.ketnoi(@"DESKTOP-MC\SQLEXPRESS", "QL_BANHANG");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dictionary<string, object> dlcanthem = new Dictionary<string, object>();
            //dlcanthem.Add("ID", "KV002");
            //dlcanthem.Add("NAME", "Nguyễn Trần Lâm");
            //if (TasmaMain.ThemDuLieu("KHACHVJP", dlcanthem, conn))
            //{
            //    MessageBox.Show("Đã Thêm Thành Công " + dlcanthem["ID"]);
            //}
            //else MessageBox.Show("Thêm thất bại");
            //Dictionary<string, object> dlcansua = new Dictionary<string, object>();
            //dlcansua.Add("TENNV", "Nguyễn Trần Tuyết Mai");
            //dlcansua.Add("BOPHAN", "Phòng Tính Tèn");
            //if(TasmaMain.SuaDuLieu("NHANVIEN", dlcansua, "MANV", "NV011", conn))
            //{
            //    MessageBox.Show("Đã sửa thành công");
            //}

            //dataGridView1.DataSource = dt; 
            //if (TasmaMain.XoaDuLieu("KHACHVsJP", "ID", "KV001", conn))
            //{
            //    MessageBox.Show("OKE");
            //}
            //else MessageBox.Show("Co loi");
            //string oke = TasmaMain.IDSinhTruong("MUDA099");
            //MessageBox.Show(oke);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
