using MOBA_Manager.DataModel;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.InGameUI
{
    /// <summary>
    /// Interaction logic for BuyPlayerControl.xaml
    /// </summary>
    public partial class BuyPlayerControl : UserControl
    {
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
        }

        public Player ControlPlayer { get; set; }
    }
}