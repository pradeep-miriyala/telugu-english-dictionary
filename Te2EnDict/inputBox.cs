using System;
using System.Windows.Forms;

namespace Te2EnDict
{
    public partial class inputBox : Form
    {
        public double val;
        public inputBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            val = System.Convert.ToDouble( textBox1.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
