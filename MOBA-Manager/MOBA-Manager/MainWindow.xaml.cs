using MOBA_Manager.src.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User _player;
        PlaySession _session;
        private Settings _gameSettings;

        public MainWindow()
        {
            InitializeComponent();
            this._gameSettings = new Settings().LoadSettings();
            this._session = new PlaySession();
            MainFrame.Content = new UserCreation(this);
        }

        public void CreateTeam(User player)
        {
            this._player = player;
            if (_player.IsCreated())
            {
                MainFrame.Content = new TeamCreation(this, _player, _session);
            }
        }

        public void BeginGame()
        {
            MainFrame.Content = new MainGame(this, _player, _session);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage settings = new SettingsPage(_gameSettings);
        }
    }
}
