using MOBA_Manager.DataModel;
using System;
using System.Windows.Controls;

namespace MOBA_Manager.Source.UI.Training
{
    /// <summary>
    /// Interaction logic for PlayerTrainingControl.xaml
    /// </summary>
    public partial class PlayerTrainingControl : UserControl
    {
        public event Action<Player> trainPlayer;

        public PlayerTrainingControl(Player p)
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
            this.PlayerRatingLabel.Content = ControlPlayer.CurrentSkill;
        }

        public Player ControlPlayer { get; set; }

        private void BuyButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            trainPlayer(this.ControlPlayer);
        }
    }
}