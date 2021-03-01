using MOBA_Manager.DataModel;
using MOBA_Manager.Game;
using MOBA_Manager.Source.DataModel;
using System;
using System.Collections.Generic;

namespace MOBA_Manager.Source.Utilities
{
    public class FixtureBuilder
    {
        public List<Fixture> GetNewFixtures(DateTime startingDate, Session playerSession)
        {
            List<Fixture> fixtureList = new List<Fixture>();
            List<Team> teams = playerSession.TeamList;
            for (int i = 0; i < teams.Count; i++)
            {
                Fixture f = new Fixture(playerSession.MainPlayer.Team, teams[i], startingDate);
                fixtureList.Add(f);
            }
            return fixtureList;
        }
    }
}