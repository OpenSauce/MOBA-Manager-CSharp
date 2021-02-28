using MOBA_Manager.Game;
using MOBA_Manager.Source.UI.InGame.Fixtures;
using MOBA_Manager.Source.UI.Training;
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
        private Session playerSession;

        public MainGame()
        {
            InitializeComponent();
        }

        public MainGame(MainGameEngine gameEngine)
        {
            this.gameEngine = gameEngine;
            this.playerSession = gameEngine.PlayerSession;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            Switcher.ingameFrame = InMainGameFrame;
            DateLabel.Content = this.playerSession.GameTime.Date.ToString("d");
            StateLabel.Content = gameEngine.state;
            InMainGameFrame.Navigate(new HomeScreenPage(this.playerSession));
        }

        private void AllPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllPlayersPage(this.playerSession.GetPlayerList()));
        }

        private void BuyPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new BuyPlayersPage(this.playerSession.BuyablePlayers, this.playerSession));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new HomeScreenPage(this.playerSession));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.gameEngine.ProceedGame();
            SetupUI();
        }

        private void AllTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllTeamsPage(this.playerSession.GetTeamList()));
        }

        private void SpacebarHandler_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            {
                this.gameEngine.ProceedGame();
                SetupUI();
            }
        }

        private void FixturesButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new FixturesPage(this.playerSession.FixturesList));
        }

        private void TrainingButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerSession.MainPlayer.Team.Roster.Count > 0)
            {
                Switcher.Switch(new TrainingScreen());
            }
        }
    }
}