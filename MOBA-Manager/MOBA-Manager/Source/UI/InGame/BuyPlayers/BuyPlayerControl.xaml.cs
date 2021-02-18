using MOBA_Manager.DataModel;
using MOBA_Manager.Source.Game;
using System;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame
{
    /// <summary>
    /// Interaction logic for BuyPlayerControl.xaml
    /// </summary>
    public partial class BuyPlayerControl : UserControl
    {
        public event Action<Trade> buyPlayer;

        public BuyPlayerControl(Player p)
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
            this.PlayerRoleLabel.Content = ControlPlayer.GetPlayerRole();
        }

        public Player ControlPlayer { get; set; }

        private void BuyButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            buyPlayer(new Trade(this.ControlPlayer));
        }
    }
}