using MOBA_Manager.DataModel;
using MOBA_Manager.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    public class Session
    {
        private User mainPlayer;
        private List<Player> playerList;

        public Session() 
        {
        }

        public Session SetUser(User user)
        {
            this.mainPlayer = user;
            return this;
        }

        public void SetData(List<Player> playerList)
        {
            this.playerList = playerList;
        }

        public void Start()
        {
            Switcher.Switch(new MainGame(new MainGameEngine(this)));
        }
    }
}
