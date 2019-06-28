using MOBA_Manager.DataModel;
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
        public Session() 
        {
        }

        public void LoadGameEntities()
        {
            IPlayerFactory hello = new PlayerGenerator();
        }

        public Session SetUser(User user)
        {
            this.mainPlayer = user;
            return this;
        }

        public void Start()
        {

        }
    }
}
