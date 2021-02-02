using MOBA_Manager.Game;
using MOBA_Manager.UI.InGameUI;
using System.Windows;
using System.Windows.Controls;

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
            FullNameLabel.Content = gameEngine.PlayerSession.GetUserFullName();
            CashLabel.Content = gameEngine.PlayerSession.GetCash();
            InMainGameFrame.Navigate(new HomeScreenPage());
        }

        private void AllPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllPlayersPage(this.gameEngine.PlayerSession.GetPlayerList()));
        }

        private void BuyPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new BuyPlayersPage(this.gameEngine.PlayerSession.BuyablePlayers));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new HomeScreenPage());
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
    }
}