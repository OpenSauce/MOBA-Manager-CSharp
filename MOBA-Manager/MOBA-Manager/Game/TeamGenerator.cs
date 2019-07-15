﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    public class TeamGenerator : ITeamFactory
    {
        private const int MAX_TEAMS = 10;

        public List<Team> LoadTeams()
        {
            return GenerateListOfTeams(new List<Team>());
        }

        private List<Team> GenerateListOfTeams(List<Team> teamList)
        {
            for (int i = 0; i < MAX_TEAMS; i++)
            {
                teamList.Add(GenerateNewTeam("GeneratedTeam" + i.ToString()));
            }

            return teamList;
        }

        private Team GenerateNewTeam(String teamName)
        {
            Team generatedTeam = new Team();
            generatedTeam.SetTeamName(teamName);
            return generatedTeam;
        }
    }
}