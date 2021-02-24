using MOBA_Manager.DataModel;
using System;

namespace MOBA_Manager.Source.DataModel
{
    public class Fixture
    {
        private DateTime matchTime;
        private Team homeTeam;
        private Team awayTeam;

        public Fixture(Team homeTeam, Team awayTeam, DateTime matchTime)
        {
            this.matchTime = matchTime;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }
    }
}