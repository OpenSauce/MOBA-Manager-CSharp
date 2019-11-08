using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOBA_Manager.UI.InGameUI
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

            ObservableCollection<Player> users = new ObservableCollection<Player>();
            foreach (Player p in playerList) {
                users.Add(p);
            }
            dataGrid.ItemsSource = users;
        }
    }
}
