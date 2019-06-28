using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    public class MainGameEngine
    {
        Session playerSession;

        public MainGameEngine(Session session)
        {
            this.playerSession = session;
        }
    }
}
