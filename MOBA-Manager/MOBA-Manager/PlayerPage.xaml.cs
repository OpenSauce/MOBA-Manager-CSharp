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
    /// Interaction logic for PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        private MOBAPlayer _player;
        private SquadPage _parent;

        private PlayerPage()
        {
            InitializeComponent();
        }

        public PlayerPage(SquadPage parent, MOBAPlayer player)
        {
            InitializeComponent();
            this._parent = parent;
            this._player = player;
            LoadPlayerDetails(_player);
        }

        private void LoadPlayerDetails(MOBAPlayer player)
        {
            playerNameLabel.Content = _player.Nickname;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            _parent.ReturnPage();
        }
    }
}
