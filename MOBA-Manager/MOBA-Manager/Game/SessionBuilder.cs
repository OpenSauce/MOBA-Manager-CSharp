using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    class SessionBuilder
    {
        public SessionBuilder()
        {
            SetupGame();
        }

        public SessionBuilder(bool onLoad)
        {
            if(onLoad)
            {
                LoadSession();
            }
            else
            {
                new SessionBuilder();
            }
        }

        public Session SetupGame()
        {
            return new Session();
        }

        public Session LoadSession()
        {
            return new Session();
        }

    }
}
