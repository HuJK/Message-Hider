using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Message_Hider
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public class theSettings
    {
        public static int theColorDeep = 4;
        public static int lefttext;
        public static int saveneed;
        public static int textlong;
        public static bool weathershowbar;
        public static bool fastmode;
        public static bool timing;
    }
    public class XYRGB
    {
        public static int NX = 0, NY = 0, NX2 = 0, NY2 = 0;
        public static byte NRGB = 1, NRGBW = 1;
    }
}
