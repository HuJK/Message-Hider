using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Message_Hider
{
    public partial class ProgressBarForm : Form
    {
        //DateTime nowtime = DateTime.Now;
        int nowchar = 0;
        int speed;
        int leftsec;
        public ProgressBarForm()
        {
            InitializeComponent();
        }
        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            theLine.Width = AllLetter.Width;
            theSettings.textlong = Convert.ToInt32(AllLetter.Text);
        }

        private void Emergencyexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void Pausebottom_Click(object sender, EventArgs e)
        {
            if (this.Pausebottom.Text == "Pause")
            {
                this.Pausebottom.Text = "Continue";
                theSettings.timing = false;
                comput.Stop();
                while (this.Pausebottom.Text != "Pause")
                {
                    Application.DoEvents();
                }
            }
            else
            {
                this.Pausebottom.Text = "Pause";
                comput.Start();
            }
        }

        private void comput_Tick(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(NowLetter.Text) - nowchar;
            try
            {
            lefttime.Text = "Speed: " + speed.ToString() + " Char/Sec  Remaining ";

            leftsec = (theSettings.textlong - Convert.ToInt32(NowLetter.Text)) / speed;
            int ss = leftsec % 60;
            int mm = (leftsec / 60) % 60;
            int hh = leftsec / 3600;
            lefttime.Text += hh + ":" + mm.ToString().PadLeft(2, '0') + ":" + ss.ToString().PadLeft(2, '0');
            nowchar = Convert.ToInt32(NowLetter.Text);
            //nowtime = DateTime.Now;
            }
            catch { }
        }

    }
}
