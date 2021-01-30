using System;
using System.Collections.Generic;

namespace MOBA_Manager.DataModel
{
    public class Team
    {
        private double reputation;
        private List<Player> roster;
        private String teamName;
        private Double cash;

        public Double Reputation { get => reputation; set => reputation = value; }
        public Double Cash { get => cash; set => cash = value; }

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
    }
}