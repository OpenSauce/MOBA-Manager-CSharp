using MOBA_Manager.DataModel;
using System.Collections.Generic;

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
            this.session.BuyablePlayers = LoadBuyablePlayers();
            this.session.SetTeamData(LoadTeams());
        }

        private List<Player> LoadBuyablePlayers()
        {
            IPlayerFactory playerCreator = new PlayerGenerator();
            return playerCreator.LoadPlayers();
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