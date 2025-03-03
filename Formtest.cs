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
    public partial class Formtest : Form
    {
        public Formtest()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.Font = new Font(lbllaptrinhhien.Font.Name, lbllaptrinhhien.Font.Size,
lbllaptrinhhien.Font.Style ^ FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnhaten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.Text = txtnhapten.Text;
        }

        private void redbtn_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.ForeColor = Color.Red;
            txtnhapten.ForeColor = Color.Red;
        }

        private void bluebtn_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.ForeColor = Color.Blue;
            txtnhapten.ForeColor = Color.Blue;
        }

        private void greenbtn_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.ForeColor = Color.Green;
            txtnhapten.ForeColor = Color.Green;
        }

        private void blackbtn_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinhhien.ForeColor = Color.Black;
            txtnhapten.ForeColor = Color.Black;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            lbllaptrinhhien.Font = new Font(lbllaptrinhhien.Font.Name, lbllaptrinhhien.Font.Size,
lbllaptrinhhien.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            lbllaptrinhhien.Font = new Font(lbllaptrinhhien.Font.Name, lbllaptrinhhien.Font.Size,
lbllaptrinhhien.Font.Style ^ FontStyle.Underline);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
