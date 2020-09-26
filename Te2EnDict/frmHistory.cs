using System;
using System.Windows.Forms;
using System.IO;

namespace Te2EnDict
{    
    public partial class frmHistory : Form
    {
        private MainFrame mf;
        string[] TimeStamps;
        ListBox lstFileList;
        
        public frmHistory()
        {
            InitializeComponent();
        }

        #region History items

        private void frmHistory_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo di,di1;
                string timestamp, timestamp1;
                mf = Application.OpenForms["MainFrame"] as MainFrame;
                treeFolderList.Nodes.Clear();
                TimeStamps = System.IO.Directory.GetDirectories(Application.UserAppDataPath);
                for (int i=0;i<TimeStamps.Length;i++)
                {
                    timestamp = TimeStamps[i];                    
                    if (timestamp == mf.MyPath)
                        continue;
                    di = new System.IO.DirectoryInfo(timestamp);
                    for (int j = i; j < TimeStamps.Length; j++)
                    {
                        timestamp1 = TimeStamps[j];
                        if (timestamp1 == mf.MyPath)
                            continue;
                        di1 = new System.IO.DirectoryInfo(timestamp1);
                        if (di.CreationTime > di1.CreationTime)
                        {
                            TimeStamps[j] = timestamp;
                            TimeStamps[i] = timestamp1;
                            break;
                        }
                    }
                    Application.DoEvents();
                }
                foreach (string t in TimeStamps)
                {
                    if (t == mf.MyPath)
                        continue;
                    di = new System.IO.DirectoryInfo(t);
                    treeFolderList.Nodes.Add(di.Name);
                    Application.DoEvents();
                }
                lstFileList = new ListBox();
                lstFileList.Visible = false;
                treeFolderList.Sort();
                treeFolderList.SelectedNode = treeFolderList.Nodes[0];
                lstWordlist.SelectedIndex = 0;
                changeLanguage(mf.displayLang);
            }
            catch
            {

            }

        }

        private void treeFolderList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

                string s;
                string[] t;
                StreamReader sr = new StreamReader(Application.UserAppDataPath + "\\" + e.Node.Text + "\\logfile.log");
                lstWordlist.Items.Clear();
                lstFileList.Items.Clear();
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    t = s.Split(new string[] { "\t" }, 2, StringSplitOptions.RemoveEmptyEntries);
                    lstWordlist.Items.Add(t[0]);
                    lstFileList.Items.Add(Application.UserAppDataPath + "\\" + e.Node.Text + "\\" + t[1]);
                    Application.DoEvents();
                }
                sr.Close();
                lstWordlist.SelectedIndex = 0;
            }
            catch
            {
                
            }
        }

        private void lstWordlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            brwDisplay.Navigate("about:blank");
            brwDisplay.Navigate(lstFileList.Items[lstWordlist.SelectedIndex].ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteItem(treeFolderList.SelectedNode.Text, treeFolderList.SelectedNode.Index);            
        }

        private void deleteItem(string fldr,int inx)
        {
            try
            {
                string selpath = Application.UserAppDataPath + "\\" + fldr;
                foreach (string s in System.IO.Directory.GetFiles(selpath))
                    System.IO.File.Delete(s);
                System.IO.Directory.Delete(selpath);
                treeFolderList.Nodes.RemoveAt(inx );
            }
            catch
            {                
            }
        }

        #endregion

        #region displayLanguage 

        public void changeLanguage(MainFrame.lang displayLang)
        {
            if (displayLang.Equals(MainFrame.lang.telugu))
            {
                this.Text = "చరిత్ర";
                
                toolTip1.ToolTipTitle = "తెలుగు ఆంగ్లం నిఘంటువు ";
                toolTip1.SetToolTip(treeFolderList, "చరిత్రను చూపుట కొరకు తేదీ మరియు సమయమును ఎంచుకోండి ");
                toolTip1.SetToolTip(lstWordlist, "మీరు వెతికిన పదములు  లేదా చూపబడిన యాధ్రుచ్చిక పదములు");
                toolTip1.SetToolTip(brwDisplay, "మీరు ఎంచుకున్న పదము యొక్క అర్ధము");
            }
            else if (displayLang.Equals(MainFrame.lang.english))
            {
                this.Text = "History";

                toolTip1.ToolTipTitle = "Telugu English Dictionary";
                toolTip1.SetToolTip(treeFolderList, "Select the date and time for the history element");
                toolTip1.SetToolTip(lstWordlist, "List of words searched or used for random display");
                toolTip1.SetToolTip(brwDisplay, "Meaning of the selected word");
            }
        }
       
        #endregion

        private void clearEntireHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0;i<treeFolderList.Nodes.Count;i++)
            {
                deleteItem(treeFolderList.Nodes[i].Text, treeFolderList.Nodes[i].Index);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}