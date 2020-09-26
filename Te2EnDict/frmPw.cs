using System;
using System.Windows.Forms;

namespace Te2EnDict
{
    public partial class PWEntry : Form
    {
        public PWEntry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pwBox.Text == "password")
            {
                DisplayDictionary dd = new DisplayDictionary();
                (dd).Show();
            }

        }
    }
}
