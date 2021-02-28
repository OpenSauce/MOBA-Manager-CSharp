using MOBA_Manager.DataModel;
using MOBA_Manager.Source.UI.Training;
using MOBA_Manager.UI;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    public class MainGameEngine
    {
        private static Session playerSession;
        private PlayerGenerator playerGenerator;
        public STATE state;

        public MainGameEngine(Session session)
        {
            playerSession = session;
            this.playerGenerator = new PlayerGenerator();
            state = STATE.NEWs;
        }

        public Session PlayerSession { get => playerSession; set => playerSession = value; }

        public void ProceedGame()
        {
            CalculateDataUpdates();
            ContinueTime();
        }

        private void CalculateDataUpdates()
        {
            CalculateCash();
            GenerateBuyablePlayers();
            UpdateState();
            //CalculateTransfers();
            //CalculatePlayerUpdates();
            // CalculateTeamUpdates();
        }

        private void UpdateState()
        {
            switch (state)
            {
                case STATE.NEWs:
                    break;

                case STATE.TRAINING:
                    Switcher.Switch(new TrainingScreen());
                    break;

                case STATE.MATCH:
                    break;
            }
            state = ((int)state + 1 == 3) ? 0 : state + 1;
        }

        private void GenerateBuyablePlayers()
        {
            if (playerSession.BuyablePlayers != null && playerSession.BuyablePlayers.Count > 0)
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
            playerSession.GameTime = playerSession.GameTime.AddDays(3);
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

        public enum STATE
        {
            NEWs = 0,
            TRAINING = 1,
            MATCH = 2
        }
    }
}