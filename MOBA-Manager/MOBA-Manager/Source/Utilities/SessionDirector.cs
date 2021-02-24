using MOBA_Manager.DataModel;
using MOBA_Manager.Source.DataModel;
using MOBA_Manager.Source.Utilities;
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
            this.session.GameTime = new DateTime(2020, 1, 1);
            LoadGameEntities();
        }

        private void LoadGameEntities()
        {
            this.session.SetPlayerData(LoadPlayers());
            this.session.BuyablePlayers = LoadBuyablePlayers();
            this.session.SetTeamData(LoadTeams());
        }

        private List<Fixture> GenerateInitialFixtures()
        {
            return new FixtureBuilder().GetNewFixtures(this.session.GameTime, this.session);
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
            this.session.SetUser(user);
            this.session.FixturesList = GenerateInitialFixtures();
            return this.session;
        }
    }
}