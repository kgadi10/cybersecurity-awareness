using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CyberSecurityBot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AudioPlayer.PlayGreeting();

            Application.Run(new MainForm());
        }
    }
}