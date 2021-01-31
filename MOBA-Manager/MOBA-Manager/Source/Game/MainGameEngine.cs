using MOBA_Manager.DataModel;
using System;

namespace MOBA_Manager.Game
{
    public class MainGameEngine
    {
        private Session playerSession;

        public MainGameEngine(Session session)
        {
            this.playerSession = session;
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
            ///CalculateTransfers();
            //CalculatePlayerUpdates();
           // CalculateTeamUpdates();
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