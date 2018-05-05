using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_2
{
    public partial class HELLO_WORD : Form
    {
        public HELLO_WORD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chuong_trinh ct = new chuong_trinh();
            this.Hide();
            ct.ShowDialog();
            this.Show();
        }
    }
}
