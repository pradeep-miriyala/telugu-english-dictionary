namespace Te2EnDict
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeFolderList = new System.Windows.Forms.TreeView();
            this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstWordlist = new System.Windows.Forms.ListBox();
            this.brwDisplay = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEntireHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.treeContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.62963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.37037F));
            this.tableLayoutPanel1.Controls.Add(this.treeFolderList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstWordlist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.brwDisplay, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.89908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.10092F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeFolderList
            // 
            this.treeFolderList.ContextMenuStrip = this.treeContextMenu;
            this.treeFolderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFolderList.Font = new System.Drawing.Font("Gautami", 9.75F);
            this.treeFolderList.Location = new System.Drawing.Point(3, 5);
            this.treeFolderList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.treeFolderList.Name = "treeFolderList";
            this.tableLayoutPanel1.SetRowSpan(this.treeFolderList, 2);
            this.treeFolderList.ShowLines = false;
            this.treeFolderList.ShowRootLines = false;
            this.treeFolderList.Size = new System.Drawing.Size(181, 535);
            this.treeFolderList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.treeFolderList, "Select the date and time for the history element");
            this.treeFolderList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolderList_AfterSelect);
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.treeContextMenu.Name = "treeContextMenu";
            this.treeContextMenu.Size = new System.Drawing.Size(128, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lstWordlist
            // 
            this.lstWordlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWordlist.Font = new System.Drawing.Font("Gautami", 12F);
            this.lstWordlist.FormattingEnabled = true;
            this.lstWordlist.ItemHeight = 28;
            this.lstWordlist.Location = new System.Drawing.Point(190, 5);
            this.lstWordlist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lstWordlist.Name = "lstWordlist";
            this.lstWordlist.Size = new System.Drawing.Size(537, 200);
            this.lstWordlist.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstWordlist, "List of words searched or used for random display");
            this.lstWordlist.SelectedIndexChanged += new System.EventHandler(this.lstWordlist_SelectedIndexChanged);
            // 
            // brwDisplay
            // 
            this.brwDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brwDisplay.IsWebBrowserContextMenuEnabled = false;
            this.brwDisplay.Location = new System.Drawing.Point(190, 216);
            this.brwDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.brwDisplay.MinimumSize = new System.Drawing.Size(20, 32);
            this.brwDisplay.Name = "brwDisplay";
            this.brwDisplay.Size = new System.Drawing.Size(537, 324);
            this.brwDisplay.TabIndex = 2;
            this.toolTip1.SetToolTip(this.brwDisplay, "Meaning of the selected word");
            this.brwDisplay.WebBrowserShortcutsEnabled = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Telugu English Dictionary";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearEntireHistoryToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // clearEntireHistoryToolStripMenuItem
            // 
            this.clearEntireHistoryToolStripMenuItem.Name = "clearEntireHistoryToolStripMenuItem";
            this.clearEntireHistoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.clearEntireHistoryToolStripMenuItem.Text = "&Clear Entire History";
            this.clearEntireHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearEntireHistoryToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeToolStripMenuItem.Text = "Clos&e";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 574);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Gautami", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frmHistory";
            this.Text = "చరిత్ర";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.treeContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeFolderList;
        private System.Windows.Forms.ListBox lstWordlist;
        private System.Windows.Forms.WebBrowser brwDisplay;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearEntireHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}