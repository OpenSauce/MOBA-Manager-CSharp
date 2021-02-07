using MOBA_Manager.DataModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MOBA_Manager.UI.InGame
{
    /// <summary>
    /// Interaction logic for AllPlayersPage.xaml
    /// </summary>
    public partial class AllPlayersPage : Page
    {
        public AllPlayersPage()
        {
            InitializeComponent();
        }

        public AllPlayersPage(List<Player> playerList)
        {
            InitializeComponent();

            ObservableCollection<Player> playerCollection = new ObservableCollection<Player>();
            foreach (Player p in playerList)
            {
                playerCollection.Add(p);
            }
            dataGrid.ItemsSource = playerCollection;
        }
    }
}