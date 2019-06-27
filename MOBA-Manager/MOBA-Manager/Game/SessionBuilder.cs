using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    class SessionBuilder
    {
        private Session session;

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

        public Session GetSession()
        {
            return this.session;
        }

        private void SetupGame()
        {
            PrepareUserCreation();
        }

        private void PrepareUserCreation()
        {
            //LoadGameDetails();
            MOBA_Manager.UI.Switcher.Switch(new MOBA_Manager.UI.UserCreation());
        }



        public Session LoadSession()
        {
            return new Session();
        }

    }
}
