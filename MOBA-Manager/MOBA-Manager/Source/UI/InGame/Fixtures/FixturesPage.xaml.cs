using MOBA_Manager.Source.DataModel;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame.Fixtures
{
    /// <summary>
    /// Interaction logic for FixturesPage.xaml
    /// </summary>
    public partial class FixturesPage : Page
    {
        public FixturesPage(List<Fixture> fixturesList)
        {
            InitializeComponent();
        }
    }
}