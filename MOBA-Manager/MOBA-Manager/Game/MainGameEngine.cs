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
            CalculateCash(playerSession);
            CalculateTransfers(playerSession);
            ContinueTime(playerSession);
        }

        private void ContinueTime(Session playerSession)
        {
            throw new NotImplementedException();
        }

        private void CalculateTransfers(Session playerSession)
        {
            throw new NotImplementedException();
        }

        private void CalculateCash(Session playerSession)
        {
            throw new NotImplementedException();
        }
    }
}