using System;
using System.Windows.Media;

namespace MOBA_Manager.Source.Sound
{
    internal class SoundHandler
    {
        private static MediaPlayer m_mediaPlayer;

        public static void PlayMainMusic()
        {
            m_mediaPlayer = new MediaPlayer();
            m_mediaPlayer.Open(new Uri(@"D:\GitHub\MOBA-Manager\MOBA-Manager\MOBA-Manager\Sound\Doomsayer.wav", UriKind.RelativeOrAbsolute));
            m_mediaPlayer.Volume = 0.2f;
            m_mediaPlayer.MediaEnded += new EventHandler(Media_Ended);
            m_mediaPlayer.Play();
        }

        public static void StopMainMusic()
        {
            m_mediaPlayer.Stop();
        }

        private static void Media_Ended(object sender, EventArgs e)
        {
            m_mediaPlayer.Position = TimeSpan.Zero;
            m_mediaPlayer.Play();
        }
    }
}