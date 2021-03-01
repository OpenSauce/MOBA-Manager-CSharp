using MOBA_Manager.DataModel;
using System;

namespace MOBA_Manager.Source.DataModel
{
    public class Fixture
    {
        public DateTime MatchTime { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public Fixture(Team homeTeam, Team awayTeam, DateTime matchTime)
        {
            this.MatchTime = matchTime;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }
    }
}