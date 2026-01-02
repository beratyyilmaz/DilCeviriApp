using System;
using System.Windows.Forms;

namespace MultiLangTranslator
{
    /// <summary>
    /// Uygulama giriş noktası
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

