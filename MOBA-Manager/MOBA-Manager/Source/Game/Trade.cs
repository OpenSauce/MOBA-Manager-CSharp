using MOBA_Manager.DataModel;

namespace MOBA_Manager.Source.Game
{
    public class Trade
    {
        public Player TradedPlayer { get; set; }

        public Trade(Player player)
        {
            this.TradedPlayer = player;
        }
    }
}