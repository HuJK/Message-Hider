using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Message_Hider
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string strPath;
        //以下是事件
        public char CD2()
        {
            string unicode2;
            unicode2 = Convert.ToString((GetRGB() % 2 << 15) + (GetRGB() % 2 << 14) + (GetRGB() % 2 << 13) + (GetRGB() % 2 << 12) + (GetRGB() % 2 << 11) + (GetRGB() % 2 << 10) + (GetRGB() % 2 << 9) + (GetRGB() % 2 << 8) + (GetRGB() % 2 << 7) + (GetRGB() % 2 << 6) + (GetRGB() % 2 << 5) + (GetRGB() % 2 << 4) + (GetRGB() % 2 << 3) + (GetRGB() % 2 << 2) + (GetRGB() % 2 << 1) + (GetRGB() % 2), 16);
            return (char)int.Parse(unicode2, System.Globalization.NumberStyles.HexNumber);
        }
        public char CD4(byte a1, byte a2, byte a3, byte a4, byte a5, byte a6, byte a7, byte a8)
        {
            string unicode2;
            unicode2 = Convert.ToString((a1 % 4 << 14) + (a2 % 4 << 12) + (a3 % 4 << 10) + (a4 % 4 << 8) + (a5 % 4 << 6) + (a6 % 4 << 4) + (a7 % 4 << 2) + (a8 % 4), 16);
            return (char)int.Parse(unicode2, System.Globalization.NumberStyles.HexNumber);
        }
        public byte GetRGB()
        {
            byte v;
            Bitmap bmp2 = new Bitmap(this.thepicture.Image);
            if (XYRGB.NRGB == 1)
            {
                //MessageBox.Show("現在開始讀取(" + XYRGB.NX.ToString() + "," + XYRGB.NY.ToString() + ")像素R");
                XYRGB.NRGB = 2;
                v = bmp2.GetPixel(XYRGB.NX, XYRGB.NY).R;
                bmp2.Dispose();
                return v;
            }
            else if (XYRGB.NRGB == 2)
            {
                //MessageBox.Show("現在開始讀取(" + XYRGB.NX.ToString() + "," + XYRGB.NY.ToString() + ")像素G");
                XYRGB.NRGB = 3;
                v = bmp2.GetPixel(XYRGB.NX, XYRGB.NY).G;
                bmp2.Dispose();
                return v;
            }
            else
            {
                //MessageBox.Show("現在開始讀取(" + XYRGB.NX.ToString() + "," + XYRGB.NY.ToString() + ")像素B");
                XYRGB.NRGB = 1;
                v = bmp2.GetPixel(XYRGB.NX, XYRGB.NY).B;

                if (XYRGB.NX == bmp2.Width - 1)
                {
                    XYRGB.NX = 0;
                    XYRGB.NY = XYRGB.NY + 1;
                }
                else
                {
                    XYRGB.NX = XYRGB.NX + 1;
                }
                bmp2.Dispose();
                return v;
            }
        }
        public void SetRGB(byte thevalue)
        {
            Bitmap bmp = new Bitmap(this.thepicture.Image);
            if (XYRGB.NRGBW == 1)
            {
                Color i = bmp.GetPixel(XYRGB.NX2, XYRGB.NY2);
                XYRGB.NRGBW = 2;
                //    MessageBox.Show((i.R - (i.R % theSettings.theColorDeep)).ToString() + "+" + thevalue.ToString());
                bmp.SetPixel(XYRGB.NX2, XYRGB.NY2, Color.FromArgb(i.A, i.R - (i.R % theSettings.theColorDeep) + thevalue, i.G, i.B));
            }
            else if (XYRGB.NRGBW == 2)
            {
                Color i = bmp.GetPixel(XYRGB.NX2, XYRGB.NY2);
                XYRGB.NRGBW = 3;
                bmp.SetPixel(XYRGB.NX2, XYRGB.NY2, Color.FromArgb(i.A, i.R, i.G - (i.G % theSettings.theColorDeep) + thevalue, i.B));
            }
            else
            {
                Color i = bmp.GetPixel(XYRGB.NX2, XYRGB.NY2);
                XYRGB.NRGBW = 1;
                bmp.SetPixel(XYRGB.NX2, XYRGB.NY2, Color.FromArgb(i.A, i.R, i.G, i.B - (i.B % theSettings.theColorDeep) + thevalue));
                if (XYRGB.NX2 == bmp.Width - 1)
                {
                    XYRGB.NX2 = 0;
                    XYRGB.NY2 = XYRGB.NY2 + 1;
                }
                else
                {
                    XYRGB.NX2 = XYRGB.NX2 + 1;
                }
            }
            this.thepicture.Image = bmp;



        }
        public string TO4(char a)//10進位轉4進位
        {
            if (a == '0') { return Convert.ToString("00"); }
            if (a == '1') { return Convert.ToString("01"); }
            if (a == '2') { return Convert.ToString("02"); }
            if (a == '3') { return Convert.ToString("03"); }
            if (a == '4') { return Convert.ToString("10"); }
            if (a == '5') { return Convert.ToString("11"); }
            if (a == '6') { return Convert.ToString("12"); }
            if (a == '7') { return Convert.ToString("13"); }
            if (a == '8') { return Convert.ToString("20"); }
            if (a == '9') { return Convert.ToString("21"); }
            if (a == 'a') { return Convert.ToString("22"); }
            if (a == 'b') { return Convert.ToString("23"); }
            if (a == 'c') { return Convert.ToString("30"); }
            if (a == 'd') { return Convert.ToString("31"); }
            if (a == 'e') { return Convert.ToString("32"); }
            { return Convert.ToString("33"); }
        }
        public int TO10(string a)//4進位轉10進位
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                b += Convert.ToString(Convert.ToInt32(Convert.ToString(a[i])), 2).PadLeft(2, '0');
            }
            return Convert.ToInt32(b, 2);
        }
        public void theinitialize()// 初始化
        {
            if (thepicture.Image != null)
            {
                if (theSettings.theColorDeep == 2)//計算出最少需要幾個像速拿來"儲存總字數"
                {
                    theSettings.saveneed = Convert.ToInt32(Math.Ceiling(Math.Ceiling(Math.Ceiling(Math.Log(3 * (thepicture.Image.Width + 1) * (thepicture.Image.Height + 1), 2)) - 4) / 3));
                }
                else if (theSettings.theColorDeep == 4)
                {
                    //  theSettings.saveneed = Convert.ToInt32(Math.Ceiling(Math.Ceiling(Math.Log(3 * (thepicture.Image.Width + 1) * (thepicture.Image.Height + 1), 2)) - 3) / 6);
                    theSettings.saveneed = Convert.ToInt32(Math.Ceiling(Math.Ceiling(Math.Ceiling(Math.Log(3 * (thepicture.Image.Width + 1) * (thepicture.Image.Height + 1), 2)) - 3) / 6));
                }
                else if (theSettings.theColorDeep == 16)
                {
                    theSettings.saveneed = Convert.ToInt32(Math.Ceiling(Math.Ceiling(Math.Ceiling(Math.Log(3 * (thepicture.Image.Width + 1) * (thepicture.Image.Height + 1), 2)) - 2) / 12));
                }
                else if (theSettings.theColorDeep == 256)
                {
                    theSettings.saveneed = Convert.ToInt32(Math.Ceiling(Math.Ceiling(Math.Ceiling(Math.Log(3 * (thepicture.Image.Width + 1) * (thepicture.Image.Height + 1), 2)) - 1) / 24));
                }
                theSettings.lefttext = Convert.ToInt32(Math.Floor(Math.Floor((((thepicture.Image.Width ) * (thepicture.Image.Height ) - theSettings.saveneed) * 3 * Math.Log(theSettings.theColorDeep, 2))) / 16));
                this.textnumber.Text = theSettings.lefttext.ToString();
                this.thetext.MaxLength = theSettings.lefttext;
                this.textnumber.Text = (theSettings.lefttext - this.thetext.TextLength).ToString();
            }
            else
            {
                this.textnumber.Text = "0";
                this.thetext.MaxLength = 0;
            }
            XYRGB.NX = 0; XYRGB.NY = 0; XYRGB.NX2 = 0; XYRGB.NY2 = 0;
            XYRGB.NRGB = 1; XYRGB.NRGBW = 1;
        }
        //以上是事件

        private void totext_Click(object sender, EventArgs e)
        {
            if (theSettings.fastmode == true)
            {
                fasttotext();
            }
            else
            {
                slowtotext();
            }
        }
        void fasttotext()
        {
            theinitialize();
            DateTime CurrTime = DateTime.Now;
            if (thepicture.Image != null)
            {
                //以下是在讀取總字數
                if (theSettings.theColorDeep == 2)
                {
                    string b = "";
                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (GetRGB() % 2).ToString();
                    }
                    //MessageBox.Show(b);
                    theSettings.textlong = Convert.ToInt32(b, 2);
                    //MessageBox.Show(theSettings.textlong.ToString() + "個字");

                }
                else if (theSettings.theColorDeep == 4)
                {
                    string b = "";

                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (GetRGB() % 4).ToString();
                    }
                    theSettings.textlong = TO10(b);
                }
                else if (theSettings.theColorDeep == 16)
                {

                    string b = "";
                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (Convert.ToString(GetRGB() % 16, 16));
                    }

                    theSettings.textlong = Convert.ToInt32(b, 16);
                    // MessageBox.Show(theSettings.textlong.ToString() + "個字");
                }
                else if (theSettings.theColorDeep == 256)
                {

                    string b = "";
                    for (int i = 1; i <= theSettings.saveneed * 3; i++)
                    {
                        string r = GetRGB().ToString();
                        b += Convert.ToString(Convert.ToInt32(r), 16);
                    }
                    theSettings.textlong = Convert.ToInt32(b, 16);
                    //MessageBox.Show(theSettings.textlong.ToString() + "個字");
                }
                //以上是在讀取總字數
                //以下是在讀取字元
                if (theSettings.theColorDeep == 2)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            thetext.Text += CD2();
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (theSettings.theColorDeep == 4)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            thetext.Text += CD4(GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB());
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (theSettings.theColorDeep == 16)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            thetext.Text += (char)int.Parse(Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16), System.Globalization.NumberStyles.HexNumber); ;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (theSettings.theColorDeep == 256)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            thetext.Text += (char)int.Parse(Convert.ToString((GetRGB()), 16).PadLeft(2, '0') + Convert.ToString((GetRGB()), 16).PadLeft(2, '0'), System.Globalization.NumberStyles.HexNumber); ;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a picture", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //以上是在讀取字元
            if (theSettings.timing == true)
            {
                MessageBox.Show("Cost " + Convert.ToString((DateTime.Now - CurrTime).TotalSeconds + " seconds"));
                MessageBox.Show((theSettings.textlong / (DateTime.Now - CurrTime).TotalSeconds).ToString() + " Char/Sec");
            }
        }
        void slowtotext()
        {
            theinitialize();
            totext.Enabled = false;
            topic.Enabled = false;
            picpath.Enabled = false;
            menuStrip1.Enabled = false;
            selectfile.Enabled = false;
            thetext.ReadOnly = true;
            DateTime CurrTime = DateTime.Now;
            bool t = theSettings.timing;
            if (thepicture.Image != null)
            {
                ProgressBarForm ProgressBarForm = new ProgressBarForm();
                ProgressBarForm.Text = "Reading Image......";
                ProgressBarForm.label1.Text = "Reading Image......";
                //以下是在讀取總字數
                if (theSettings.theColorDeep == 2)
                {
                    string b = "";
                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (GetRGB() % 2).ToString();
                    }
                    //MessageBox.Show(b);
                    theSettings.textlong = Convert.ToInt32(b, 2);
                    ProgressBarForm.AllLetter.Text = theSettings.textlong.ToString();
                    ProgressBarForm.Show();
                    //MessageBox.Show(theSettings.textlong.ToString() + "個字");

                }
                else if (theSettings.theColorDeep == 4)
                {
                    string b = "";

                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (GetRGB() % 4).ToString();
                    }
                    theSettings.textlong = TO10(b);
                    ProgressBarForm.AllLetter.Text = theSettings.textlong.ToString();
                    ProgressBarForm.Show();
                }
                else if (theSettings.theColorDeep == 16)
                {

                    string b = "";
                    for (int i = 0; i < theSettings.saveneed * 3; i++)
                    {
                        b += (Convert.ToString(GetRGB() % 16, 16));
                    }

                    theSettings.textlong = Convert.ToInt32(b, 16);
                    ProgressBarForm.AllLetter.Text = theSettings.textlong.ToString();
                    ProgressBarForm.Show();
                    // MessageBox.Show(theSettings.textlong.ToString() + "個字");
                }
                else if (theSettings.theColorDeep == 256)
                {

                    string b = "";
                    for (int i = 1; i <= theSettings.saveneed * 3; i++)
                    {
                        string r = GetRGB().ToString();
                        b += Convert.ToString(Convert.ToInt32(r), 16);
                    }
                    theSettings.textlong = Convert.ToInt32(b, 16);
                    ProgressBarForm.AllLetter.Text = theSettings.textlong.ToString();
                    ProgressBarForm.Show();
                    //MessageBox.Show(theSettings.textlong.ToString() + "個字");
                }
                //以上是在讀取總字數
                //以下是在讀取字元
                if (theSettings.theColorDeep == 2)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        try
                        {
                            ProgressBarForm.progressBar.Maximum = theSettings.textlong - 1;
                        }
                        catch
                        {
                            MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            ProgressBarForm.progressBar.Value = i;
                            ProgressBarForm.NowLetter.Text = i.ToString();
                            Application.DoEvents();
                            thetext.Text += CD2();
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProgressBarForm.Close();
                }
                else if (theSettings.theColorDeep == 4)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        try
                        {
                            ProgressBarForm.progressBar.Maximum = theSettings.textlong - 1;
                        }
                        catch 
                        {
                            MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            ProgressBarForm.progressBar.Value = i;
                            ProgressBarForm.NowLetter.Text = i.ToString();
                            Application.DoEvents();
                            thetext.Text += CD4(GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB(), GetRGB());
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProgressBarForm.Close();
                }
                else if (theSettings.theColorDeep == 16)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        try
                        {
                            ProgressBarForm.progressBar.Maximum = theSettings.textlong - 1;
                        }
                        catch 
                        {
                            MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            ProgressBarForm.progressBar.Value = i;
                            ProgressBarForm.NowLetter.Text = i.ToString();
                            Application.DoEvents();
                            thetext.Text += (char)int.Parse(Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16) + Convert.ToString((GetRGB() % 16), 16), System.Globalization.NumberStyles.HexNumber); ;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProgressBarForm.Close();
                }
                else if (theSettings.theColorDeep == 256)
                {
                    if (theSettings.textlong <= theSettings.lefttext)
                    {
                        thetext.Text = "";
                        try
                        {
                            ProgressBarForm.progressBar.Maximum = theSettings.textlong - 1;
                        }
                        catch
                        {
                            MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        for (int i = 0; i < theSettings.textlong; i++)
                        {
                            ProgressBarForm.progressBar.Value = i;
                            ProgressBarForm.NowLetter.Text = i.ToString();
                            Application.DoEvents();
                            thetext.Text += (char)int.Parse(Convert.ToString((GetRGB()), 16).PadLeft(2, '0') + Convert.ToString((GetRGB()), 16).PadLeft(2, '0'), System.Globalization.NumberStyles.HexNumber); ;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProgressBarForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Please choose a picture", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //以上是在讀取字元
            if (theSettings.timing == true)
            {
                MessageBox.Show("Cost " + Convert.ToString((DateTime.Now - CurrTime).TotalSeconds + " seconds"));
                MessageBox.Show((theSettings.textlong / (DateTime.Now - CurrTime).TotalSeconds).ToString() + " Char/Sec");
            }
            theSettings.timing = t;
            totext.Enabled = true;
            topic.Enabled = true;
            picpath.Enabled = true;
            menuStrip1.Enabled = true;
            selectfile.Enabled = true;
            thetext.ReadOnly = false;
            this.Focus();
        }
        private void topic_Click(object sender, EventArgs e)
        {
            if (this.thetext.Text != "")
            {
                if (theSettings.fastmode == true)
                {
                    fasttopic();
                }
                else
                {
                    slowtopic();
                }
            }
            else
            {
                MessageBox.Show("Please enter some messages in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void fasttopic()
        {
            theinitialize();
            DateTime CurrTime = DateTime.Now;
            if (thepicture.Image != null)
            {
                {  //以下是在儲存總字數
                    if (theSettings.theColorDeep == 2)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 2);

                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        //MessageBox.Show(b);
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 1])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2])));
                            GC.Collect();
                        }
                    }
                    else if (theSettings.theColorDeep == 4)
                    {
                        string a = Convert.ToString(thetext.Text.Length, 16);
                        string b = "";

                        for (int i = 0; i < a.Length; i++)
                        {
                            b += Convert.ToString(Convert.ToInt32(TO4(a[i]))).PadLeft(2, '0');
                        }
                        b = Convert.ToInt32(b).ToString();
                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 1])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2])));
                            GC.Collect();
                        }
                    }
                    else if (theSettings.theColorDeep == 16)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 16);
                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i]), 16)));
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i + 1]), 16)));
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i + 2]), 16)));
                        }
                    }
                    else if (theSettings.theColorDeep == 256)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 16);
                        b = b.PadLeft(theSettings.saveneed * 6, '0');
                        for (int i = 0; i < theSettings.saveneed * 6; i += 6)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i]) + Convert.ToString(b[i + 1]), 16));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2]) + Convert.ToString(b[i + 3]), 16));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 4]) + Convert.ToString(b[i + 5]), 16));
                        }
                    }
                }//以上是在儲存總字數


                //以下是在寫入字元
                if (theSettings.theColorDeep == 2)
                {

                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            string b;//用來暫存2進位的結果
                            //  MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                b = Convert.ToString(Convert.ToInt32(Convert.ToString(a[j]), 16), 2).PadLeft(4, '0');
                                //MessageBox.Show("寫入" + Convert.ToByte(b[0].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[0].ToString()));
                                //MessageBox.Show("寫入" + Convert.ToByte(b[1].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[1].ToString()));
                                SetRGB(Convert.ToByte(b[2].ToString()));
                                SetRGB(Convert.ToByte(b[3].ToString()));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 4)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            string b;//用來暫存CD4()的結果
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                b = (TO4(a[j])).ToString();
                                //MessageBox.Show("寫入" + Convert.ToByte(b[0].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[0].ToString()));
                                //MessageBox.Show("寫入" + Convert.ToByte(b[1].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[1].ToString()));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 16)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                //MessageBox.Show("寫入" + Convert.ToByte(Convert.ToString(a[j]),16).ToString());
                                SetRGB(Convert.ToByte(Convert.ToString(a[j]), 16));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 256)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j += 2)
                            {
                                //MessageBox.Show(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]));
                                //MessageBox.Show("寫入" + Convert.ToByte(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]), 16).ToString());
                                SetRGB(Convert.ToByte(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]), 16));
                                GC.Collect();
                            }
                        }
                    }
                }

                //以上是在寫入字元
                if (theSettings.timing == true)
                {
                    MessageBox.Show("Cost " + Convert.ToString((DateTime.Now - CurrTime).TotalSeconds + " seconds"));
                    MessageBox.Show((theSettings.textlong / (DateTime.Now - CurrTime).TotalSeconds).ToString() + " Char/Sec");
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    Bitmap bmp = new Bitmap(thepicture.Image);
                    try
                    {
                        bmp.Save(fileName);
                        MessageBox.Show("已儲存到" + fileName, "Saving Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        try
                        {
                            System.IO.File.Delete(fileName);
                            bmp.Save(fileName);
                            MessageBox.Show("已儲存到" + fileName, "Saving Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Permission denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please choose a picture!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            thepicture.Image = Image.FromFile(strPath);
        }
        void slowtopic()
        {
            theinitialize();
            totext.Enabled = false;
            topic.Enabled = false;
            picpath.Enabled = false;
            menuStrip1.Enabled = false;
            selectfile.Enabled = false;
            thetext.ReadOnly = true;
            DateTime CurrTime = DateTime.Now;
            bool t = theSettings.timing;
            if (thepicture.Image != null)
            {
                ProgressBarForm ProgressBarForm = new ProgressBarForm();
                ProgressBarForm.progressBar.Maximum = thetext.Text.Length;
                ProgressBarForm.Text = "Setting new picture......";
                ProgressBarForm.label1.Text = "Setting new picture......";
                ProgressBarForm.AllLetter.Text = thetext.Text.Length.ToString();
                {  //以下是在儲存總字數
                    if (theSettings.theColorDeep == 2)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 2);
                        
                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        //MessageBox.Show(b);
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 1])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2])));
                            GC.Collect();
                        }
                    }
                    else if (theSettings.theColorDeep == 4)
                    {
                        string a = Convert.ToString(thetext.Text.Length, 16);
                        string b = "";

                        for (int i = 0; i < a.Length; i++)
                        {
                            b += Convert.ToString(Convert.ToInt32(TO4(a[i]))).PadLeft(2, '0');
                        }
                        b = Convert.ToInt32(b).ToString();
                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 1])));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2])));
                            GC.Collect();
                        }
                    }
                    else if (theSettings.theColorDeep == 16)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 16);
                        b = b.PadLeft(theSettings.saveneed * 3, '0');
                        for (int i = 0; i < theSettings.saveneed * 3; i += 3)
                        {
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i]), 16)));
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i + 1]), 16)));
                            SetRGB(Convert.ToByte(Convert.ToInt32(Convert.ToString(b[i + 2]), 16)));
                        }
                    }
                    else if (theSettings.theColorDeep == 256)
                    {
                        string b = Convert.ToString(thetext.Text.Length, 16);
                        b = b.PadLeft(theSettings.saveneed * 6, '0');
                        for (int i = 0; i < theSettings.saveneed * 6; i += 6)
                        {
                            SetRGB(Convert.ToByte(Convert.ToString(b[i]) + Convert.ToString(b[i + 1]), 16));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 2]) + Convert.ToString(b[i + 3]), 16));
                            SetRGB(Convert.ToByte(Convert.ToString(b[i + 4]) + Convert.ToString(b[i + 5]), 16));
                        }
                    }
                }//以上是在儲存總字數


                //以下是在寫入字元
                if (theSettings.theColorDeep == 2)
                {

                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        ProgressBarForm.Show();
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            ProgressBarForm.NowLetter.Text = (i+1).ToString();
                            ProgressBarForm.progressBar.Value = i +1;
                            Application.DoEvents();
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            string b;//用來暫存2進位的結果
                            //  MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                b = Convert.ToString(Convert.ToInt32(Convert.ToString(a[j]), 16), 2).PadLeft(4, '0');
                                //MessageBox.Show("寫入" + Convert.ToByte(b[0].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[0].ToString()));
                                //MessageBox.Show("寫入" + Convert.ToByte(b[1].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[1].ToString()));
                                SetRGB(Convert.ToByte(b[2].ToString()));
                                SetRGB(Convert.ToByte(b[3].ToString()));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 4)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        ProgressBarForm.Show();
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            ProgressBarForm.NowLetter.Text = (i+1).ToString();
                            ProgressBarForm.progressBar.Value = i +1;
                            Application.DoEvents();
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            string b;//用來暫存CD4()的結果
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                b = (TO4(a[j])).ToString();
                                //MessageBox.Show("寫入" + Convert.ToByte(b[0].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[0].ToString()));
                                //MessageBox.Show("寫入" + Convert.ToByte(b[1].ToString()).ToString());
                                SetRGB(Convert.ToByte(b[1].ToString()));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 16)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        ProgressBarForm.Show();
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            ProgressBarForm.NowLetter.Text = (i+1).ToString();
                            ProgressBarForm.progressBar.Value = i+1;
                            Application.DoEvents();
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j++)
                            {
                                //MessageBox.Show("寫入" + Convert.ToByte(Convert.ToString(a[j]),16).ToString());
                                SetRGB(Convert.ToByte(Convert.ToString(a[j]), 16));
                                GC.Collect();
                            }
                        }
                    }
                }
                else if (theSettings.theColorDeep == 256)
                {
                    if (!string.IsNullOrEmpty(thetext.Text))
                    {
                        ProgressBarForm.Show();
                        string a;
                        for (int i = 0; i < thetext.Text.Length; i++)
                        {
                            ProgressBarForm.NowLetter.Text = (i+1).ToString();
                            ProgressBarForm.progressBar.Value = i+1;
                            Application.DoEvents();
                            //將中文轉為10進制整數，然後轉為16進制unicode 
                            a = ((int)thetext.Text[i]).ToString("x").PadLeft(4, '0');
                            //MessageBox.Show(a);
                            for (int j = 0; j < 4; j += 2)
                            {
                                //MessageBox.Show(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]));
                                //MessageBox.Show("寫入" + Convert.ToByte(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]), 16).ToString());
                                SetRGB(Convert.ToByte(Convert.ToString(a[j]) + Convert.ToString(a[j + 1]), 16));
                                GC.Collect();
                            }
                        }
                    }
                }

                //以上是在寫入字元
                if (theSettings.timing == true)
                {
                    MessageBox.Show("Cost " +Convert.ToString((DateTime.Now - CurrTime).TotalSeconds + " seconds"));
                    MessageBox.Show((theSettings.textlong / (DateTime.Now - CurrTime).TotalSeconds).ToString() + " Char/Sec");
                }
                theSettings.timing = t;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    Bitmap bmp = new Bitmap(thepicture.Image);
                    try
                    {
                        bmp.Save(fileName);
                        MessageBox.Show("已儲存到" + fileName, "Saving Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        try
                        {
                            System.IO.File.Delete(fileName);
                            bmp.Save(fileName);
                            MessageBox.Show("已儲存到" + fileName, "Saving Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Permission denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                ProgressBarForm.Close();
            }
            else
            {
                MessageBox.Show("Please choose a picture!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            thepicture.Image = Image.FromFile(strPath);
            totext.Enabled = true;
            topic.Enabled = true;
            picpath.Enabled = true;
            menuStrip1.Enabled = true;
            selectfile.Enabled = true;
            thetext.ReadOnly = false;
            this.Focus();
        }

        private void selectfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(picpath.Text)))
                {
                    openFileDlg.InitialDirectory = Path.GetDirectoryName(picpath.Text);
                    if (Path.GetExtension(picpath.Text).ToLower() == ".png" || Path.GetExtension(picpath.Text).ToLower() == ".bmp")
                    {
                        openFileDlg.FileName = Path.GetFileName(picpath.Text);
                    }
                    if (this.openFileDlg.ShowDialog() == DialogResult.OK)
                    {

                        strPath = openFileDlg.FileName;
                        if (Path.GetExtension(strPath).ToLower() == ".png" || Path.GetExtension(strPath).ToLower() == ".bmp")
                        {
                            this.picpath.Text = strPath;
                            thepicture.Image = Image.FromFile(strPath);
                            theinitialize();
                        }
                        else
                        {
                            MessageBox.Show("Must \".png\" or \".bmp\" file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch
            {
                if (this.openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    strPath = openFileDlg.FileName;
                    if (Path.GetExtension(strPath).ToLower() == ".png" || Path.GetExtension(strPath).ToLower() == ".bmp")
                    {
                        this.picpath.Text = strPath;
                        thepicture.Image = Image.FromFile(strPath);
                        theinitialize();
                    }
                    else
                    {
                        MessageBox.Show("Must \".png\" or \".bmp\" file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.ShowDialog();
            theinitialize();
            //thepicture
            thepicture.Height = this.Height - 106;
            thepicture.Width = (this.Width - 100) / 2;
            thepicture.Top = 57;
            thepicture.Left = 12;
            //thetext
            thetext.Height = this.Height - 118;
            thetext.Width = (this.Width - 100) / 2;
            thetext.Left = 74 + (this.Width - 100) / 2;
            thetext.Top = 55;
            //totext
            totext.Left = 18 + (this.Width - 100) / 2;
            totext.Top = 55;
            totext.Height = (this.Height - 112) / 2;
            totext.Width = 50;
            //topic
            topic.Left = 18 + (this.Width - 100) / 2;
            topic.Height = (this.Height - 112) / 2;
            topic.Top = 61 + (this.Height - 112) / 2;
            topic.Width = 50;
            // label
            label1.Top = this.Height - 60;
            textnumber.Top = this.Height - 60;
            if (thetext.Width > textnumber.Width + label1.Width)
            {
                label1.Show();
                label1.Left = 74 + (this.Width - 100) / 2;
                textnumber.Left = 74 + label1.Width + (this.Width - 100) / 2;
            }
            else
            {
                label1.Hide();
                textnumber.Left = 74 + (this.Width - 100) / 2;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //thepicture
            thepicture.Height = this.Height - 106;
            thepicture.Width = (this.Width - 100) / 2;
            thepicture.Top = 57;
            thepicture.Left = 12;
            //thetext
            thetext.Height = this.Height - 118;
            thetext.Width = (this.Width - 100) / 2;
            thetext.Left = 74 + (this.Width - 100) / 2;
            thetext.Top = 55;
            //totext
            totext.Left = 18 + (this.Width - 100) / 2;
            totext.Top = 55;
            totext.Height = (this.Height - 112) / 2;
            totext.Width = 50;
            //topic
            topic.Left = 18 + (this.Width - 100) / 2;
            topic.Height = (this.Height - 112) / 2;
            topic.Top = 61 + (this.Height - 112) / 2;
            topic.Width = 50;
            // label
            label1.Top = this.Height - 60;
            textnumber.Top = this.Height - 60;
            if (thetext.Width > textnumber.Width + 69)
            {
                label1.Show();
                label1.Left = 74 + (this.Width - 100) / 2;
                textnumber.Left = 74 + label1.Width + (this.Width - 100) / 2;
            }
            else
            {
                label1.Hide();
                textnumber.Left = 74 + (this.Width - 100) / 2;
            }
        }

        private void picpath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strPath = openFileDlg.FileName;
                if (Path.GetExtension(strPath).ToLower() == ".png" || Path.GetExtension(strPath).ToLower() == ".bmp")
                {
                    try
                    {
                        thepicture.Image = Image.FromFile(strPath);
                        theinitialize();
                    }
                    catch
                    {
                        MessageBox.Show("Permission denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Must \".png\" or \".bmp\" file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void thetext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            } 
        }

        private void thetext_TextChanged(object sender, EventArgs e)
        {
            this.textnumber.Text = (theSettings.lefttext - this.thetext.TextLength).ToString();
        }
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.ShowDialog();
            theinitialize();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:Juin Kai-Hu\nVer:1.0.5\nAny bug please report to:bugreport@curryworld.twgg.org\nPress Ctrl + C could copy this message", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

    }
}
