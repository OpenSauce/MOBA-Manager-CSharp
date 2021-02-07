using MOBA_Manager.DataModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MOBA_Manager.UI.InGame
{
    /// <summary>
    /// Interaction logic for AllPlayersPage.xaml
    /// </summary>
    public partial class AllTeamsPage : Page
    {
        public AllTeamsPage()
        {
            InitializeComponent();
        }

        public AllTeamsPage(List<Team> teamList)
        {
            InitializeComponent();

            ObservableCollection<Team> teamCollection = new ObservableCollection<Team>();
            foreach (Team t in teamList)
            {
                teamCollection.Add(t);
            }
            dataGrid.ItemsSource = teamCollection;
        }
    }
}