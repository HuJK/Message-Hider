namespace Message_Hider
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDeep = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.beforeR = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.afterR = new System.Windows.Forms.DomainUpDown();
            this.layout = new System.Windows.Forms.DomainUpDown();
            this.timing = new System.Windows.Forms.CheckBox();
            this.Fastmode = new System.Windows.Forms.CheckBox();
            this.savelabel = new System.Windows.Forms.Label();
            this.continuous = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color change extent";
            // 
            // ColorDeep
            // 
            this.ColorDeep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorDeep.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ColorDeep.FormattingEnabled = true;
            this.ColorDeep.Items.AddRange(new object[] {
            "2",
            "4",
            "16",
            "256"});
            this.ColorDeep.Location = new System.Drawing.Point(12, 38);
            this.ColorDeep.Name = "ColorDeep";
            this.ColorDeep.Size = new System.Drawing.Size(233, 32);
            this.ColorDeep.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(113, 99);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 32);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cencal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(182, 99);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(63, 32);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // beforeR
            // 
            this.beforeR.Location = new System.Drawing.Point(77, 71);
            this.beforeR.Name = "beforeR";
            this.beforeR.Size = new System.Drawing.Size(37, 22);
            this.beforeR.TabIndex = 5;
            this.beforeR.Text = "0";
            this.beforeR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delate R/W";
            this.label2.Visible = false;
            // 
            // afterR
            // 
            this.afterR.Location = new System.Drawing.Point(120, 71);
            this.afterR.Name = "afterR";
            this.afterR.Size = new System.Drawing.Size(37, 22);
            this.afterR.TabIndex = 7;
            this.afterR.Text = "0";
            this.afterR.Visible = false;
            // 
            // layout
            // 
            this.layout.Location = new System.Drawing.Point(163, 71);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(37, 22);
            this.layout.TabIndex = 8;
            this.layout.Text = "0";
            this.layout.Visible = false;
            // 
            // timing
            // 
            this.timing.AutoSize = true;
            this.timing.Checked = global::Message_Hider.Properties.Settings.Default.saveTiming;
            this.timing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Message_Hider.Properties.Settings.Default, "saveTiming", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.timing.Location = new System.Drawing.Point(12, 115);
            this.timing.Name = "timing";
            this.timing.Size = new System.Drawing.Size(58, 16);
            this.timing.TabIndex = 10;
            this.timing.Text = "Timing";
            this.timing.UseVisualStyleBackColor = true;
            // 
            // Fastmode
            // 
            this.Fastmode.AutoSize = true;
            this.Fastmode.Checked = global::Message_Hider.Properties.Settings.Default.saveFastmode;
            this.Fastmode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Message_Hider.Properties.Settings.Default, "saveFastmode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Fastmode.Location = new System.Drawing.Point(12, 99);
            this.Fastmode.Name = "Fastmode";
            this.Fastmode.Size = new System.Drawing.Size(72, 16);
            this.Fastmode.TabIndex = 9;
            this.Fastmode.Text = "Fast Mode";
            this.Fastmode.UseVisualStyleBackColor = true;
            this.Fastmode.CheckedChanged += new System.EventHandler(this.Fastmode_CheckedChanged);
            // 
            // savelabel
            // 
            this.savelabel.AutoSize = true;
            this.savelabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Message_Hider.Properties.Settings.Default, "saveColorDeep", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.savelabel.Location = new System.Drawing.Point(32, 191);
            this.savelabel.Name = "savelabel";
            this.savelabel.Size = new System.Drawing.Size(11, 12);
            this.savelabel.TabIndex = 4;
            this.savelabel.Text = global::Message_Hider.Properties.Settings.Default.saveColorDeep;
            // 
            // continuous
            // 
            this.continuous.Location = new System.Drawing.Point(206, 71);
            this.continuous.Name = "continuous";
            this.continuous.Size = new System.Drawing.Size(37, 22);
            this.continuous.TabIndex = 11;
            this.continuous.Text = "0";
            this.continuous.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 138);
            this.Controls.Add(this.continuous);
            this.Controls.Add(this.timing);
            this.Controls.Add(this.Fastmode);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.afterR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beforeR);
            this.Controls.Add(this.savelabel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ColorDeep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ColorDeep;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label savelabel;
        private System.Windows.Forms.DomainUpDown beforeR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown afterR;
        private System.Windows.Forms.DomainUpDown layout;
        private System.Windows.Forms.CheckBox Fastmode;
        private System.Windows.Forms.CheckBox timing;
        private System.Windows.Forms.DomainUpDown continuous;
    }
}