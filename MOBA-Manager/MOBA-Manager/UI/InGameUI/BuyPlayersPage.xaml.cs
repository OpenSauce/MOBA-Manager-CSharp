using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOBA_Manager.UI.InGameUI
{
    /// <summary>
    /// Interaction logic for BuyPlayersPage.xaml
    /// </summary>
    public partial class BuyPlayersPage : Page
    {
        public BuyPlayersPage(List<Player> playerList)
        {
            //List<Player> playerList;
            InitializeComponent();
        }
    }
}
