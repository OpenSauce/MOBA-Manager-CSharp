using MOBA_Manager.Source.Sound;
using MOBA_Manager.UI;
using System.Windows;
using System.Windows.Controls;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for IntroScreen.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            SetupGameIntro();
        }

        private void SetupGameIntro()
        {
            Switcher.Switch(new MOBA_Manager.UI.IntroScreen());
            SoundHandler.PlayMainMusic();
        }

        public void Navigate(Page nextPage)
        {
            this.Content = nextPage;
        }
    }
}