using MOBA_Manager.DataModel;
using MOBA_Manager.Game;
using MOBA_Manager.Source.Game;
using MOBA_Manager.Source.UI.InGame;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MOBA_Manager.UI.InGame
{
    /// <summary>
    /// Interaction logic for BuyPlayersPage.xaml
    /// </summary>
    public partial class BuyPlayersPage : Page
    {
        private List<Player> playerList;
        private Session session;

        public BuyPlayersPage(List<Player> playerList, Session session)
        {
            this.playerList = playerList;
            this.session = session;
            InitializeComponent();
            DisplayBuyablePlayers();
        }

        private void BuyPlayer_Click(Trade p)
        {
            this.session.MainPlayer.Team.Roster.Add(p.TradedPlayer);
            playerList.Remove(p.TradedPlayer);
            DisplayBuyablePlayers();
        }

        private void DisplayBuyablePlayers()
        {
            BuyPlayerStackPanel.Children.Clear();
            foreach (Player p in playerList)
            {
                BuyPlayerControl buyPlayerControl = new BuyPlayerControl(p);
                buyPlayerControl.buyPlayer += BuyPlayer_Click;
                BuyPlayerStackPanel.Children.Add(buyPlayerControl);
            }
        }
    }
}