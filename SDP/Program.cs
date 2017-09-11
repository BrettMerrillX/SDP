using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static string strPath { get; set; }
        public static string strFile { get; set; }
        public static string strExtension { get; set; }
        public static int lngLineCount { get; set; }
        public static int lngMaxFiles { get; set; }
    }
}
