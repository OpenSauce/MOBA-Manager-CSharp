using MOBA_Manager.DataModel;
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
        public User MainPlayer { get => mainPlayer; set => mainPlayer = value; }
        public List<Team> TeamList { get => teamList; set => teamList = value; }
        public List<Player> BuyablePlayers { get; set; }

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
            this.mainPlayer.Team.Cash = 5000;
            teamList.Add(this.mainPlayer.Team);
            Switcher.Switch(new MainGame(new MainGameEngine(this)));
        }

        internal List<Team> GetTeamList()
        {
            return this.teamList;
        }
    }
}