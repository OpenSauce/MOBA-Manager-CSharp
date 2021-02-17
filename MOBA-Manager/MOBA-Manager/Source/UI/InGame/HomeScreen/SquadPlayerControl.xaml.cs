using MOBA_Manager.DataModel;
using MOBA_Manager.Source.UI.InGame.PlayerView;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGame
{
    /// <summary>
    /// Interaction logic for BuyPlayerControl.xaml
    /// </summary>
    public partial class SquadPlayerControl : UserControl
    {
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
            MOBA_Manager.UI.Switcher.SwitchIngame(new PlayerPage());
        }
    }
}