using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_Format_test
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formtest formtest = new Formtest();
            formtest.MdiParent = this;
            formtest.Show();
        }

        private void lblinfo_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {
            string ten = "Võ Minh Thiện";
            lblinfo.Text = "Họ và tên: " + ten + Environment.NewLine;
            lblinfo.Text += "Ngày viết chương trình: " + System.DateTime.Now;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();
        }
    }
}
