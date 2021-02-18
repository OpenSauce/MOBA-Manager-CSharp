using MOBA_Manager.DataModel;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame.PlayerView
{
    /// <summary>
    /// Interaction logic for PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        private Player player;

        public PlayerPage(Player player)
        {
            InitializeComponent();
            this.player = player;
            ShowPlayerDetails();
        }

        private void ShowPlayerDetails()
        {
            PlayerNameLabel.Content = player.GetFullName();
        }


    }
}