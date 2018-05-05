using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_3
{
    public partial class GPT_bac2 : Form
    {
        public GPT_bac2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         bool NhapHeSo(string hesoa, string hesob, string hesoc)
            {
                if (hesoa.Trim().Length == 0)
                {
                    MessageBox.Show("Chưa nhập hệ số thứ nhất", "Thong bao loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else if (hesob.Trim().Length == 0)
                {
                    MessageBox.Show("Chưa nhập hệ số thứ 2", "Thong bao loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else if (hesoc.Trim().Length == 0)
                {
                    MessageBox.Show("Chưa nhập hệ số thứ 3", "Thong bao loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;
            }
        private void button_kq_Click(object sender, EventArgs e)
        {
            string a = textBox_heso1.Text;
            string b = textBox_heso2.Text;
            string c = textBox_heso3.Text;
            double a1, b1, c1;
           if(NhapHeSo(a,b,c)==true)
            {
                a1 = Convert.ToDouble(a);
                b1 = Convert.ToDouble(b);
                c1 = Convert.ToDouble(c);
                double x1, x2;
                double telta = System.Math.Pow(b1, 2) - 4 * a1 * c1;
                if (telta> 0)
                {
                    x1 = (-b1 - System.Math.Sqrt(telta)) / (2 * a1);
                    x2 = (-b1 + System.Math.Sqrt(telta)) / (2 * a1);
                    textbox_ketqua.Text = " Phương trình có 2 nghiệm: x1="+x1+" và x2="+x2+"" ;
                }
                else if (telta==0)
                {
                    x1 = -b1 / (2 * a1);
                    textbox_ketqua.Text = " Phương trình có nghiệm là : x=" + x1 +" ";
                }
                else
                    textbox_ketqua.Text = " Phương trình vô nghiệm";
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_nhaplai_Click(object sender, EventArgs e)
        {
            textBox_heso1.Text = "";
            textBox_heso2.Text = "";
            textBox_heso3.Text = "";
        }
    }
}

       