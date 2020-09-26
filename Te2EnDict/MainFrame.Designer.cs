namespace Te2EnDict
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryDataSet = new Te2EnDict.DictionaryDataSet();
            this.eng2teBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelType = new System.Windows.Forms.TextBox();
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.teluguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomwordMenuTray = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invRandomWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exactMatch = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.randomWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeinTelugu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomWordTiming = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.teluguToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTypingLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teluguToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.teluguWriterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomWord = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.eng2teTableAdapter1 = new Te2EnDict.DictionaryDataSetTableAdapters.eng2teTableAdapter();
            this.dictTableAdapter1 = new Te2EnDict.DictionaryDataSetTableAdapters.DictTableAdapter();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eng2teBindingSource)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuery.Font = new System.Drawing.Font("Gautami", 10F);
            this.txtQuery.Location = new System.Drawing.Point(216, 28);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(237, 33);
            this.txtQuery.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtQuery, "తెలుగు పదాన్ని ఇక్కడ ఇవ్వండి");
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Gautami", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(610, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "వెతుకు";
            this.toolTip1.SetToolTip(this.btnSearch, "ఇక్కడ వొత్తండి");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "తెలుగు ఆంగ్లం నిఘంటువు";
            // 
            // webBrowser1
            // 
            this.webBrowser1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dictBindingSource, "val", true));
            this.webBrowser1.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.eng2teBindingSource, "meaning", true));
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(13, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(690, 496);
            this.webBrowser1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.webBrowser1, "అర్ధము");
            // 
            // dictBindingSource
            // 
            this.dictBindingSource.DataMember = "Dict";
            this.dictBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eng2teBindingSource
            // 
            this.eng2teBindingSource.DataMember = "eng2te";
            this.eng2teBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gautami", 9F);
            this.textBox1.Location = new System.Drawing.Point(4, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 30);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "తెలుగు పదాన్ని ఇక్కడ ఇవ్వండి");
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(13, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.ScriptErrorsSuppressed = true;
            this.webBrowser4.Size = new System.Drawing.Size(683, 321);
            this.webBrowser4.TabIndex = 3;
            this.toolTip1.SetToolTip(this.webBrowser4, "అర్ధము");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gautami", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "వెతుకు";
            this.toolTip1.SetToolTip(this.button1, "ఇక్కడ వొత్తండి");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTelType
            // 
            this.txtTelType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelType.Font = new System.Drawing.Font("Gautami", 10F);
            this.txtTelType.Location = new System.Drawing.Point(3, 28);
            this.txtTelType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelType.Name = "txtTelType";
            this.txtTelType.Size = new System.Drawing.Size(209, 33);
            this.txtTelType.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtTelType, "తెలుగు పదాన్ని ఇక్కడ ఇవ్వండి");
            this.txtTelType.TextChanged += new System.EventHandler(this.txtTelType_TextChanged);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.randomwordMenuTray,
            this.toolStripMenuItem7,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.trayMenu.ShowCheckMargin = true;
            this.trayMenu.ShowImageMargin = false;
            this.trayMenu.Size = new System.Drawing.Size(153, 142);
            this.trayMenu.Text = "Tray Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teluguToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Interface";
            // 
            // teluguToolStripMenuItem
            // 
            this.teluguToolStripMenuItem.Name = "teluguToolStripMenuItem";
            this.teluguToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.teluguToolStripMenuItem.Text = "Telugu";
            this.teluguToolStripMenuItem.Click += new System.EventHandler(this.teluguToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // randomwordMenuTray
            // 
            this.randomwordMenuTray.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem});
            this.randomwordMenuTray.Name = "randomwordMenuTray";
            this.randomwordMenuTray.Size = new System.Drawing.Size(152, 22);
            this.randomwordMenuTray.Text = "Random Word";
            this.randomwordMenuTray.Visible = false;
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.playToolStripMenuItem.Text = "Pause";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Hide";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // invRandomWord
            // 
            this.invRandomWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.invRandomWord.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dictBindingSource, "name", true));
            this.invRandomWord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eng2teBindingSource, "eng_word", true));
            this.invRandomWord.Font = new System.Drawing.Font("Gautami", 8F);
            this.invRandomWord.Location = new System.Drawing.Point(393, 29);
            this.invRandomWord.Name = "invRandomWord";
            this.invRandomWord.Size = new System.Drawing.Size(31, 28);
            this.invRandomWord.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 498);
            this.panel1.TabIndex = 7;
            // 
            // exactMatch
            // 
            this.exactMatch.Font = new System.Drawing.Font("Gautami", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactMatch.Location = new System.Drawing.Point(459, 28);
            this.exactMatch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exactMatch.Name = "exactMatch";
            this.exactMatch.Size = new System.Drawing.Size(147, 33);
            this.exactMatch.TabIndex = 1;
            this.exactMatch.Text = "ఖచ్చితంగా సరిచూడు";
            this.exactMatch.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Telugu English Dictionary";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomWordToolStripMenuItem,
            this.typeinTelugu,
            this.menuHistory,
            this.exitToolStripMenuItem1});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem4.Text = "&Dictionary";
            // 
            // randomWordToolStripMenuItem
            // 
            this.randomWordToolStripMenuItem.Name = "randomWordToolStripMenuItem";
            this.randomWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomWordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.randomWordToolStripMenuItem.Text = "Random Word";
            this.randomWordToolStripMenuItem.Click += new System.EventHandler(this.randomWordToolStripMenuItem_Click);
            // 
            // typeinTelugu
            // 
            this.typeinTelugu.Checked = true;
            this.typeinTelugu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeinTelugu.Name = "typeinTelugu";
            this.typeinTelugu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.typeinTelugu.Size = new System.Drawing.Size(181, 22);
            this.typeinTelugu.Text = "Type in Telugu";
            this.typeinTelugu.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // menuHistory
            // 
            this.menuHistory.Name = "menuHistory";
            this.menuHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuHistory.Size = new System.Drawing.Size(181, 22);
            this.menuHistory.Text = "&History";
            this.menuHistory.Click += new System.EventHandler(this.menuHistory_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDictionaryToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.defaultTypingLanguageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // editDictionaryToolStripMenuItem
            // 
            this.editDictionaryToolStripMenuItem.Name = "editDictionaryToolStripMenuItem";
            this.editDictionaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.D)));
            this.editDictionaryToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.editDictionaryToolStripMenuItem.Text = "Edit Custom &Dictionary";
            this.editDictionaryToolStripMenuItem.Visible = false;
            this.editDictionaryToolStripMenuItem.Click += new System.EventHandler(this.editDictionaryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacityLevelToolStripMenuItem,
            this.randomWordTiming,
            this.startWithProgramToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(242, 22);
            this.toolStripMenuItem5.Text = "Random Word";
            // 
            // opacityLevelToolStripMenuItem
            // 
            this.opacityLevelToolStripMenuItem.Name = "opacityLevelToolStripMenuItem";
            this.opacityLevelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.opacityLevelToolStripMenuItem.Text = "Opacity Level";
            this.opacityLevelToolStripMenuItem.Click += new System.EventHandler(this.opacityLevelToolStripMenuItem_Click);
            // 
            // randomWordTiming
            // 
            this.randomWordTiming.Name = "randomWordTiming";
            this.randomWordTiming.Size = new System.Drawing.Size(175, 22);
            this.randomWordTiming.Text = "Random Word Timing";
            this.randomWordTiming.Click += new System.EventHandler(this.randomWordTiming_Click);
            // 
            // startWithProgramToolStripMenuItem
            // 
            this.startWithProgramToolStripMenuItem.Name = "startWithProgramToolStripMenuItem";
            this.startWithProgramToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.startWithProgramToolStripMenuItem.Text = "Start with Program";
            this.startWithProgramToolStripMenuItem.Click += new System.EventHandler(this.startWithProgramToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teluguToolStripMenuItem1,
            this.englishToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(242, 22);
            this.toolStripMenuItem3.Text = "Interface";
            // 
            // teluguToolStripMenuItem1
            // 
            this.teluguToolStripMenuItem1.Name = "teluguToolStripMenuItem1";
            this.teluguToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.teluguToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.teluguToolStripMenuItem1.Text = "Telugu";
            this.teluguToolStripMenuItem1.Click += new System.EventHandler(this.teluguToolStripMenuItem1_Click);
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click);
            // 
            // defaultTypingLanguageToolStripMenuItem
            // 
            this.defaultTypingLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teluguToolStripMenuItem2,
            this.englishToolStripMenuItem2});
            this.defaultTypingLanguageToolStripMenuItem.Name = "defaultTypingLanguageToolStripMenuItem";
            this.defaultTypingLanguageToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.defaultTypingLanguageToolStripMenuItem.Text = "Default Typing Language";
            // 
            // teluguToolStripMenuItem2
            // 
            this.teluguToolStripMenuItem2.Name = "teluguToolStripMenuItem2";
            this.teluguToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.teluguToolStripMenuItem2.Text = "Telugu";
            this.teluguToolStripMenuItem2.Click += new System.EventHandler(this.teluguToolStripMenuItem2_Click);
            // 
            // englishToolStripMenuItem2
            // 
            this.englishToolStripMenuItem2.Name = "englishToolStripMenuItem2";
            this.englishToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.englishToolStripMenuItem2.Text = "English";
            this.englishToolStripMenuItem2.Click += new System.EventHandler(this.englishToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teluguWriterToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem6.Text = "&Tools";
            // 
            // teluguWriterToolStripMenuItem
            // 
            this.teluguWriterToolStripMenuItem.Name = "teluguWriterToolStripMenuItem";
            this.teluguWriterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.teluguWriterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.teluguWriterToolStripMenuItem.Text = "Telugu Writer";
            this.teluguWriterToolStripMenuItem.Click += new System.EventHandler(this.teluguWriterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // randomWord
            // 
            this.randomWord.Interval = 3000;
            this.randomWord.Tick += new System.EventHandler(this.randomWord_Tick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "help\\Te2EnDict.chm";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.Font = new System.Drawing.Font("Gautami", 8F);
            this.textBox2.Location = new System.Drawing.Point(394, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 28);
            this.textBox2.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.webBrowser4);
            this.panel2.Location = new System.Drawing.Point(4, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 323);
            this.panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Gautami", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(453, 3);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 28);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ఖచ్చితంగా సరిచూడు";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // eng2teTableAdapter1
            // 
            this.eng2teTableAdapter1.ClearBeforeFill = true;
            // 
            // dictTableAdapter1
            // 
            this.dictTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "Telugu Writer";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // MainFrame
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 585);
            this.Controls.Add(this.txtTelType);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.exactMatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.invRandomWord);
            this.Font = new System.Drawing.Font("Gautami", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.helpProvider1.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "తెలుగు - ఆంగ్లం నిఘంటువు ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eng2teBindingSource)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox exactMatch;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem teluguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem teluguToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.Timer randomWord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem randomWordToolStripMenuItem;
        private System.Windows.Forms.TextBox invRandomWord;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomwordMenuTray;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHistory;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem opacityLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWithProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomWordTiming;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private DictionaryDataSet dictionaryDataSet;        
        private Te2EnDict.DictionaryDataSetTableAdapters.eng2teTableAdapter  eng2teTableAdapter1;
        private Te2EnDict.DictionaryDataSetTableAdapters.DictTableAdapter  dictTableAdapter1;
        private System.Windows.Forms.BindingSource dictBindingSource;
        private System.Windows.Forms.BindingSource eng2teBindingSource;
        private System.Windows.Forms.ToolStripMenuItem typeinTelugu;
        private System.Windows.Forms.TextBox txtTelType;
        private System.Windows.Forms.ToolStripMenuItem defaultTypingLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teluguToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem teluguWriterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;        
        
    }
}

