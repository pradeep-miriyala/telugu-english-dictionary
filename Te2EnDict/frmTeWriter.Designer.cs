namespace Te2EnDict
{
    partial class frmTeWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeWriter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRts = new System.Windows.Forms.TextBox();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtRts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUni, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtRts
            // 
            this.txtRts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRts.Font = new System.Drawing.Font("Gautami", 12F);
            this.txtRts.Location = new System.Drawing.Point(3, 3);
            this.txtRts.Multiline = true;
            this.txtRts.Name = "txtRts";
            this.txtRts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRts.Size = new System.Drawing.Size(549, 176);
            this.txtRts.TabIndex = 0;
            this.txtRts.TextChanged += new System.EventHandler(this.txtRts_TextChanged);
            // 
            // txtUni
            // 
            this.txtUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUni.Cursor = System.Windows.Forms.Cursors.No;
            this.txtUni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUni.Font = new System.Drawing.Font("Gautami", 12F);
            this.txtUni.Location = new System.Drawing.Point(3, 185);
            this.txtUni.Multiline = true;
            this.txtUni.Name = "txtUni";
            this.txtUni.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUni.Size = new System.Drawing.Size(549, 176);
            this.txtUni.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCopy.Location = new System.Drawing.Point(195, 367);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(164, 36);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmTeWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTeWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telugu Writer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtRts;
        private System.Windows.Forms.Button btnCopy;
    }
}