using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAI_4
{
    public partial class Form_dangnhap : Form
    {
        public Form_dangnhap()
        {
            InitializeComponent();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("");
            SqlDataAdapter data = new SqlDataAdapter("Select * from NHANVIEN where MANV="+textBox_matkhau.Text+" and HOTEN="+textBox_tendangnhap.Text+" ");
            DataTable dtable = new DataTable();
            data.Fill(dtable);

        }
    }
}
