using MOBA_Manager.Source.DataModel;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame.Fixtures
{
    /// <summary>
    /// Interaction logic for FixtureControl.xaml
    /// </summary>
    public partial class FixtureControl : UserControl
    {
        public FixtureControl(Fixture f)
        {
            InitializeComponent();
            AwayTeam.Content = f.AwayTeam;
            HomeTeam.Content = f.HomeTeam;
        }
    }
}