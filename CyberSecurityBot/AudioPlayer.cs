using System.Media;
using System.IO;
using System.Windows.Forms;

namespace CyberSecurityBot
{
    class AudioProfile
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Assets", "greeting.wav");

                SoundPlayer player = new SoundPlayer(path); C: \Users\Student\source\repos\CyberSecurityBot\CyberSecurityBot\Assets\greeting.wav

                player.Load();

                player.PlaySync();
            }
            catch
            {
                MessageBox.Show("Voice greeting failed. Check greeting.wav file.");
            }
        }
    }
}