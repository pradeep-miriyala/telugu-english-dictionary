using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Te2EnDict
{
    public partial class frmTeWriter : Form
    {

        public teData ted;
        public frmTeWriter()
        {
            InitializeComponent();
            ted = new teData();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                Clipboard.SetText(txtUni.Text);
            }
            catch
            {
                //Nothing found in text box... No need to copy anything
            }
        }

        private void txtRts_TextChanged(object sender, EventArgs e)
        {
            txtUni.Text = "";
            for (int i = 0; i < txtRts.Lines.Length;i++ )
            {
                if (!(txtRts.Lines[i].Contains("&#") || txtRts.Lines[i].Contains(";")))
                {
                    if (i != 0)
                        txtUni.Text = txtUni.Text + "\r\n" + ted.print_many_words(txtRts.Lines[i]);
                    else
                        txtUni.Text = ted.print_many_words(txtRts.Lines[i]);
                }
                else
                {
                    string strDummy;
                    strDummy = txtRts.Lines[i].Replace("&#", "@$%^()");
                    strDummy = strDummy.Replace(";", "@$%*()");
                    strDummy = ted.print_many_words(strDummy);
                    strDummy = strDummy.Replace("@$%*()", ";");
                    strDummy = strDummy.Replace("@$%^()", "&#");
                    if (i != 0)
                        txtUni.Text = txtUni.Text + "\r\n" + strDummy ;
                    else
                        txtUni.Text = strDummy ;
                   /* string[] splitline;
                    if (txtRts.Lines[i].Contains("&#"))
                    {
                        splitline = txtRts.Lines[i].Split(new string[] { "&#" }, StringSplitOptions.None);
                        for (int j = 0; j < splitline.Length; j++)
                        {
                            txtUni.Text = txtUni.Text + "&#" + ted.print_many_words(splitline[j]);
                        }
                    }
                    if (txtRts.Lines[i].Contains(";"))
                    {
                        splitline = txtRts.Lines[i].Split(new string[] { ";" }, StringSplitOptions.None);
                        for (int j = 0; j < splitline.Length; j++)
                        {
                            txtUni.Text = txtUni.Text + ";" + ted.print_many_words(splitline[j]);
                        }
                    }*/
                }
            }
            txtUni.SelectionStart = txtUni.Text.Length;
        }
    }
}
