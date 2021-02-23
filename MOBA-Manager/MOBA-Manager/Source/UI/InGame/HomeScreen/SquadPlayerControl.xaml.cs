using MOBA_Manager.DataModel;
using System;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame
{
    /// <summary>
    /// Interaction logic for BuyPlayerControl.xaml
    /// </summary>
    public partial class SquadPlayerControl : UserControl
    {
        public event Action<Player> playerSelected;

        public SquadPlayerControl(Player p)
        {
            InitializeComponent();
            this.DataContext = this;
            this.ControlPlayer = p;

            BindData();
        }

        public void BindData()
        {
            this.PlayerPortrait.Source = ControlPlayer.IconIndex;
            this.PlayerNameLabel.Content = ControlPlayer.GetFullName();
            this.PlayerAgeLabel.Content = ControlPlayer.Age;
            this.PlayerRoleLabel.Content = ControlPlayer.GetPlayerRole();
        }

        public Player ControlPlayer { get; set; }

        private void UserControl_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            playerSelected(this.ControlPlayer);
        }
    }
}