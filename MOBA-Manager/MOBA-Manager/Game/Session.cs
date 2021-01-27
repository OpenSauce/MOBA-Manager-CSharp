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
        private long cash;

        public User MainPlayer { get => mainPlayer; set => mainPlayer = value; }
        public long Cash { get => cash; set => cash = value; }

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
            return "£" + cash;
        }

        public void SetPlayerData(List<Player> playerList)
        {
            this.cash = 5000;
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
            //Logic for loading or creating new game
            Switcher.Switch(new MainGame(new MainGameEngine(this)));
        }
    }
}