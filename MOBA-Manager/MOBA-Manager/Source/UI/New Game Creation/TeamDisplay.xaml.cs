using MOBA_Manager.DataModel;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.New_Game_Creation
{
    /// <summary>
    /// Interaction logic for TeamDisplay.xaml
    /// </summary>
    public partial class TeamDisplay : UserControl
    {
        private Team team;

        public TeamDisplay()
        {
            InitializeComponent();
        }

        public void SetTeam(Team t)
        {
            this.team = t;
            TeamName.Content = team.TeamName;
            TeamImage.Source = team.TeamBadge;
        }
    }
}