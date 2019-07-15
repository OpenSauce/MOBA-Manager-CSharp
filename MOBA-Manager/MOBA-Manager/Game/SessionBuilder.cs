using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    public class SessionBuilder
    {
        private Session session = null;

        public SessionBuilder()
        {
            SetupSessionAndUI();
        }

        public SessionBuilder(bool onLoad)
        {
            new SessionBuilder();
        }

        public Session GetSession()
        {
            return this.session;
        }

        private void SetupSessionAndUI()
        {
            SetupSession();
            SetUserCreationUI();
        }

        private void SetupSession()
        {
            this.session = new Session();
            LoadGameEntities();
            
        }

        private void LoadGameEntities()
        {
            this.session.SetPlayerData(LoadPlayers());
            this.session.SetTeamData(LoadTeams());
        }

        public List<Player> LoadPlayers()
        {
            IPlayerFactory playerCreator = new PlayerGenerator();
            return playerCreator.LoadPlayers();
        }

        public List<Team> LoadTeams()
        {
            ITeamFactory teamCreator = new TeamGenerator();
            return teamCreator.LoadTeams();
        }

        private void SetUserCreationUI()
        {
            MOBA_Manager.UI.Switcher.Switch(new MOBA_Manager.UI.UserCreation(this));
        }

        public Session SetSessionUser(User user)
        {
            return this.session.SetUser(user);
        }


    }
}
