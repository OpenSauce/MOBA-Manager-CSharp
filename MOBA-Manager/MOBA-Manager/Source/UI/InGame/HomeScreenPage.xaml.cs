using System.Windows.Controls;

namespace MOBA_Manager.UI.InGame
{
    /// <summary>
    /// Interaction logic for HomeScreenPage.xaml
    /// </summary>
    public partial class HomeScreenPage : Page
    {
        private Game.Session playerSession;
        private DataModel.Team playerTeam;

        public HomeScreenPage(Game.Session playerSession)
        {
            InitializeComponent();
            this.playerSession = playerSession;
            this.playerTeam = playerSession.MainPlayer.Team;
            SetupUI();
        }

        private void SetupUI()
        {
            playerName.Content = playerSession.MainPlayer.GetFullName();
            teamName.Content = playerTeam.TeamName;
            teamIcon.Source = playerTeam.TeamBadge;
        }
    }
}