using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src
{
    public class Manager
    {
        protected String _name;
        protected int _age;
        protected Team _team;
        protected Int64 _cash;

        public Manager()
        {
            _cash = 10000;
        }

        public void SetName(String name)
        {
            this._name = name;
        }

        public String GetName()
        {
            return this._name;
        }

        public int GetAge()
        {
            return this._age;
        }

        public void SetTeam(Team team)
        {
            this._team = team;
        }

        public Team GetTeam()
        {
            return this._team;
        }

        public String GetTeamName()
        {
            return _team.GetTeamName();
        }

        public String GetCashString()
        {
            return _cash.ToString("C", new System.Globalization.CultureInfo("en-GB"));
        }
    }
}
