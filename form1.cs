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
    }
}
