using MOBA_Manager.Source.Sound;
using MOBA_Manager.Source.UI.Settings;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MOBA_Manager.UI
{
    /// <summary>
    /// Interaction logic for IntoScreen.xaml
    /// </summary>
    public partial class IntroScreen : Page
    {
        public IntroScreen()
        {
            InitializeComponent();
            SoundHandler.LoadMusicIcons();
            this.SpeakerIcon.Source = SoundHandler.GetSoundIconForVolume();
        }

        public IntroScreen(MainWindow window)
        {
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MOBA_Manager.Game.SessionDirector();
            SoundHandler.StopMainMusic();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void BeginButton_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.ShowDialog();
        }

        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void SpeakerIcon_MouseUp(object sender, MouseButtonEventArgs e)
        {
        }
    }
}