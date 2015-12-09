namespace Message_Hider
{
    partial class ProgressBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBarForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.theLine = new System.Windows.Forms.Label();
            this.NowLetter = new System.Windows.Forms.Label();
            this.AllLetter = new System.Windows.Forms.Label();
            this.Emergencyexit = new System.Windows.Forms.Button();
            this.Pausebottom = new System.Windows.Forms.Button();
            this.comput = new System.Windows.Forms.Timer(this.components);
            this.lefttime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 36);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 30);
            this.progressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // theLine
            // 
            this.theLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theLine.Location = new System.Drawing.Point(12, 80);
            this.theLine.Name = "theLine";
            this.theLine.Size = new System.Drawing.Size(80, 1);
            this.theLine.TabIndex = 4;
            // 
            // NowLetter
            // 
            this.NowLetter.AutoSize = true;
            this.NowLetter.Location = new System.Drawing.Point(10, 69);
            this.NowLetter.Name = "NowLetter";
            this.NowLetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NowLetter.Size = new System.Drawing.Size(11, 12);
            this.NowLetter.TabIndex = 5;
            this.NowLetter.Text = "0";
            // 
            // AllLetter
            // 
            this.AllLetter.AutoSize = true;
            this.AllLetter.Location = new System.Drawing.Point(10, 81);
            this.AllLetter.Name = "AllLetter";
            this.AllLetter.Size = new System.Drawing.Size(11, 12);
            this.AllLetter.TabIndex = 6;
            this.AllLetter.Text = "0";
            // 
            // Emergencyexit
            // 
            this.Emergencyexit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Emergencyexit.Location = new System.Drawing.Point(337, 2);
            this.Emergencyexit.Name = "Emergencyexit";
            this.Emergencyexit.Size = new System.Drawing.Size(135, 28);
            this.Emergencyexit.TabIndex = 8;
            this.Emergencyexit.Text = "Emergency exit";
            this.Emergencyexit.UseVisualStyleBackColor = true;
            this.Emergencyexit.Click += new System.EventHandler(this.Emergencyexit_Click);
            // 
            // Pausebottom
            // 
            this.Pausebottom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pausebottom.Location = new System.Drawing.Point(384, 69);
            this.Pausebottom.Name = "Pausebottom";
            this.Pausebottom.Size = new System.Drawing.Size(88, 30);
            this.Pausebottom.TabIndex = 7;
            this.Pausebottom.Text = "Pause";
            this.Pausebottom.UseVisualStyleBackColor = true;
            this.Pausebottom.Click += new System.EventHandler(this.Pausebottom_Click);
            // 
            // comput
            // 
            this.comput.Enabled = true;
            this.comput.Interval = 995;
            this.comput.Tick += new System.EventHandler(this.comput_Tick);
            // 
            // lefttime
            // 
            this.lefttime.Location = new System.Drawing.Point(98, 76);
            this.lefttime.Name = "lefttime";
            this.lefttime.Size = new System.Drawing.Size(280, 13);
            this.lefttime.TabIndex = 9;
            this.lefttime.Text = "Computing......      Please wait......";
            this.lefttime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 102);
            this.Controls.Add(this.Pausebottom);
            this.Controls.Add(this.Emergencyexit);
            this.Controls.Add(this.theLine);
            this.Controls.Add(this.AllLetter);
            this.Controls.Add(this.NowLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lefttime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBarForm";
            this.Text = "ProgressBarForm";
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label theLine;
        public System.Windows.Forms.Label NowLetter;
        public System.Windows.Forms.Label AllLetter;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Emergencyexit;
        private System.Windows.Forms.Button Pausebottom;
        private System.Windows.Forms.Timer comput;
        private System.Windows.Forms.Label lefttime;

    }
}