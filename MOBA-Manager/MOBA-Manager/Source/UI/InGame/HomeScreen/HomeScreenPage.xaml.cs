using MOBA_Manager.DataModel;
using MOBA_Manager.Source.UI.InGame;
using MOBA_Manager.Source.UI.InGame.PlayerView;
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
            cashLabel.Content = playerTeam.GetCash();
            numberOfPlayerLabel.Content = playerTeam.GetNumberOfPlayers();
            SetupTeamList();
        }

        private void playerSelected_Click(Player p)
        {
            Switcher.SwitchIngame(new PlayerPage(p));
        }

        private void SetupTeamList()
        {
            if (playerTeam.Roster != null)
            {
                foreach (Player p in playerTeam.Roster)
                {
                    SquadPlayerControl squadPlayerControl = new SquadPlayerControl(p);
                    squadPlayerControl.playerSelected += playerSelected_Click;
                    Squad.Children.Add(squadPlayerControl);
                }
            }
        }
    }
}