using MOBA_Manager.DataModel;
using MOBA_Manager.Source.DataModel;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    public class SessionDirector
    {
        private Session session = null;

        public SessionDirector()
        {
            SetupSessionAndUI();
        }

        public SessionDirector(bool onLoad)
        {
            new SessionDirector();
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
            this.session.FixturesList = GenerateInitialFixtures();
        }

        private List<Fixture> GenerateInitialFixtures()
        {
            return new List<Fixture>();
        }

        private List<Player> LoadBuyablePlayers()
        {
            PlayerGenerator playerCreator = new PlayerGenerator();
            return playerCreator.GeneratePlayers(5);
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