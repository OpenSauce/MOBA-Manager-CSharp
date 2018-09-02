using MOBA_Manager.src;
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

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for SquadPage.xaml
    /// </summary>
    public partial class SquadPage : Page
    {
        public SquadPage()
        {
            InitializeComponent();
        }

        public SquadPage(List<MOBAPlayer> squad)
        {
            InitializeComponent();
        }

        public void PopulateSquadBox(User _player)
        {
            foreach (var MOBAPlayer in _player.GetTeam().GetSquad())
            {
                SquadListBox.Items.Add(MOBAPlayer.GetNickname());
            }
        }
    }
}
