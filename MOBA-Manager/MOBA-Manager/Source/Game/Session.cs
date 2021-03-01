using MOBA_Manager.DataModel;
using MOBA_Manager.Source.DataModel;
using MOBA_Manager.UI;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    public class Session
    {
        private User mainPlayer;
        private List<Player> playerList;
        private List<Team> teamList;

        public List<Fixture> FixturesList { get; set; }
        public User MainPlayer { get => mainPlayer; set => mainPlayer = value; }
        public List<Team> TeamList { get => teamList; set => teamList = value; }
        public List<Player> BuyablePlayers { get; set; }
        public DateTime GameTime { get; set; }

        private MainGameEngine engine;

        public Session()
        {
        }

        public Session SetUser(User user)
        {
            this.mainPlayer = user;
            return this;
        }

        public String GetUserFullName()
        {
            return mainPlayer.GetFullName();
        }

        public string GetCash()
        {
            return "£" + this.mainPlayer.Team.Cash;
        }

        public void SetPlayerData(List<Player> playerList)
        {
            this.playerList = playerList;
        }

        public void SetTeamData(List<Team> teamList)
        {
            this.teamList = teamList;
        }

        public List<Player> GetPlayerList()
        {
            return this.playerList;
        }

        public void Start()
        {
            if (engine == null)
            {
                engine = new MainGameEngine(this);
            }
            Switcher.Switch(new MainGame(engine));
        }

        internal List<Team> GetTeamList()
        {
            return this.teamList;
        }
    }
}