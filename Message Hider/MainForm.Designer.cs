namespace Message_Hider
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectfile = new System.Windows.Forms.Button();
            this.picpath = new System.Windows.Forms.TextBox();
            this.thepicture = new System.Windows.Forms.PictureBox();
            this.totext = new System.Windows.Forms.Button();
            this.topic = new System.Windows.Forms.Button();
            this.thetext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.toolsToolStripMenuItem.Text = "Settings";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectfile
            // 
            this.selectfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectfile.Location = new System.Drawing.Point(445, 27);
            this.selectfile.Name = "selectfile";
            this.selectfile.Size = new System.Drawing.Size(27, 20);
            this.selectfile.TabIndex = 1;
            this.selectfile.Text = "...";
            this.selectfile.UseVisualStyleBackColor = true;
            this.selectfile.Click += new System.EventHandler(this.selectfile_Click);
            // 
            // picpath
            // 
            this.picpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picpath.Location = new System.Drawing.Point(12, 27);
            this.picpath.Name = "picpath";
            this.picpath.Size = new System.Drawing.Size(427, 22);
            this.picpath.TabIndex = 2;
            this.picpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.picpath_KeyDown);
            // 
            // thepicture
            // 
            this.thepicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thepicture.Location = new System.Drawing.Point(12, 57);
            this.thepicture.Name = "thepicture";
            this.thepicture.Size = new System.Drawing.Size(200, 194);
            this.thepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thepicture.TabIndex = 3;
            this.thepicture.TabStop = false;
            // 
            // totext
            // 
            this.totext.Location = new System.Drawing.Point(218, 55);
            this.totext.Name = "totext";
            this.totext.Size = new System.Drawing.Size(50, 94);
            this.totext.TabIndex = 4;
            this.totext.Text = "-->";
            this.totext.UseVisualStyleBackColor = true;
            this.totext.Click += new System.EventHandler(this.totext_Click);
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(218, 155);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(50, 94);
            this.topic.TabIndex = 5;
            this.topic.Text = "<--";
            this.topic.UseVisualStyleBackColor = true;
            this.topic.Click += new System.EventHandler(this.topic_Click);
            // 
            // thetext
            // 
            this.thetext.Location = new System.Drawing.Point(274, 55);
            this.thetext.Multiline = true;
            this.thetext.Name = "thetext";
            this.thetext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.thetext.Size = new System.Drawing.Size(200, 182);
            this.thetext.TabIndex = 6;
            this.thetext.WordWrap = false;
            this.thetext.TextChanged += new System.EventHandler(this.thetext_TextChanged);
            this.thetext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thetext_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Characters remain:";
            // 
            // textnumber
            // 
            this.textnumber.AutoSize = true;
            this.textnumber.Location = new System.Drawing.Point(372, 240);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(11, 12);
            this.textnumber.TabIndex = 8;
            this.textnumber.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "                  ";
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "無損壓縮圖檔(*.bmp*.png)|*.bmp;*.png|所有檔案 (*.*)|*.*";
            this.openFileDlg.SupportMultiDottedExtensions = true;
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "bmp";
            this.sfd.Filter = "無損壓縮圖檔(*.bmp*.png)|*.bmp;*.png|所有檔案 (*.*)|*.*";
            this.sfd.SupportMultiDottedExtensions = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thetext);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.totext);
            this.Controls.Add(this.thepicture);
            this.Controls.Add(this.picpath);
            this.Controls.Add(this.selectfile);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(180, 150);
            this.Name = "MainForm";
            this.Text = "Message Hider";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button selectfile;
        private System.Windows.Forms.TextBox picpath;
        private System.Windows.Forms.PictureBox thepicture;
        private System.Windows.Forms.Button totext;
        private System.Windows.Forms.Button topic;
        private System.Windows.Forms.TextBox thetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

