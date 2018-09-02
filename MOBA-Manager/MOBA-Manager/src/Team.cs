using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{
    public class Team
    {
        protected String _teamName;
        public Team(String teamName) 
        {
            this._teamName = teamName;
        }

        public String GetTeamName()
        {
            return _teamName;
        }
    }
}
