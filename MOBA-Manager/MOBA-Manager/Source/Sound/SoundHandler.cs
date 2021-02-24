using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MOBA_Manager.Source.Sound
{
    internal class SoundHandler
    {
        private static MediaPlayer m_mediaPlayer;
        private static BitmapImage speakerOn, speakerOff;

        public static void LoadMusicIcons()
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"\Assets\UI\speaker.png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            speakerOn = bi;

            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"\Assets\UI\speaker-off.png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            speakerOff = bi;
        }

        public static void PlayMainMusic()
        {
            m_mediaPlayer = new MediaPlayer();
            m_mediaPlayer.Open(new Uri(@"D:\GitHub\MOBA-Manager\MOBA-Manager\MOBA-Manager\Sound\Doomsayer.wav", UriKind.RelativeOrAbsolute));
            m_mediaPlayer.Volume = GetMusicVolumeSettings();
            m_mediaPlayer.MediaEnded += new EventHandler(Media_Ended);
            m_mediaPlayer.Play();
        }

        public static void StopMainMusic()
        {
            m_mediaPlayer.Stop();
        }

        public static void ToggleVolumeOnOff()
        {
            Properties.Settings.Default.volumeOn = !Properties.Settings.Default.volumeOn;
            Properties.Settings.Default.Save();
            m_mediaPlayer.Volume = GetMusicVolumeSettings();
        }

        private static void Media_Ended(object sender, EventArgs e)
        {
            m_mediaPlayer.Position = TimeSpan.Zero;
            m_mediaPlayer.Play();
        }

        private static float GetMusicVolumeSettings()
        {
            if (Properties.Settings.Default.volumeOn)
            {
                return Properties.Settings.Default.volume;
            }
            else
            {
                return 0.0F;
            }
        }

        private static void SetMusicVolumeSettings(float value)
        {
            Properties.Settings.Default.volume = value;
            Properties.Settings.Default.Save();
        }

        public static BitmapImage GetSoundIconForVolume()
        {
            if (Properties.Settings.Default.volumeOn)
            {
                return speakerOn;
            }
            else
            {
                return speakerOff;
            }
        }
    }
}