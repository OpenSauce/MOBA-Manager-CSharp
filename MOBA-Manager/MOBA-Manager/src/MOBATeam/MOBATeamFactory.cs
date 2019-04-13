using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src.MOBATeam
{
    public class MOBATeamFactory
    {
        int iteration;

        public MOBATeamFactory()
        {
            this.iteration = 0;
        }

        public Team generateRandomTeam()
        {
            Team team = new Team("");
            iteration++;
            return team;
        }
    }
}
