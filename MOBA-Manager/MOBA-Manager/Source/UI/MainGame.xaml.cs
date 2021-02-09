using MOBA_Manager.Game;
using MOBA_Manager.UI.InGame;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MOBA_Manager.UI
{
    /// <summary>
    /// Interaction logic for MainGame.xaml
    /// </summary>
    public partial class MainGame : Page
    {
        private MainGameEngine gameEngine;

        public MainGame()
        {
            InitializeComponent();
        }

        public MainGame(MainGameEngine gameEngine)
        {
            this.gameEngine = gameEngine;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            InMainGameFrame.Navigate(new HomeScreenPage(this.gameEngine.PlayerSession));
        }

        private void AllPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllPlayersPage(this.gameEngine.PlayerSession.GetPlayerList()));
        }

        private void BuyPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new BuyPlayersPage(this.gameEngine.PlayerSession.BuyablePlayers, this.gameEngine.PlayerSession));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new HomeScreenPage(this.gameEngine.PlayerSession));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.gameEngine.ProceedGame();
            SetupUI();
        }

        private void AllTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllTeamsPage(this.gameEngine.PlayerSession.GetTeamList()));
        }

        private void SpacebarHandler_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            {
                this.gameEngine.ProceedGame();
                SetupUI();
            }
        }
    }
}