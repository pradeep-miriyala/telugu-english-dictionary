using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Te2EnDict
{   
    public partial class MainFrame : Form
    {
        #region Variable Definitions
        /// <summary>
        /// Language enum is to set the language in use
        /// </summary>
        public enum lang { english, telugu, other };
        /// <summary>
        /// Enum for stauts message flags, which can be used to display the status message
        /// </summary>
        public enum statusmsgids { wordnotfound, resultdisplay,startup,typeInTel,typeInEng };
        /// <summary>
        /// Registry keys used with application. This enum is intended to grow as per new requirements
        /// </summary>
        public enum regKeys { RandomOnStartup,RandomWordOpacity,DefaultTypingLang };
        /// <summary>
        /// Root of the application registry keys
        /// </summary>
        public string regRoot = "HKEY_CURRENT_USER\\Software\\Srideepika\\Te En Dictionary";
        /// <summary>
        /// Flag to check whether the application shall start in tray
        /// </summary>
        bool startinTray;
        /// <summary>
        /// To check whether databases are loaded in to cache
        /// </summary>
        bool dbLoaded;
        /// <summary>
        /// Private member for typing language. Not intended to set directly
        /// </summary>
        private lang _typingLang;
        /// <summary>
        /// Public member for setting typing language. Setting will trigger the required functions
        /// </summary>
        public lang typingLang
        {
            get { return _typingLang; }
            set
            {                
                if (value.Equals(lang.telugu))
                {                    
                    txtTelType.Visible = true;
                    txtQuery.Width = 237;
                    txtQuery.ReadOnly = true;
                    txtQuery.Left = 216;
                    txtTelType.Select();
                    typeinTelugu.Checked = true;
                }
                else if(value.Equals(lang.english))
                {   
                    txtQuery.ReadOnly = false;
                    txtQuery.Width = 237 + txtTelType.Width;
                    txtQuery.Left = txtTelType.Left;
                    txtQuery.Select();
                    txtTelType.Visible = false;
                    typeinTelugu.Checked = false;
                }
                _typingLang = value;
            }
        }
        /// <summary>
        /// Object for telugu type writer
        /// </summary>
        public teData ted;        
        /// <summary>
        /// Random number generator. Will be used for random word generation
        /// </summary>
        public Random random_gen;
        /// <summary>
        /// Object for random word form
        /// </summary>
        private RandomWord rw;
        /// <summary>
        /// Object for history form
        /// </summary>
        private frmHistory fh;
        /// <summary>
        /// Telugu writer object
        /// </summary>
        private frmTeWriter tw;
        /// <summary>
        /// Private member to store the display language, not intended to access directly
        /// </summary>
        private lang _displayLang;
        /// <summary>
        /// Public member to store the display language. Setting value will trigger the required functions
        /// </summary>
        public lang displayLang
        {
            get
            {
                return _displayLang;
            }
            set
            {
                if (value.Equals(lang.telugu))
                {
                    this.Text = "తెలుగు - ఆంగ్లం నిఘంటువు ";                    
                    btnSearch.Text = "వెతుకు";
                    exactMatch.Text = "ఖచ్చితంగా సరిచూడు";
                    toolTip1.SetToolTip(btnSearch, "ఇక్కడ వొత్తండి");
                    toolTip1.SetToolTip(txtQuery, "పదాన్ని ఇక్కడ ఇవ్వండి");
                    toolTip1.SetToolTip(webBrowser1, "అర్ధము");
                    toolTip1.ToolTipTitle = "తెలుగు ఆంగ్లం నిఘంటువు ";
                    helpProvider1.SetHelpKeyword(this, "Telugu");

                    teluguToolStripMenuItem.Checked = true;
                    teluguToolStripMenuItem1.Checked = true;
                    englishToolStripMenuItem.Checked = false;
                    englishToolStripMenuItem1.Checked = false;
                }
                else if (value.Equals(lang.english))
                {
                    this.Text = "Telugu - English Dictionary ";                    
                    btnSearch.Text = "Search";                    
                    exactMatch.Text = "Exact Match";
                    toolTip1.SetToolTip(txtQuery, "Type the word here");
                    toolTip1.SetToolTip(btnSearch, "Click Here");
                    toolTip1.SetToolTip(webBrowser1, "Meaning");
                    toolTip1.ToolTipTitle = "Telugu English Dictionary";
                    helpProvider1.SetHelpKeyword(this, "English");

                    teluguToolStripMenuItem.Checked = false;
                    teluguToolStripMenuItem1.Checked = false;
                    englishToolStripMenuItem.Checked = true;
                    englishToolStripMenuItem1.Checked = true;
                }
                else if (value.Equals(lang.other))
                {
                    // Interface can be either telugu or english 
                    // No other language is allowed. Default is set to telugu
                    value  = lang.telugu;
                }
                if (rw != null)
                    rw.changeLanguage(value);
                if (fh != null)
                    fh.changeLanguage(value);
                _displayLang = value  ;
            }
        }
        /// <summary>
        /// Private member to store status ID. Not intended to use directly
        /// </summary>
        private statusmsgids _sid;
        /// <summary>
        /// Public member to store status IDs. Setting this member will trigger required functions
        /// </summary>
        public statusmsgids sid
        {
            get { return _sid; }
            set
            {                
                if (displayLang.Equals(lang.english))
                {                    
                    if (value.Equals(statusmsgids.resultdisplay))
                    {
                        UpdateStatusMsgs("Searched for  "+txtQuery.Text );
                    }
                    else if (value.Equals(statusmsgids.wordnotfound))
                    {
                        UpdateStatusMsgs("Meaning not found for  "+txtQuery.Text );
                    }
                    else if (value.Equals(statusmsgids.startup))
                    {
                        UpdateStatusMsgs("Welcome, Type word in textbox and hit enter");
                    }
                    else if(value.Equals(statusmsgids.typeInEng))
                    {
                        UpdateStatusMsgs("Typing language selected as English");
                    }
                    else if (value.Equals(statusmsgids.typeInTel ))
                    {
                        UpdateStatusMsgs("Typing language selected as Telugu");
                    }
                }
                else if (displayLang.Equals(lang.telugu))
                {
                    if (value.Equals(statusmsgids.resultdisplay))
                    {
                        UpdateStatusMsgs(txtQuery.Text+"  కొరకు వెతికినారు");
                    }
                    else if (value.Equals(statusmsgids.wordnotfound))
                    {
                        UpdateStatusMsgs(txtQuery.Text + "  యొక్క అర్ధము దొరకలేదు");
                    }
                    else if (value.Equals(statusmsgids.startup))
                    {
                        UpdateStatusMsgs("స్వాగతము, పదాన్ని టైపు చేసి ఎంటర్ బటనును వొత్తండి");
                    }
                    else if (value.Equals(statusmsgids.typeInEng))
                    {
                        UpdateStatusMsgs("టైపింగు భాష ఆంగ్లముగా ఎంచుకోబడినది");
                    }
                    else if (value.Equals(statusmsgids.typeInTel))
                    {
                        UpdateStatusMsgs("టైపింగు భాష తెలుగుగా ఎంచుకోబడినది");
                    }
                }                
                _sid = value;
            }
        }
        /// <summary>
        /// Public string to get or set the text in query box
        /// </summary>
        public string txtQueryString
        {
            get { return txtQuery.Text; }
            set { txtQuery.Text = value; }
        }
        /// <summary>
        /// User's application data path
        /// </summary>
        public string MyPath;
        /// <summary>
        /// User's program files path
        /// </summary>
        public string App_Path;
        /// <summary>
        /// Generated random numbers
        /// </summary>
        private int rw_t,rw_e;
        /// <summary>
        /// Stream writer to write log file of the words searched 
        /// </summary>
        StreamWriter log;
        /// <summary>
        /// Caption for all message box displays
        /// </summary>
        public string mbcaption = "Te2En Dictionary";
        /// <summary>
        /// Temporary html file name for displaying result
        /// </summary>
        private string tempFile = "temp.html";
        /// <summary>
        /// Temporary html file name for displaying random telugu word
        /// </summary>
        private string tempRnFileTe = "tempte.html";
        /// <summary>
        /// Temporary html file name for displaying random english word
        /// </summary>
        private string tempRnFileEn = "tempen.html";
        /// <summary>
        /// deafult file name to store and display telugu random word
        /// </summary>
        private const string TeRn = "\\tempte";
        /// <summary>
        /// default file name to store and display english random word
        /// </summary>
        private const string EnRn = "\\tempen";
        /// <summary>
        /// Extension for all result files
        /// </summary>
        private const string ext = ".html";
        /// <summary>
        /// Random values counter. Stores how many random numbers created till now
        /// </summary>
        private int rnCntr;
        /// <summary>
        /// Current index in the random counting
        /// </summary>
        private int inxCntr;
        /// <summary>
        /// Count of normal words searched
        /// </summary>
        private int nCntr;
        #endregion

        #region Form Initialzation and Form related functions

        public MainFrame()
        {
            InitVars();
            InitializeComponent();
            startinTray = false;
            Show();
            toolStripMenuItem1.Text = "Hide";
            this.WindowState = FormWindowState.Normal;
        }

        public MainFrame(bool InTray)
        {
            InitVars();
            InitializeComponent();
            startinTray = InTray;
            if (InTray)
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
                toolStripMenuItem1.Text = "Show";
                
            }
            else
            {
                Show();
                toolStripMenuItem1.Text = "Hide";
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            int showRandom;
            int deftype = 0;
            try
            {
                showRandom = (int)Microsoft.Win32.Registry.GetValue(regRoot, regKeys.RandomOnStartup.ToString(), 0);
            }
            catch
            {
                showRandom = 0;
            }
            //Initialization of random word counters
            rnCntr = 0;
            inxCntr = 0;
            //Initialization of normal word history
            nCntr = 0;
            App_Path = Application.StartupPath;
            dbLoaded = false;
            try
            {
               deftype= (int)Microsoft.Win32.Registry.GetValue(regRoot, regKeys.DefaultTypingLang.ToString(), 0);
            }
            catch
            {
                deftype=0;
            }
            if ( deftype == 0)
            {
                teluguToolStripMenuItem2.Checked = true;
                englishToolStripMenuItem2.Checked = false;
                typingLang = lang.telugu;
            }
            else
            {
                teluguToolStripMenuItem2.Checked = false;
                englishToolStripMenuItem2.Checked = true;
                typingLang  = lang.english;
            }
            sid = statusmsgids.startup;            
            random_gen = new Random();
            if (startinTray)
            {
                Hide();
                toolStripMenuItem1.Text = "Show";
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                Show();
                toolStripMenuItem1.Text = "Hide";
            }            
            if (showRandom == 1)
            {
                //If show random at startup is enabled, start the random word display
                randomWordToolStripMenuItem_Click(sender, e);
                startWithProgramToolStripMenuItem.Checked = true;
            }
            displayLang = lang.telugu;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        public void InitVars()
        {            
            ted = new teData();
            MyPath = System.DateTime.Now.ToString("d/MMM/yyyy/hh:mm:ss");
            MyPath = MyPath.Replace("/", "_");
            MyPath = MyPath.Replace(":", "_");
            MyPath = Application.UserAppDataPath + "\\" + MyPath;

            System.IO.Directory.CreateDirectory(MyPath);

            tempFile = MyPath + "\\" + tempFile;
            tempRnFileEn = MyPath + "\\" + tempRnFileEn;
            tempRnFileTe = MyPath + "\\" + tempRnFileTe;

            log = new StreamWriter(MyPath + "\\logfile.log");
        }
        void MainFrame_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            log.Close();
        }

        #endregion        

        /* This is obsolete, as the linklabel is deleted from the form. 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start("Iexplore", "http://www.miriyala.in");
        }*/
        
        #region Database queries

        public DataTable ExecuteQuery(string query,lang langselection)
        {
            OleDbConnection conn = null;
            conn = GetConnection(langselection );
            return ExecuteQuery(query, conn);
        }

        public DataTable ExecuteQuery(string query, System.Data.OleDb.OleDbConnection conn)
        {

            DataTable dt = new DataTable();

            OleDbDataAdapter adapter = null;
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter = new OleDbDataAdapter(query, conn);                
                //adapter.SelectCommand.Transaction = tx;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
            return dt;
        }

        private OleDbConnection GetConnection(string FileName)
        {

            //string sPath = "c:\\sites\\content\\m\\d\\i\\mdileep\\" + FileName ;
            string sPath = MyPath + FileName;
            string strConnection = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + sPath + "";
            return new OleDbConnection(strConnection);
        }

        private OleDbConnection GetConnection(lang langselection)
        {   
            if (langselection.Equals(lang.telugu))
                return dictTableAdapter1.Connection;
            else
                return eng2teTableAdapter1.Connection ;               
            //return GetConnection("te2en.mdb");
        }

        public static string SQLInj(string str)
        {
            string tempStr = str;

            if (tempStr != null) { return tempStr.Replace("'", "''"); }
            else { return tempStr; }
        }

        protected void SearchItem(object sender, EventArgs e,lang langselection)
        {
            try
            {
                string Search=  txtQuery.Text.TrimEnd(new char[]{' '}) ;
                
                if (Search != null)
                {
                    bool IsLike = ! exactMatch.Checked  ;
                    bool multiple = IsLike ;
                    string Crit = IsLike ? " like '{0}%'" : " ='{0}'";
                    string select;
                    DataTable dt;
                    nCntr++;
                    if (langselection.Equals(lang.telugu))
                    {
                        select=String.Format("select * from Dict where name" + Crit, SQLInj(Search));
                        dt = ExecuteQuery(select, GetConnection(langselection ));
                        dictBindingSource.DataSource = dt;
                        tempFile = MyPath + "\\temp_" + nCntr.ToString() + ext;
                        if (string.IsNullOrEmpty(webBrowser1.Tag.ToString()))
                            sid = statusmsgids.wordnotfound;
                        else
                            sid = statusmsgids.resultdisplay;
                        if (!IsLike)
                        {
                            if (dictBindingSource.List.Count <= 1)
                                tempFile = PrepareHtmlFile(tempFile, webBrowser1.Tag.ToString(), invRandomWord.Tag.ToString());
                            else                            
                                multiple = true;                            
                        }
                        if(multiple)                 
                        {
                            string[] wordlist, meaninglist;
                            wordlist = new string[dictBindingSource.List.Count];
                            meaninglist = new string[dictBindingSource.List.Count];
                            dictBindingSource.MoveFirst();
                            for (int i = 0; i < wordlist.Length; i++)
                            {
                                wordlist[i] = invRandomWord.Tag.ToString();
                                meaninglist[i] = webBrowser1.Tag.ToString();
                                dictBindingSource.MoveNext();
                            }
                            tempFile = PrepareHtmlFile(tempFile, meaninglist, wordlist, Search + "*",IsLike );
                        }
                    }
                    else
                    {
                        select = String.Format("select * from eng2te where eng_word" + Crit, SQLInj(Search));
                        dt = ExecuteQuery(select, GetConnection(langselection ));
                        eng2teBindingSource.DataSource = dt;
                        tempFile = MyPath + "\\temp_" + nCntr.ToString() + ext;
                        if (string.IsNullOrEmpty(webBrowser1.AccessibleDescription))
                            sid = statusmsgids.wordnotfound;
                        else
                            sid = statusmsgids.resultdisplay;
                        if (!IsLike)
                        {
                            if (eng2teBindingSource.List.Count <= 1)
                                tempFile = PrepareHtmlFile(tempFile, webBrowser1.AccessibleDescription, invRandomWord.Text);
                            else
                                multiple = true;
                        }
                        if(multiple)
                        {
                            string[] wordlist, meaninglist;
                            wordlist = new string[eng2teBindingSource.List.Count];
                            meaninglist = new string[eng2teBindingSource.List.Count];
                            eng2teBindingSource.MoveFirst();
                            for (int i = 0; i < wordlist.Length; i++)
                            {
                                wordlist[i] = invRandomWord.Text;
                                meaninglist[i] = webBrowser1.AccessibleDescription;
                                eng2teBindingSource.MoveNext();
                            }
                            tempFile = PrepareHtmlFile(tempFile, meaninglist, wordlist, Search + "*",IsLike );
                        }
                    }                    
                    toolTip1.SetToolTip((Control)webBrowser1, Search);
                    webBrowser1.Navigate("about:blank");
                    webBrowser1.Navigate(tempFile);
                    // webBrowser1.Refresh();
                }
                else
                {

                }
            }
            catch 
            {
                
            }
        }
        /// <summary>
        /// Loads database in to cache. Side effects observed are higher 
        /// loading time and higher RAM size and hence all 
        /// calls to this are now removed. 
        /// </summary>
        public void loadDatabase()
        {
            // This function is disabled due to obsolecence caused from this function
            /*
            if (!dbLoaded)
            {   
                Application.DoEvents();
                try
                {
                    // TODO: This line of code loads data into the 'dictDataSet.eng2te' table. You can move, or remove it, as needed.
                    this.eng2teTableAdapter.Fill(this.dictDataSet.eng2te);                    
                    // TODO: This line of code loads data into the 'te2enDataSet.Dict' table. You can move, or remove it, as needed.
                    this.dictTableAdapter.Fill(this.te2enDataSet.Dict);
                    dbLoaded = true;                    
                }
                catch
                {
                    MessageBox.Show("Error Loading database. Closing application",mbcaption , MessageBoxButtons.OK,MessageBoxIcon.Error );                    
                    Application.Exit();
                }
            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dbLoaded)
            {
                loadDatabase();
            }            
            if (txtQuery.Text.Length == 0)
            {
                sid = statusmsgids.startup;                
                return;
            }
            if (typingLang.Equals(lang.telugu))
                txtQuery.Text = ted.print_many_words(txtTelType.Text);
            try
            {
                SearchItem(sender, e, checkLanguage(txtQuery.Text));
                if (typingLang.Equals(lang.english))
                    txtQuery.Select();
                else
                    txtTelType.Select();
            }
            catch
            {                
                MessageBox.Show("Language other than telugu or english can't be processed", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuery.Text = "";
            }
        }       

        private void editDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new PWEntry()).Show();
        }
        
        #endregion

        #region System Tray Menu functions

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem1.Text == "Show")
            {
                Show();
                WindowState = FormWindowState.Normal;
                toolStripMenuItem1.Text = "Hide";
            }
            else
            {
                Hide();
                toolStripMenuItem1.Text = "Show";
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            if (toolStripMenuItem1.Text == "Show")
                toolStripMenuItem1.Text = "Hide";

        }

        private void teluguToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            displayLang = lang.telugu;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            displayLang = lang.english;
        }

        private void teluguToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            teluguToolStripMenuItem_Click(sender, e);
        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rw.btnPause_Click(sender, e);
            playToolStripMenuItem.Text = rw.GetBtnPauseTxt();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rw.btnStop_Click(sender, e);
            playToolStripMenuItem.Text = rw.GetBtnPauseTxt();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rw.alwaysOnTopToolStripMenuItem_Click(sender, e);
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
        }

        #endregion
        
        #region Result Display and other related functions

        public lang checkLanguage(string s)
        {
            lang langflag=lang.english ;
            int ecount = 0, tcount = 0,rcount=0;
            foreach (char c in s.ToCharArray())
            {
                if (c == ' ' || c=='.' || c==',')
                {
                    // Give the same weight for space character, period character and comma
                    // for both telugu and english languages
                    ecount++;
                    tcount++;
                    continue;
                }
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                    ecount++;
                else if (c >= 3072 && c <= 3199)
                    tcount++;
                else
                    rcount++;
            }
            if (rcount > 0)
            {
                langflag = lang.other;
                throw (new System.Exception(lang.other.ToString()));                 
            }
            if (ecount == s.Length)
                langflag = lang.english;
            if (tcount == s.Length)
                langflag = lang.telugu;
            
            return langflag;
        }
        /// <summary>
        /// Function to prepare HTML file for array of meanings and words
        /// </summary>
        /// <param name="htmlpath">HTML file path to store</param>
        /// <param name="marray">Array of meanings</param>
        /// <param name="warray">Array of words</param>
        /// <param name="searchQuery">Original query searched for</param>
        /// <param name="imposeUpperlimit">Flag to impose upper limit on number of meanings to display</param>
        /// <returns>Returns updated HTML path, If the given HTML path already exists and failed to create it. 
        /// An alternative path will be prepared and returned</returns>
        private string PrepareHtmlFile(string htmlpath, string[] marray, string[] warray,string searchQuery,bool imposeUpperlimit)
        {            
            StreamWriter sw;
            string s1, s2;
            try
            {
                sw = new StreamWriter(htmlpath);
            }
            catch
            {
                /*sw.Close();
                sw = new StreamWriter(tempFile);*/
                htmlpath = PrepareAlternateFileName(htmlpath);
                sw = new StreamWriter(htmlpath);
                //MessageBox.Show("Insufficient priveleges to display result", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            log.WriteLine(searchQuery + "\t" + System.IO.Path.GetFileName(htmlpath));
            log.Flush();
            sw.WriteLine("<html><meta http-equiv=\"Content-Type\" content=\"text/html;charset=utf-8\" />");
            sw.WriteLine("<title>" + warray[0] + "</title><body>");
            for(int i=0;i<warray.Length;i++)
            {
                s1 = marray[i];
                s2 = warray[i];                
                if (s2.Length != 0)
                    sw.WriteLine("<br /><b><u>" + s2 + " :</u></b><br />");
                {
                    // Case 1, replace all occurences of word in meaning with underlined
                    s1 = s1.Replace(s2, "<i><u>" + s2 + "</u></i>");
                    // Case 2, all occurences of word in the meaning are with *
                    s1 = s1.Replace("*", "<i><u>" + s2 + "</u></i>");                    
                    sw.WriteLine(s1);
                }
                sw.WriteLine("<br /><br /><br /><i><a href=mailto:pradeep@miriyala.in&subject=[TE2EN]0.4Beta_MeaningDisagree&body=Iam_using_TE2EN_0.4Beta_And_Found_the_following_word_with_wrong_meaning___" + s2 + ">Disagreed with meaning? send email to pradeep@miriyala.in</a> to improve quality in next release</i><br /><br />");
                if (imposeUpperlimit)
                    if (i > 10 && i < warray.Length)
                    {
                        sw.WriteLine("<br /><b>Displaying first ten words that match the given criteria</b><br />");
                        break;
                    }
            }
            sw.WriteLine("</body></html>");
            sw.Flush();
            sw.Close();
            return htmlpath;
        }

        /// <summary>
        /// Prepare HTML File prepares a HTML file that can be displayed in application
        /// </summary>
        /// <param name="htmlpath">HTML file path</param>
        /// <param name="s1">Meaning of word</param>
        /// <param name="s2">Word</param>
        /// <returns></returns>
        private string PrepareHtmlFile(string htmlpath, string s1,string s2)
        {
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(htmlpath );
            }
            catch 
            {
                /*sw.Close();
                sw = new StreamWriter(tempFile);*/
                htmlpath  = PrepareAlternateFileName(htmlpath );
                sw = new StreamWriter(htmlpath  );
                //MessageBox.Show("Insufficient priveleges to display result", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            log.WriteLine(s2 + "\t" + System.IO.Path.GetFileName(htmlpath));
            log.Flush();
            sw.WriteLine("<html><meta http-equiv=\"Content-Type\" content=\"text/html;charset=utf-8\" />");
            sw.WriteLine("<title>"+s2+"</title><body>");
            if (s2.Length != 0)
                sw.WriteLine("<b><u>" + s2 + " :</u></b><br />");
            if (string.IsNullOrEmpty(s1))
            {
                sw.Write("<i>Word Not found in database</i>");
                sw.WriteLine(s1);
                sw.WriteLine("<br /><br /><br /><i><a href=mailto:pradeep@miriyala.in&subject=[TE2EN]0.4Beta_MeaningDisagree&body=Iam_using_TE2EN_0.4Beta_And_Found_the_following_word_with_wrong_meaning___" + s2 + ">Want to suggest meaning? send email to pradeep@miriyala.in</a> to include this word in next release</i>");
            }
            else
            {
                // Case 1, replace all occurences of word in meaning with underlined
                s1 = s1.Replace(s2, "<i><u>" + s2 + "</u></i>");
                // Case 2, all occurences of word in the meaning are with *
                s1 = s1.Replace("*", "<i><u>"+s2+"</u></i>");
                sw.WriteLine(s1);
                sw.WriteLine("<br /><br /><br /><i><a href=mailto:pradeep@miriyala.in&subject=[TE2EN]0.4Beta_MeaningDisagree&body=Iam_using_TE2EN_0.4Beta_And_Found_the_following_word_with_wrong_meaning___" + s2 + ">Disagreed with meaning? send email to pradeep@miriyala.in</a> to improve quality in next release</i>");
            }            
            sw.WriteLine("</body></html>");
            sw.Flush();
            sw.Close();
            return htmlpath;
        }
        /// <summary>
        /// Prepare HTML File prepares a HTML file that can be displayed in application
        /// </summary>
        /// <param name="htmlpath">Path of the html file</param>
        /// <param name="s1">Meaning of word</param>
        private string  PrepareHtmlFile(string htmlpath, string s1)
        {
            return PrepareHtmlFile(htmlpath , s1, "");
        }

        private string PrepareAlternateFileName(string givenpath)
        {
            string preparedpath="" ;
            string ext = "";
            string getpath = "";
            int i = 0;
            string[] s=givenpath.Split(new char []{'.'});
            ext = s.GetValue(s.GetUpperBound(0)).ToString();
            getpath = givenpath.Substring(0, givenpath.Length - ext.Length-1);
            do
            {
                preparedpath = getpath + "_" + i.ToString() + "."+ext;
                if (System.IO.File.Exists(preparedpath))
                    i++;
                else 
                    break;
            } while (true );
            return preparedpath;
        }

        #endregion

        #region Random word region

        public  void randomWord_Tick(object sender, EventArgs e)
        {
            StateSelection ss = rw.ss;
            if (ss.Equals(StateSelection.Pause))
                return;
            if (ss.Equals(StateSelection.Stop))
            {
                rw.Close();
                randomWordTiming.Enabled = false ;
                return;
            }

            if (inxCntr < rnCntr && inxCntr>=1)
            {
                // Navigate inside history if the index is in acceptable limits.
                inxCntr++;
                randomCurrent(inxCntr);
                return;
            }

            rnCntr++;
            inxCntr++;

            rw_t = random_gen.Next(1, 19630);
            rw_e = random_gen.Next(1, 29730);

            randomCurrent(rw_e, rw_t);
        }

        private void randomCurrent(int inx)
        {
            tempRnFileTe = MyPath + TeRn + "_" + inx.ToString() + ext;
            tempRnFileEn = MyPath + EnRn + "_" + inx.ToString() + ext;
            // First navigate to blank page and then nvaigate to meaning page            
            rw.teDisplay.Navigate("about:blank");
            rw.teDisplay.Navigate(tempRnFileTe);
            //rw.teDisplay.Refresh();
            // First navigate to blank page and then nvaigate to meaning page
            rw.enDisplay.Navigate("about:blank");
            rw.enDisplay.Navigate(tempRnFileEn);
            //rw.enDisplay.Refresh();
        }

        private void randomCurrent(int rw_en, int rw_te)
        {
            string select;
            DataTable dt, dt2;

            tempRnFileTe = MyPath + TeRn + "_" + inxCntr.ToString() + ext;

            select = "select * from Dict where sn=" + rw_te.ToString();
            dt = ExecuteQuery(select, GetConnection(lang.telugu));
            dictBindingSource.DataSource = dt;
            tempRnFileTe = PrepareHtmlFile(tempRnFileTe, webBrowser1.Tag.ToString(), invRandomWord.Tag.ToString());

            tempRnFileEn = MyPath + EnRn + "_" + inxCntr.ToString() + ext;

            select = "select * from eng2te where sn=" + rw_en.ToString();
            dt2 = ExecuteQuery(select, GetConnection(lang.english));
            eng2teBindingSource.DataSource = dt2;
            tempRnFileEn = PrepareHtmlFile(tempRnFileEn, webBrowser1.AccessibleDescription, invRandomWord.Text);

            randomCurrent(inxCntr);
        }

        public void randomPrevious()
        {
            if (inxCntr >= 2)
            {
                inxCntr--;
                randomCurrent(inxCntr);
            }
        }

        public void randomNext()
        {
            if (inxCntr <= rnCntr-1)
            {
                inxCntr++;
                randomCurrent(inxCntr);
            }            
        }

        private void randomWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rnCntr == 0)
            {
                rnCntr = 0;
                inxCntr = 0;
            }
            double opacity;
            opacity=System.Convert.ToDouble( Microsoft.Win32.Registry.GetValue(regRoot, regKeys.RandomWordOpacity.ToString(), 1.00) );
            rw = new RandomWord();
            rw.changeLanguage(displayLang);
            rw.Opacity = opacity;
            rw.Show();

            randomwordMenuTray.Visible = true;
            randomWord_Tick(sender, e);
            randomWord.Enabled = true;
            randomWord.Start();
            randomWordTiming.Enabled = false;
        }

        /// <summary>
        /// Random word timing set function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomWordTiming_Click(object sender, EventArgs e)
        {
            string response = Microsoft.VisualBasic.Interaction.InputBox("Enter Random word timing in seconds", "Te 2 En Random word input", (randomWord.Interval / 1000).ToString(), this.Left, this.Top);
            if (response.Length == 0)
                return;
            int d;
            try
            {
                d = System.Convert.ToInt16(response);
                randomWord.Interval = d * 1000;
            }
            catch
            {
                MessageBox.Show("You must enter integer value to process", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startWithProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startWithProgramToolStripMenuItem.Checked = !startWithProgramToolStripMenuItem.Checked;
            Microsoft.Win32.Registry.SetValue(regRoot, regKeys.RandomOnStartup.ToString(), startWithProgramToolStripMenuItem.Checked ? 1 : 0);
        }

        private void opacityLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rw == null)
            {
                MessageBox.Show("Start random word to set opacity level", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string response = Microsoft.VisualBasic.Interaction.InputBox("Enter Opacity level in percentage", "Te 2 En Random word input", (rw.Opacity *100).ToString(), this.Left, this.Top);
            if (response.Length == 0)
                return;
            double  d;
            try
            {
                d = System.Convert.ToDouble(response);
                rw.Opacity = d/100;
                Microsoft.Win32.Registry.SetValue(regRoot, regKeys.RandomWordOpacity.ToString(), d);
            }
            catch
            {
                MessageBox.Show("You must enter double value to process", mbcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
        
        #region Help Menu

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAbout()).Show();
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        #endregion

        private void menuHistory_Click(object sender, EventArgs e)
        {
            if(fh==null)
                fh = new frmHistory();
            fh.changeLanguage(displayLang);
            fh.Show();
        }

        private void UpdateStatusMsgs(string msg)
        {
            toolStripStatusLabel1.Text = msg;
        }

        #region Typing language
        
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {            
            if (typingLang.Equals(lang.telugu))
                sid = statusmsgids.typeInTel;
            else
                sid = statusmsgids.typeInEng;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (typingLang.Equals(lang.telugu))            
                typingLang = lang.english;
            else if (typingLang.Equals(lang.english))
                typingLang = lang.telugu;            
        }

        private void txtTelType_TextChanged(object sender, EventArgs e)
        {
            if (txtTelType.Text.Length == 0)
                return;
            if (txtTelType.Text.Trim().Length == 0)
                return;
            txtQuery.Text = ted.print_many_words(txtTelType.Text);
        }

        private void teluguToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem2.Checked = teluguToolStripMenuItem2.Checked;
            teluguToolStripMenuItem2.Checked = !teluguToolStripMenuItem2.Checked;
            if (teluguToolStripMenuItem2.Checked)
                Microsoft.Win32.Registry.SetValue(regRoot, regKeys.DefaultTypingLang.ToString(), 0);
            else
                Microsoft.Win32.Registry.SetValue(regRoot, regKeys.DefaultTypingLang.ToString(), 1);
        }

        private void englishToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            teluguToolStripMenuItem2.Checked = englishToolStripMenuItem2.Checked;
            englishToolStripMenuItem2.Checked = !englishToolStripMenuItem2.Checked;
            if (englishToolStripMenuItem2.Checked)
                Microsoft.Win32.Registry.SetValue(regRoot, regKeys.DefaultTypingLang.ToString(), 1);
            else
                Microsoft.Win32.Registry.SetValue(regRoot, regKeys.DefaultTypingLang.ToString(), 0);
        }

        #endregion        

        private void teluguWriterToolStripMenuItem_Click(object sender, EventArgs e)
        {                
            try
            {
                tw.Show();
            }
            catch
            {
                tw = new frmTeWriter();
                tw.Show();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            teluguWriterToolStripMenuItem_Click(sender, e);
        }
    }

    public class teData
    {
        public string vowels = @"(A(O)?)|(a((a)|(i)|(e)|(u))?)|(E)|(I)|(H)|(TR)|(M)|(O)|(tR)|(i)|(U)|(o((a)|(o))?)|(e(e)?)|(u)|(\\:)";
        public string consonants = @"(ch)|(r)|(b(h)?)|(B(h)?)|(D(h)?)|(G)|(K(h)?)|(J(h)?)|(L)|(N)|(R)|(T(h)?)|(Ch)|(d(h)?)|(g(h)?)|(h)|(k(h)?)|(j(h)?)|(m)|(l)|(n(Y)?)|(p(h)?)|(s(h)?)|(Sh)|(t(h)?)|(v)|(y)";
        Dictionary<string, string> lettercodes;
        public teData()
        {
            lettercodes = new Dictionary<string, string>();
            lettercodes.Clear();            
            lettercodes.Add("~a", "&#3077;");            
            lettercodes.Add("~aa", "&#3078;");
            lettercodes.Add("~A", "&#3078;");
            lettercodes.Add("~i", "&#3079;");
            lettercodes.Add("~ee", "&#3080;");
            lettercodes.Add("~I", "&#3080;");
            lettercodes.Add("~u", "&#3081;");
            lettercodes.Add("~oo", "&#3082;");
            lettercodes.Add("~U", "&#3082;");
            lettercodes.Add("~e", "&#3086;");
            lettercodes.Add("~ae", "&#3087;");
            lettercodes.Add("~E", "&#3087;");
            lettercodes.Add("~ai", "&#3088;");
            lettercodes.Add("~o", "&#3090;");
            lettercodes.Add("~oa", "&#3091;");
            lettercodes.Add("~O", "&#3091;");
            lettercodes.Add("~au", "&#3092;");
            lettercodes.Add("~tR", "&#3083;");
            lettercodes.Add("~TR", "&#3168;");
            lettercodes.Add("~AO", "&#3073;");//chandrabindu
            lettercodes.Add("~M", "&#3074;"); //anusvara
            lettercodes.Add("~H", "&#3075;");//visarga    
            
            lettercodes.Add("a", "");
            lettercodes.Add("*", "&#3149;");
            lettercodes.Add("aa", "&#3134;");
            lettercodes.Add("A", "&#3134;");
            lettercodes.Add("i", "&#3135;");
            lettercodes.Add("ee", "&#3136;");
            lettercodes.Add("I", "&#3136;");
            lettercodes.Add("u", "&#3137;");
            lettercodes.Add("oo", "&#3138;");
            lettercodes.Add("U", "&#3138;");
            // lettercodes.Add("O", "&#3138;"); // Removing uu for capital O. assigning capital O to oo.
            lettercodes.Add("e", "&#3142;");
            lettercodes.Add("ae", "&#3143;");
            lettercodes.Add("E", "&#3143;");
            lettercodes.Add("ai", "&#3144;");
            lettercodes.Add("o", "&#3146;");
            lettercodes.Add("oa", "&#3147;");
            lettercodes.Add("O", "&#3147;");
            lettercodes.Add("au", "&#3148;");
            lettercodes.Add("tR", "&#3139;");
            lettercodes.Add("TR", "&#3140;");
            lettercodes.Add("AO", "&#3073;"); //chandrabindu
            lettercodes.Add("M", "&#3074;");  //anusvara
            lettercodes.Add("H", "&#3075;"); //visarga
            lettercodes.Add("k", "&#3093;");
            lettercodes.Add("K", "&#3093;");
            lettercodes.Add("kh", "&#3094;");
            lettercodes.Add("Kh", "&#3094;");
            lettercodes.Add("g", "&#3095;");
            lettercodes.Add("gh", "&#3096;");
            lettercodes.Add("G", "&#3097;");
            lettercodes.Add("ch", "&#3098;");
            lettercodes.Add("Ch", "&#3099;");
            lettercodes.Add("j", "&#3100;");
            lettercodes.Add("jh", "&#3101;");
            lettercodes.Add("J", "&#3101;");
            lettercodes.Add("Jh", "&#3101;");
            lettercodes.Add("nY", "&#3102;");
            lettercodes.Add("t", "&#3103;");
            lettercodes.Add("T", "&#3104;");
            lettercodes.Add("d", "&#3105;");
            lettercodes.Add("D", "&#3106;");
            lettercodes.Add("N", "&#3107;");
            lettercodes.Add("th", "&#3108;");
            lettercodes.Add("Th", "&#3109;");
            lettercodes.Add("dh", "&#3110;");
            lettercodes.Add("Dh", "&#3111;");
            lettercodes.Add("n", "&#3112;");
            lettercodes.Add("p", "&#3114;");
            lettercodes.Add("ph", "&#3115;");
            lettercodes.Add("b", "&#3116;");
            lettercodes.Add("B", "&#3117;");
            lettercodes.Add("bh", "&#3117;");
            lettercodes.Add("Bh", "&#3117;");
            lettercodes.Add("m", "&#3118;");
            lettercodes.Add("y", "&#3119;");
            lettercodes.Add("r", "&#3120;");
            lettercodes.Add("R", "&#3121;");
            lettercodes.Add("l", "&#3122;");
            lettercodes.Add("L", "&#3123;");
            lettercodes.Add("v", "&#3125;");
            lettercodes.Add("sh", "&#3126;");
            lettercodes.Add("Sh", "&#3127;");
            lettercodes.Add("s", "&#3128;");
            lettercodes.Add("h", "&#3129;");
        }
        
        public List<string> split_word(string word) 
        {
            List<string> syllables=new List<string>() ;
            syllables.Clear();
            // string[] syllables="";
            bool vowel_start_p = true;

            Regex re;
            
            Match inx,matched,nxt;
            int index,next;
            
            while (word.Length!=0) 
            {   
                re = new Regex(vowels);                
                inx = re.Match(word );
                index = inx.Index;
                if (index==0 && inx.Success  ) 
                {
                    //the vowel's at the start of word                    
                    matched = re.Matches(word)[0]; //what is it?                    
                    if (vowel_start_p) 
                    {
                        //one more to the syllables   
                        syllables.Add(("~" + matched.ToString()));
                    }
                    else 
                    {
                        syllables.Add(matched.ToString());
                    }
                    vowel_start_p = true;
                    word = word.Substring(matched.Length );
                }
                else 
                {
                    re = new Regex(consonants);                    
                    inx = re.Match(word);
                    index = inx.Index;
                    if (index==0 && inx.Success ) 
                    {
                        matched = re.Matches (word)[0];
                        syllables.Add( matched.ToString());                        
                        vowel_start_p = false;
                        word = word.Substring(matched.Length);
                        re = new Regex(vowels);
                        //look ahead for virama setting                        
                        nxt = re.Match(word);
                        next = nxt.Index;                        
                        if (next != 0 || word.Length == 0)                            
                            syllables.Add("*");
                    }
                    else 
                    {
                        syllables.Add( word.Substring(0, 1));                        
                        word = word.Substring(1);
                    }
                }
            }    
            return syllables;
        }

        public string  match_code(string syllable_mcc) 
        {
            try
            {
                object matched = lettercodes[syllable_mcc];
                return matched.ToString();
            }
            catch
            {
                return syllable_mcc;
            }
        }

        public string one_word(string word_ow) 
        {
            if (word_ow.Length==0)
                return "";
            List<string>  syllables_ow = split_word(word_ow);            
            string letters_ow="";
            
            for (int i_ow = 0; i_ow < syllables_ow.Count  ; i_ow++) 
            {
                letters_ow=letters_ow+match_code(syllables_ow[i_ow]);
            }
            return letters_ow;
        }
        
        public string  many_words(string sentence) 
        {

            string  regex = "((" + vowels + ")|(" + consonants + "))+";
            Regex re;
            string words="";
            Match   match;
            
            while (sentence.Length >= 1) 
            {
                re = new Regex(Regex.Escape(("^``" + regex)));
                match = re.Match(sentence);
                //match = Regex.Match(sentence, Regex.Escape(("^``" + regex)));
                
                if (match.Success )
                {
                    // match = match[0];
                    words=words+"`";
                    words=words+one_word(match.Value);
                    sentence = sentence.Substring(match.Length);
                }
                else 
                {
                    re = new Regex("^`" + regex);
                    match = re.Match (sentence);
                    if (match.Success ) 
                    {                        
                        words=words+match.Value.Substring(1);
                        // words.push(match.substring(1));
                        sentence = sentence.Substring(match.Length);
                    }
                    else 
                    {
                        re = new Regex("^" + regex);
                        match = re.Match (sentence);
                        if (match.Success ) 
                        {                            
                            words=words+one_word(match.ToString());                            
                            sentence = sentence.Substring(match.Length);
                        }
                        else 
                        {
                            words=words+sentence.Substring(0,1);                            
                            sentence = sentence.Substring(1);
                        }
                    }
                }
            }
            return words;
        }
        
        public string  print_many_words(string text_pmw) 
        {
            text_pmw = many_words(text_pmw );
            string  ans = "";
            string mainans = "";
            Regex re;
            string  unicode_chars = @"/&#[0-9]+;/";
            Match matche,search;

            while (text_pmw.Length!=0 ) 
            {   
                re =new Regex(unicode_chars);                
                matche = re.Match (text_pmw);
                if (matche.Success  )
                {
                    search = re.Match(text_pmw);                    
                    ans += text_pmw.Substring (0, search.Index );
                    
                    re = new Regex(@"/[0-9]+/");
                    ans += re.Match(matche.Value.Substring(0)).Value.Substring(0);

                    text_pmw = text_pmw.Substring(search.Index + matche.Length);
                }
                else 
                {
                    ans += text_pmw.Substring(0);
                    text_pmw = "";
                }
            }
            string[] anssplit = ans.Split(new char[]{';'});
            foreach (string x in anssplit)
            {
                if (x.Length == 0)
                    break ;
                try
                {
                    if (x.TrimStart(new char[] { ' ' }).Length != x.Length)
                        for(int i=0;i<x.Length-x.TrimStart(new char[] { ' ' }).Length;i++)
                            mainans += " ";                    
                    mainans += Char.ToString((char)Int32.Parse(x.Replace("&#", "").Replace(";", "")));
                }
                catch
                {
                    // Exception can raise because, parser unable to parse the 
                    // given value. And this is because there are some ascii chars. Grab them
                    string[] xsplit = x.Split(new string[] { "&#" },StringSplitOptions.None );
                    foreach (string y in xsplit)
                    {
                        try
                        {
                            if (y.TrimStart(new char[] { ' ' }).Length != y.Length)
                                for (int i = 0; i < y.Length - y.TrimStart(new char[] { ' ' }).Length; i++)
                                    mainans += " ";
                            mainans += Char.ToString((char)Int32.Parse(y.Replace("&#", "").Replace(";", "")));
                        }
                        catch
                        {
                            mainans += y;
                        }
                    }
                    
                }
            }
            return mainans;
        }
    }

}