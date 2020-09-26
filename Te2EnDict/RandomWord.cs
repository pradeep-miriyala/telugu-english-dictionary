using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Te2EnDict
{
    public enum StateSelection { Play, Pause, Stop };
    public partial class RandomWord : Form
    {
        public StateSelection ss;
        private MainFrame mf;
        public RandomWord()
        {
            mf = (Application.OpenForms["MainFrame"] as MainFrame);
            InitializeComponent();
            ss = StateSelection.Play;            
        }
        #region Play, Pause, Stop , Forward and Reverse functions

        public  void btnPause_Click(object sender, EventArgs e)
        {            
            if(ss.Equals(StateSelection.Stop))
            {
                ss=StateSelection.Play;
                if(mf.displayLang.Equals(MainFrame.lang.english))
                    btnPause.Text = StateSelection.Pause.ToString(); 
                else
                    btnPause.Text = "విరామము";
                return;
            }
            if (ss.Equals(StateSelection.Play))
            {
                ss = StateSelection.Pause;
                if(mf.displayLang.Equals(MainFrame.lang.english))
                    btnPause.Text = StateSelection.Play.ToString();
                else
                    btnPause.Text = "మొదలుపెట్టు";
            }
            else
            {
                ss = StateSelection.Play;
                if(mf.displayLang.Equals(MainFrame.lang.english))
                    btnPause.Text = StateSelection.Pause.ToString();
                else
                    btnPause.Text = "విరామము";
            }
        }

        public  void btnStop_Click(object sender, EventArgs e)
        {            
            ss = StateSelection.Stop;
            btnPause.Text = StateSelection.Play.ToString();
            mf.randomWord_Tick(sender, e);
        }
        public string GetBtnPauseTxt()
        {
            return (btnPause.Text);
        }

        public  void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !alwaysOnTopToolStripMenuItem.Checked;
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mf.randomNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            mf.randomPrevious();
        }
        #endregion

        public void changeLanguage(MainFrame.lang displayLang)
        {
            if (displayLang.Equals(MainFrame.lang.telugu))
            {
                this.Text = "యాధ్రుచ్చిక పదము";

                btnNext.Text = "తరువాయి";
                btnPrevious.Text = "ముందరి";
                btnStop.Text = "ఆపుము";
                if (ss.Equals(StateSelection.Pause))
                    btnPause.Text = "మొదలుపెట్టు";
                else if (ss.Equals(StateSelection.Play))
                    btnPause.Text = "విరామము";
            }
            else if (displayLang.Equals(MainFrame.lang.english))
            {
                this.Text = "Random word";

                btnNext.Text = "Next";
                btnPrevious.Text = "Previous";
                btnStop.Text = "Stop";
                if (ss.Equals(StateSelection.Pause))
                    btnPause.Text = "Play";
                else if (ss.Equals(StateSelection.Play))
                    btnPause.Text = "Pause";
            }
        }
    }
}
