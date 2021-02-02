using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    public class MainGameEngine
    {
        private Session playerSession;
        private PlayerGenerator playerGenerator;

        public MainGameEngine(Session session)
        {
            this.playerSession = session;
            this.playerGenerator = new PlayerGenerator();
        }

        public Session PlayerSession { get => playerSession; set => playerSession = value; }

        public void ProceedGame()
        {
            CalculateDataUpdates();
            //ContinueTime();
        }

        private void CalculateDataUpdates()
        {
            CalculateCash();
            GenerateBuyablePlayers();
            //CalculateTransfers();
            //CalculatePlayerUpdates();
            // CalculateTeamUpdates();
        }

        private void GenerateBuyablePlayers()
        {
            if(playerSession.BuyablePlayers != null && playerSession.BuyablePlayers.Count > 0) 
            {
                List<Player> newList = playerSession.GetPlayerList();
                newList.AddRange(playerSession.BuyablePlayers);
                playerSession.SetPlayerData(newList);
            }
            List<Player> newBuyableList = new List<Player>();
            for (int i = 0; i < 5; i++)
            {
                newBuyableList.Add(playerGenerator.GenerateNewPlayer());
            }
            playerSession.BuyablePlayers = newBuyableList;

        }

        private void CalculateTeamUpdates()
        {
            throw new NotImplementedException();
        }

        private void CalculatePlayerUpdates()
        {
            throw new NotImplementedException();
        }

        private void ContinueTime()
        {
            throw new NotImplementedException();
        }

        private void CalculateTransfers()
        {
            throw new NotImplementedException();
        }

        private void CalculateCash()
        {
            var TeamList = playerSession.TeamList;
            foreach (Team t in TeamList)
            {
                t.AddCash(t.Reputation * 0.8);
            }
        }
    }
}