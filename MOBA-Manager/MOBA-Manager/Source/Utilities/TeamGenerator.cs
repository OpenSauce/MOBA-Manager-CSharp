using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MOBA_Manager.Game
{
    public class TeamGenerator : ITeamFactory
    {
        private const int MAX_TEAMS = 10;

        public List<Team> LoadTeams()
        {
            return GenerateListOfTeams(new List<Team>());
        }

        public void PopulateTeamsWithPlayers()
        {
            throw new NotImplementedException();
        }

        private List<Team> GenerateListOfTeams(List<Team> teamList)
        {
            string[] teamNames = GetTeamNames();
            for (int i = 0; i < teamNames.Length; i++)
            {
                teamList.Add(GenerateNewTeam(teamNames[i]));
            }

            return teamList;
        }

        private string[] GetTeamNames()
        {
            string[] teamNames = {
                "Blue Azuls",
                "Concert Crashers",
                "Duggly Hucklings",
                "Goochy Conkers",
                "Kryptonite",
                "Pineapple Fury",
                "Red Rouges",
                "Shrew Crew",
                "Team 1",
                "Team 2",
                "Team 3",
                "Team 4",
                "Team 5",
                "Fire Makers",
                "The Duelists",
                "The Fisters",
                "The Stabby Stabbers",
                "We Piss In Bottles"
            };
            Array.Sort(teamNames, (x, y) => String.Compare(x, y));
            return teamNames;
        }

        public static Team GenerateNewTeam(String teamName)
        {
            Team generatedTeam = new Team();
            generatedTeam.SetTeamName(teamName);
            generatedTeam.TeamBadge = GetTeamBadge(teamName);
            generatedTeam.Reputation = ControlledRandom.RandomNumber(1, 1000);
            return generatedTeam;
        }

        public static BitmapImage GetTeamBadge(string teamName)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"\Assets\Badges\" + teamName + ".png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            return bi;
        }
    }
}