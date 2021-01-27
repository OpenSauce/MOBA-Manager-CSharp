using System;
using System.Collections.Generic;

namespace MOBA_Manager.DataModel
{
    public class Team
    {
        private int reputation;
        private List<Player> roster;
        private String teamName;
        private int cash;

        public int Reputation { get => reputation; set => reputation = value; }
        public int Cash { get => cash; set => cash = value; }

        public String GetTeamName()
        {
            return this.teamName;
        }

        public void SetTeamName(String name)
        {
            this.teamName = name;
        }

        internal void AddCash(int increment)
        {
            this.cash += increment;
        }
    }
}