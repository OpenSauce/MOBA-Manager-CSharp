using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MOBA_Manager.DataModel
{
    public class Team
    {
        private double reputation;
        private List<Player> roster;
        private String teamName;
        private Double cash;
        private BitmapImage teamBadge;
        public BitmapImage TeamBadge { get => teamBadge; set => teamBadge = value; }
        public String TeamName { get => teamName; set => teamName = value; }
        public Double Reputation { get => reputation; set => reputation = value; }
        public Double Cash { get => cash; set => cash = value; }
        public List<Player> Roster { get; set; }

        public String GetTeamName()
        {
            return this.teamName;
        }

        public void SetTeamName(String name)
        {
            this.teamName = name;
        }

        internal void AddCash(Double increment)
        {
            this.cash += increment;
        }

        public override string ToString()
        {
            return this.teamName;
        }
    }
}