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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        bool weathershowbar;
        private void Settings_Load(object sender, EventArgs e)
        {
            savelabel.Text = Properties.Settings.Default.saveColorDeep;
            theSettings.theColorDeep = Convert.ToInt32(savelabel.Text);
            theSettings.weathershowbar = Properties.Settings.Default.saveweathershowbar;
            weathershowbar = theSettings.weathershowbar;
            switch (theSettings.theColorDeep)
            {
                case 2:
                    this.ColorDeep.SelectedIndex = 0;
                    break;
                case 4:
                    this.ColorDeep.SelectedIndex = 1;
                    break;
                case 16:
                    this.ColorDeep.SelectedIndex = 2;
                    break;
                case 256:
                    this.ColorDeep.SelectedIndex = 3;
                    break;
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch (this.ColorDeep.SelectedIndex)
            {
                case 0:

                    theSettings.theColorDeep = 2;
                    savelabel.Text = "2";
                    break;
                case 1:
                    theSettings.theColorDeep = 4;
                    savelabel.Text = "4";
                    break;
                case 2:
                    theSettings.theColorDeep = 16;
                    savelabel.Text = "16";
                    break;
                case 3:
                    theSettings.theColorDeep = 256;
                    savelabel.Text = "256";
                    break;
            }
            theSettings.timing = this.timing.Checked;
            theSettings.fastmode = this.Fastmode.Checked;
            Properties.Settings.Default.Save();
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fastmode_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Fastmode.Checked == true)
            {
                MessageBox.Show("This mode will make this program run faster,but it will let this program \"LOOKS LIKE\" not responding(But it stell working)!\nBecause I removed the code like show bar,comput lefttime...the code which will drag speed");
            }
        }
    }
}
